using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateP5aApp
{
    public partial class MainForm : Form
    {
        int MaxColumnCount; // column 總數
        Dictionary<string, string> mapVer = new Dictionary<string, string>();   // 儲存各版本名稱
        bool FormatAppXML;  // 判斷校勘格式是否有格式化
        // 一些正規式
        Regex regexDate = new Regex(@"^\d{4}\-\d{2}\-\d{2}$");
        Regex regexCorr = new Regex(@"\[([^\[]*?)([>=])(.*?)\]");
        Regex regexLineHead = new Regex(@"([A-Z]+)\d+n.{5}p(.{7})"); // T01n0001_p0001a01
        Regex regexCf = new Regex(@"(cf\d)\s*[:：]\s*(\S*)");
        Regex regexCBPs = new Regex(@"CBETA\s*按：.*");

        public MainForm()
        {
            InitializeComponent();
            LoadVerTxt();               // 載入版本列表, 格式為 A=【金藏】
            LoadRefVer();                // 載入引用的版本, 格式為【金藏】
            Size = Properties.Settings.Default.FormSize;
            myDataGridView.CurrentCell = myDataGridView[0, 0];
            MaxColumnCount = myDataGridView.Columns.Count;
            // 在標題加入版本號
            string ver = typeof(MainForm).Assembly.GetName().Version.ToString();
            Text = Text + " - v" + ver.Replace(".0.0", "");
        }

        private void btPaste_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if(o.GetDataPresent(DataFormats.UnicodeText)) {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.UnicodeText).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                // 算一下行數夠不夠? 不夠要加
                int myRowIndex = myDataGridView.CurrentRow.Index;
                int totalRowCount = myDataGridView.Rows.Count;
                if(totalRowCount <= myRowIndex + pastedRows.Length) {
                    myDataGridView.Rows.Add(myRowIndex + pastedRows.Length - totalRowCount + 1);
                }

                foreach(string pastedRow in pastedRows) {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });
                    using(DataGridViewRow myDataGridViewRow = myDataGridView.Rows[myRowIndex]) {
                        for(int i = 0; i < pastedRowCells.Length; i++) {
                            if(i == MaxColumnCount) {
                                // 最後一欄是編號, 不要複製資料
                                break;
                            }
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i].Trim('"');
                        }
                    }
                    myRowIndex++;
                }
            }
        }

        private void myDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.V && e.Control) {
                btPaste_Click(sender, e);
            }
        }

        // 分析此行
        private void btAnalysis_Click(object sender, EventArgs e)
        {
            int myRowIndex = myDataGridView.CurrentRow.Index;
            if(myDataGridView[0, myRowIndex].Style.BackColor.A != 0) {
                MessageBox.Show("此行不用分析");
                return;
            }

            // 取得修訂後文字

            string sAfterModify = GetGridValue(myDataGridView.CurrentRow.Cells[3]);
            // 先把模糊字 <□> 換成全型＜□＞，免得干擾修訂符號 [A>B]
            sAfterModify = sAfterModify.Replace("<□>", "＜□＞");

            // 可能有多行, 要逐行處理, 才能分離行首資料
            string[] Lines = sAfterModify.Split('\r', '\n');

            // 每一組可能有 n 行, 每一行 m 個校勘, 就有 n * m 個新行了
            int newLineCount = 0;   
            foreach(string line in Lines) {
                MatchCollection matchsCorr = regexCorr.Matches(line);   // 找出修訂
                if(matchsCorr.Count > 0) {
                    Match matchLienHead = regexLineHead.Match(line);    // 找出編號
                    string sID = "";
                    string sLineHead = "";
                    if(matchLienHead.Success) {
                        sID = matchLienHead.Groups[1].Value;      // 找到藏經 ID了
                        sLineHead = matchLienHead.Groups[2].Value;      // 找到編號了
                    }
                    myDataGridView.Rows.Insert(myRowIndex + newLineCount + 1, matchsCorr.Count);   // 插入空白
                    for(int i = 0; i < matchsCorr.Count; i++) {
                        ChangeRowBGColor(myRowIndex + newLineCount + 1, Color.LightGreen); // 變綠色
                        CopyRowDataFrom(myRowIndex, myRowIndex + newLineCount + 1);        // 複製資料
                        myDataGridView[2, myRowIndex + newLineCount + 1].Value = matchsCorr[i].Groups[1].Value.Replace("＜□＞", "<□>");
                        myDataGridView[3, myRowIndex + newLineCount + 1].Value = matchsCorr[i].Groups[3].Value.Replace("＜□＞", "<□>");
                        myDataGridView[5, myRowIndex + newLineCount + 1].Value = matchsCorr[i].Groups[2].Value;
                        myDataGridView[6, myRowIndex + newLineCount + 1].Value = "";
                        myDataGridView[8, myRowIndex + newLineCount + 1].Value = sID;
                        myDataGridView[9, myRowIndex + newLineCount + 1].Value = sLineHead;
                        myDataGridView[9, myRowIndex + newLineCount + 1].Value += (i + 1).ToString("00");
                        newLineCount += 1;
                    }
                }
            }
            ChangeRowBGColor(myRowIndex, Color.LightPink);
        }
        void ChangeRowBGColor(int myRowIndex, Color color)
        {
            for(int i = 0; i < myDataGridView.Columns.Count; i++) {
                myDataGridView[i, myRowIndex].Style.BackColor = color;
            }
        }

        void CopyRowDataFrom(int from, int to)
        {
            for(int i = 0; i < myDataGridView.Columns.Count; i++) {
                myDataGridView[i, to].Value = myDataGridView[i, from].Value;
            }
            
        }

        // 產生校勘
        private void btCreateApp_Click(object sender, EventArgs e)
        {
            int Y = myDataGridView.CurrentRow.Index;
            if(Y < 0) {
                MessageBox.Show("請在表格中選擇要處理的那一列");
                return;
            }

            string sDate = GetGridValue(0, Y);
            string sProvider = GetGridValue(1, Y);
            string sSic = GetGridValue(2, Y);
            string sCorr = GetGridValue(3, Y);
            string sCfs = GetGridValue(4, Y);
            string sSign = GetGridValue(5, Y);
            string sResp = GetGridValue(7, Y);

            string sID = GetGridValue(8, Y);            // 藏經 ID
            string sLineHead = GetGridValue(9, Y);      // 校註編號
            string sVer = "";                   // 版本, 預設是大正藏【大】

            // 傳入ID T,  傳回【大】
            sVer = CheckIDVer(sID);

            string sRefVer = tbRefVer.Text;     // 參考版本【麗-CB】
            string sCf = Check_Cf(sCfs);
            string sCBPs = Check_CBPs(sCfs);      // 取出 （CBETA按：.....）的文字放在 <note> 文字後面

            /*
	        <note n="0003a1101" resp="CBETA" type="add" subtype="規範字詞">尼【CB】【麗-CB】，尸【大】</note>
	        <app n="0003a1101">
		        <lem wit="【CB】【麗-CB】" resp="CBETA.maha" cb:provider="某甲 (2018-10-01)">尼
		        <note type="cf1">K17n0647_p0839b07</note>
		        <note type="cf2">T01n0001_p0026c15</note>
		        </lem>
		        <rdg wit="【大】">尸</rdg>
	        </app>
	        */

            if(sProvider == "" || sProvider.IndexOf("CBETA.") >= 0) {
                sProvider = "";
            } else {
                sProvider = " cb:provider=\"" + sProvider;
                if(sDate != "") sProvider += " (" + sDate + ")";
                sProvider += "\"";
            }

            sCorr = sCorr.Replace("<□>", "<unclear/>");
            sSic = sSic.Replace("<□>", "<unclear/>");
            sCorr = sCorr.Replace("　", "<space quantity=\"1\" unit=\"chars\"/>");
            sSic = sSic.Replace("　", "<space quantity=\"1\" unit=\"chars\"/>");

            string sCorrNote = sCorr;
            string sSicNote = sSic;

            if(sCorr == "") {
                sCorr = "<space quantity=\"0\"/>";
                sCorrNote = "〔－〕";
            }
            if(sSic == "") {
                sSic = "<space quantity=\"0\"/>";
                sSicNote = "〔－〕";
            }

            if(sSign == "=") {
                sSign = " subtype = \"規範字詞\"";
            } else {
                sSign = ""; 
            }

            string sResult = "<note n=\"" + sLineHead + "\" resp=\"CBETA\" type=\"add\"" + sSign + ">"
                + sCorrNote + "【CB】" + sRefVer + "，" + sSicNote + sVer + sCBPs + "</note>"
                + "<app n=\"" + sLineHead + "\">"
                + "<lem wit=\"【CB】" + sRefVer + "\" resp=\"" + sResp + "\"" + sProvider
                + ">" + sCorr + sCf + "</lem>"
                + "<rdg wit=\"" + sVer + "\">" + sSic + "</rdg>"
                + "</app>";

            tbApp.Text = sResult;

            if(sCorr == sSic) {
                MessageBox.Show("警告 : 修訂前後的內容都一樣");
            }
            if(sLineHead.Length != 9) {
                MessageBox.Show("警告 : 編號長度不是 9");
            }
            if(sLineHead == "xxxxxxxxx") {
                MessageBox.Show("警告 : 沒有編號");
            }
            if(sResp == "") {
                MessageBox.Show("警告 : 沒有修訂確認者");
            }
            if(sProvider != "") {
                if(!regexDate.IsMatch(sDate)) {
                    MessageBox.Show("警告 : 日期格式不對");
                }
            }
            FormatAppXML = false;
            btFormatAppXML_Click(sender, e);
        }

        string GetGridValue(int x, int y)
        {
            return GetGridValue(myDataGridView[x, y]);
        }
        string GetGridValue(DataGridViewCell cell)
        {
            return cell.Value == null ? "" : cell.Value.ToString();
        }

        //---------------------------------------------------------------------------
        // 處理修訂依據
        // 原本可能是這樣

        // cf1: K17n0647_p0839b07
        // cf2 : T01n0001_p0026c15

        // 處理成這樣
        // <note type="cf1">K17n0647_p0839b07</note><note type="cf2">T01n0001_p0026c15</note>

        string Check_Cf(string sCfs)
        {
	        string sCf = "";
	        MatchCollection matchsCf = regexCf.Matches(sCfs);

		    if(matchsCf.Count > 0)
		    {
                foreach(Match matchCf in matchsCf) {
                    string scf = matchCf.Groups[1].Value;
                    string sLineHead = matchCf.Groups[2].Value;
                    // <note type="cf1">K17n0647_p0839b07</note>
                    sCf += "<note type=\"" + scf + "\">" + sLineHead + "</note>";
                }
		    }
            return sCf;
        }

        // 取出 "CBETA按：.... " 文字
        string Check_CBPs(string sCfs)
        {
            string sCBPs = "";
            sCfs = sCfs.Replace("\r", "");
            sCfs = sCfs.Replace("\n", "");
            MatchCollection matchsCf = regexCBPs.Matches(sCfs);

            if(matchsCf.Count > 0) {
                foreach(Match matchCf in matchsCf) {
                    sCBPs = "（" + matchCf.Groups[0].Value + "）";
                }
            }
            return sCBPs;
        }

        //---------------------------------------------------------------------------
        // 傳入ID , 可能是 T01n0001_p0001a0101
        // T 傳回【大】, sID 會傳回 0001a0101
        string CheckIDVer(string sID)
        {
            string sVer = "";
            if(mapVer.ContainsKey(sID)) {
                sVer = mapVer[sID];    // 【大】
            } else {
                sVer = "【" + sVer + "】";
                MessageBox.Show("無法判斷此校註的原始版本");
            }
            return sVer;
        }
        //---------------------------------------------------------------------------
        // 載入版本列表, 格式為 A=金藏
        void LoadVerTxt()
        {
            string[] slVer = File.ReadAllLines("verlist.txt", Encoding.UTF8);

            for(int i = 0; i < slVer.Length; i++) {
                String sStr = slVer[i];
                int iPos = sStr.IndexOf('=');
                String sID = sStr.Substring(0, iPos);
                sStr = sStr.Substring(iPos + 1);
                sID = sID.Trim();
                sStr = sStr.Trim();
                mapVer[sID] = sStr;
            }
        }

        void LoadRefVer()
        {
            string[] slVer = File.ReadAllLines("refver.txt", Encoding.UTF8);
            foreach(string item in slVer) {
                lbRefVer.Items.Add(item);
            }
        }

        private void btFormatAppXML_Click(object sender, EventArgs e)
        {
            if(FormatAppXML) {
                // 還原成沒有格式化
                tbApp.Text = UnFormatXML(tbApp.Text);
            } else {
                tbApp.Text = FormatXML(tbApp.Text);
            }
            FormatAppXML = !FormatAppXML;
        }

        string UnFormatXML(string str)
        {
            str = str.Replace("\r\n", "");
            str = str.Replace("\t", "");
            return str;
        }

        string FormatXML(string str)
        {
            str = str.Replace("<app ", "\r\n<app ");
            str = str.Replace("<lem ", "\r\n\t<lem ");
            str = str.Replace("<rdg ", "\r\n\t<rdg ");
            str = str.Replace("</app>", "\r\n</app>");
            if(str.Contains("<note type=\"cf")) {
                str = str.Replace("<note type=\"cf", "\r\n\t\t<note type=\"cf");
                str = str.Replace("</lem>", "\r\n\t</lem>");
            }
            return str;
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            string sCopy = tbApp.Text;
            sCopy = UnFormatXML(sCopy);
            Clipboard.SetText(sCopy);
        }

        private void lbRefVer_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sele = lbRefVer.SelectedItems;
            for(int i=0; i<lbRefVer.Items.Count; i++) { 

                if(sele.Contains(lbRefVer.Items[i])) {
                    if(!tbRefVer.Text.Contains(lbRefVer.Items[i].ToString())) {
                        tbRefVer.Text += lbRefVer.Items[i].ToString();
                    }
                } else {
                    if(tbRefVer.Text.Contains(lbRefVer.Items[i].ToString())) {
                        tbRefVer.Text = tbRefVer.Text.Replace(lbRefVer.Items[i].ToString(), "");
                    }
                }
            }
        }

        private void btClearRefVer_Click(object sender, EventArgs e)
        {
            tbRefVer.Text = "";
            lbRefVer.SelectedIndex = -1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormSize = Size;
            Properties.Settings.Default.Save();
        }
    }
}
