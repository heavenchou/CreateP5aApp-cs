
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btClearRefVer = new System.Windows.Forms.Button();
            this.btFormatAppXML = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbRefVer = new System.Windows.Forms.TextBox();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbRefVer = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btPaste = new System.Windows.Forms.Button();
            this.btCreateApp = new System.Windows.Forms.Button();
            this.btAnalysis = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClearRefVer
            // 
            this.btClearRefVer.Location = new System.Drawing.Point(95, 9);
            this.btClearRefVer.Name = "btClearRefVer";
            this.btClearRefVer.Size = new System.Drawing.Size(32, 31);
            this.btClearRefVer.TabIndex = 10;
            this.btClearRefVer.Text = "X";
            this.toolTip1.SetToolTip(this.btClearRefVer, "清除參考版本選擇文字");
            this.btClearRefVer.UseVisualStyleBackColor = true;
            this.btClearRefVer.Click += new System.EventHandler(this.btClearRefVer_Click);
            // 
            // btFormatAppXML
            // 
            this.btFormatAppXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFormatAppXML.Location = new System.Drawing.Point(6, 41);
            this.btFormatAppXML.Name = "btFormatAppXML";
            this.btFormatAppXML.Size = new System.Drawing.Size(66, 35);
            this.btFormatAppXML.TabIndex = 7;
            this.btFormatAppXML.Text = "<...>";
            this.toolTip1.SetToolTip(this.btFormatAppXML, "格式化XML標記");
            this.btFormatAppXML.UseVisualStyleBackColor = true;
            this.btFormatAppXML.Click += new System.EventHandler(this.btFormatAppXML_Click);
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopy.Location = new System.Drawing.Point(6, 0);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(66, 35);
            this.btCopy.TabIndex = 6;
            this.btCopy.Text = "複製";
            this.toolTip1.SetToolTip(this.btCopy, "複製底下XML標記");
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::CreateP5aApp.Properties.Settings.Default, "SplitterLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.myDataGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel5);
            this.splitContainer.Size = new System.Drawing.Size(1070, 479);
            this.splitContainer.SplitterDistance = global::CreateP5aApp.Properties.Settings.Default.SplitterLocation;
            this.splitContainer.TabIndex = 4;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView.Location = new System.Drawing.Point(0, 0);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowTemplate.Height = 27;
            this.myDataGridView.Size = new System.Drawing.Size(1070, 200);
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
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column3.HeaderText = "修訂前";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panelMid);
            this.panel5.Controls.Add(this.panelLeft);
            this.panel5.Controls.Add(this.panelBottom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1070, 275);
            this.panel5.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbApp);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(265, 47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(805, 216);
            this.panel8.TabIndex = 16;
            // 
            // tbApp
            // 
            this.tbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApp.Location = new System.Drawing.Point(0, 0);
            this.tbApp.Margin = new System.Windows.Forms.Padding(20);
            this.tbApp.Multiline = true;
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(728, 216);
            this.tbApp.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btFormatAppXML);
            this.panel2.Controls.Add(this.btCopy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(728, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 216);
            this.panel2.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbRefVer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(265, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(805, 47);
            this.panel6.TabIndex = 15;
            // 
            // tbRefVer
            // 
            this.tbRefVer.Location = new System.Drawing.Point(0, 8);
            this.tbRefVer.Name = "tbRefVer";
            this.tbRefVer.Size = new System.Drawing.Size(248, 31);
            this.tbRefVer.TabIndex = 4;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.panel7);
            this.panelMid.Controls.Add(this.panel4);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMid.Location = new System.Drawing.Point(113, 0);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(152, 263);
            this.panelMid.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbRefVer);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 216);
            this.panel7.TabIndex = 15;
            // 
            // lbRefVer
            // 
            this.lbRefVer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRefVer.FormattingEnabled = true;
            this.lbRefVer.ItemHeight = 23;
            this.lbRefVer.Location = new System.Drawing.Point(0, 0);
            this.lbRefVer.Margin = new System.Windows.Forms.Padding(20);
            this.lbRefVer.Name = "lbRefVer";
            this.lbRefVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRefVer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRefVer.Size = new System.Drawing.Size(143, 216);
            this.lbRefVer.TabIndex = 3;
            this.lbRefVer.Click += new System.EventHandler(this.lbRefVer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btClearRefVer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 47);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "參考版本";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btPaste);
            this.panelLeft.Controls.Add(this.btCreateApp);
            this.panelLeft.Controls.Add(this.btAnalysis);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(113, 263);
            this.panelLeft.TabIndex = 11;
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(4, 5);
            this.btPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(104, 35);
            this.btPaste.TabIndex = 0;
            this.btPaste.Text = "貼上";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // btCreateApp
            // 
            this.btCreateApp.Location = new System.Drawing.Point(4, 89);
            this.btCreateApp.Name = "btCreateApp";
            this.btCreateApp.Size = new System.Drawing.Size(104, 35);
            this.btCreateApp.TabIndex = 2;
            this.btCreateApp.Text = "產生校勘";
            this.btCreateApp.UseVisualStyleBackColor = true;
            this.btCreateApp.Click += new System.EventHandler(this.btCreateApp_Click);
            // 
            // btAnalysis
            // 
            this.btAnalysis.Location = new System.Drawing.Point(4, 48);
            this.btAnalysis.Name = "btAnalysis";
            this.btAnalysis.Size = new System.Drawing.Size(104, 35);
            this.btAnalysis.TabIndex = 1;
            this.btAnalysis.Text = "分析";
            this.btAnalysis.UseVisualStyleBackColor = true;
            this.btAnalysis.Click += new System.EventHandler(this.btAnalysis_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 263);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1070, 12);
            this.panelBottom.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 479);
            this.Controls.Add(this.splitContainer);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::CreateP5aApp.Properties.Settings.Default, "FormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Location = global::CreateP5aApp.Properties.Settings.Default.FormLocation;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "CBETA P5a XML App 校勘產生器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelMid.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btFormatAppXML;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.ListBox lbRefVer;
        private System.Windows.Forms.Button btClearRefVer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelBottom;
    }
}

