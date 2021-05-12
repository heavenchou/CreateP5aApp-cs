
namespace CreateP5aApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRefVer = new System.Windows.Forms.ListBox();
            this.btCopy = new System.Windows.Forms.Button();
            this.btFormatAppXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRefVer = new System.Windows.Forms.TextBox();
            this.btCreateApp = new System.Windows.Forms.Button();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.btAnalysis = new System.Windows.Forms.Button();
            this.btPaste = new System.Windows.Forms.Button();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClearRefVer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClearRefVer);
            this.panel1.Controls.Add(this.lbRefVer);
            this.panel1.Controls.Add(this.btCopy);
            this.panel1.Controls.Add(this.btFormatAppXML);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbRefVer);
            this.panel1.Controls.Add(this.btCreateApp);
            this.panel1.Controls.Add(this.tbApp);
            this.panel1.Controls.Add(this.btAnalysis);
            this.panel1.Controls.Add(this.btPaste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 281);
            this.panel1.TabIndex = 0;
            // 
            // lbRefVer
            // 
            this.lbRefVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRefVer.FormattingEnabled = true;
            this.lbRefVer.ItemHeight = 23;
            this.lbRefVer.Location = new System.Drawing.Point(128, 55);
            this.lbRefVer.Name = "lbRefVer";
            this.lbRefVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRefVer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRefVer.Size = new System.Drawing.Size(117, 211);
            this.lbRefVer.TabIndex = 3;
            this.lbRefVer.Click += new System.EventHandler(this.lbRefVer_Click);
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopy.Location = new System.Drawing.Point(1115, 12);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(75, 35);
            this.btCopy.TabIndex = 6;
            this.btCopy.Text = "複製";
            this.toolTip1.SetToolTip(this.btCopy, "複製底下XML標記");
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btFormatAppXML
            // 
            this.btFormatAppXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFormatAppXML.Location = new System.Drawing.Point(1205, 12);
            this.btFormatAppXML.Name = "btFormatAppXML";
            this.btFormatAppXML.Size = new System.Drawing.Size(58, 35);
            this.btFormatAppXML.TabIndex = 7;
            this.btFormatAppXML.Text = "<...>";
            this.toolTip1.SetToolTip(this.btFormatAppXML, "格式化XML標記");
            this.btFormatAppXML.UseVisualStyleBackColor = true;
            this.btFormatAppXML.Click += new System.EventHandler(this.btFormatAppXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "參考版本";
            // 
            // tbRefVer
            // 
            this.tbRefVer.Location = new System.Drawing.Point(251, 15);
            this.tbRefVer.Name = "tbRefVer";
            this.tbRefVer.Size = new System.Drawing.Size(248, 31);
            this.tbRefVer.TabIndex = 4;
            // 
            // btCreateApp
            // 
            this.btCreateApp.Location = new System.Drawing.Point(12, 96);
            this.btCreateApp.Name = "btCreateApp";
            this.btCreateApp.Size = new System.Drawing.Size(105, 35);
            this.btCreateApp.TabIndex = 2;
            this.btCreateApp.Text = "產生校勘";
            this.btCreateApp.UseVisualStyleBackColor = true;
            this.btCreateApp.Click += new System.EventHandler(this.btCreateApp_Click);
            // 
            // tbApp
            // 
            this.tbApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApp.Location = new System.Drawing.Point(251, 55);
            this.tbApp.Multiline = true;
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(1013, 214);
            this.tbApp.TabIndex = 5;
            // 
            // btAnalysis
            // 
            this.btAnalysis.Location = new System.Drawing.Point(13, 55);
            this.btAnalysis.Name = "btAnalysis";
            this.btAnalysis.Size = new System.Drawing.Size(104, 35);
            this.btAnalysis.TabIndex = 1;
            this.btAnalysis.Text = "分析";
            this.btAnalysis.UseVisualStyleBackColor = true;
            this.btAnalysis.Click += new System.EventHandler(this.btAnalysis_Click);
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(13, 12);
            this.btPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(104, 35);
            this.btPaste.TabIndex = 0;
            this.btPaste.Text = "貼上";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // myDataGridView
            // 
            this.myDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView.Location = new System.Drawing.Point(0, 0);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowTemplate.Height = 27;
            this.myDataGridView.Size = new System.Drawing.Size(1276, 192);
            this.myDataGridView.TabIndex = 1;
            this.myDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myDataGridView_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "提出日期";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 92;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "提出者";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "修訂前";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "修訂後";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "修訂依據";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 92;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "修訂類型";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 92;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "討論與考證";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 111;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "修訂確認者";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 111;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "修訂執行者";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 111;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "修訂完成日期";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 130;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Green;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 192);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1276, 6);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 192);
            this.panel2.TabIndex = 3;
            // 
            // btClearRefVer
            // 
            this.btClearRefVer.Location = new System.Drawing.Point(213, 16);
            this.btClearRefVer.Name = "btClearRefVer";
            this.btClearRefVer.Size = new System.Drawing.Size(32, 30);
            this.btClearRefVer.TabIndex = 10;
            this.btClearRefVer.Text = "X";
            this.toolTip1.SetToolTip(this.btClearRefVer, "清除參考版本選擇文字");
            this.btClearRefVer.UseVisualStyleBackColor = true;
            this.btClearRefVer.Click += new System.EventHandler(this.btClearRefVer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "CBETA P5a XML App 校勘產生器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Button btPaste;
        private System.Windows.Forms.Button btAnalysis;
        private System.Windows.Forms.TextBox tbApp;
        private System.Windows.Forms.Button btCreateApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox tbRefVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFormatAppXML;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.ListBox lbRefVer;
        private System.Windows.Forms.Button btClearRefVer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

