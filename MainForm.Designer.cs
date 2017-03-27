namespace DataScraper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbLivemint = new System.Windows.Forms.CheckBox();
            this.cbFinExp = new System.Windows.Forms.CheckBox();
            this.cbHBL = new System.Windows.Forms.CheckBox();
            this.lblSava = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btxExec = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cList = new System.Windows.Forms.CheckedListBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.liveMint = new System.Windows.Forms.TabPage();
            this.tbLiveMintSettings = new System.Windows.Forms.TabControl();
            this.stockData = new System.Windows.Forms.TabPage();
            this.liveMintBalanceSheet = new System.Windows.Forms.TabPage();
            this.cbExportStockData = new System.Windows.Forms.CheckBox();
            this.lblStockDataSelection = new System.Windows.Forms.Label();
            this.clbStockData = new System.Windows.Forms.CheckedListBox();
            this.lblStockDataAll = new System.Windows.Forms.Label();
            this.lblStockDataNone = new System.Windows.Forms.Label();
            this.lblSelectBalanceSheetNone = new System.Windows.Forms.Label();
            this.lblSelectBalanceSheetAll = new System.Windows.Forms.Label();
            this.clbLiveMintBalanceSheet = new System.Windows.Forms.CheckedListBox();
            this.lblSelectBalanceSheet = new System.Windows.Forms.Label();
            this.cbExportBalanceSheet = new System.Windows.Forms.CheckBox();
            this.tabLiveMintProfitLoss = new System.Windows.Forms.TabPage();
            this.tabLiveMintCashFlow = new System.Windows.Forms.TabPage();
            this.tabLiveMintQuaterly = new System.Windows.Forms.TabPage();
            this.lblLiveMintProfitLossNone = new System.Windows.Forms.Label();
            this.lblLiveMintProfitLossAll = new System.Windows.Forms.Label();
            this.clbLiveMintProfitLoss = new System.Windows.Forms.CheckedListBox();
            this.lblLiveMintProfitLoss = new System.Windows.Forms.Label();
            this.cbLiveMintProfitLoss = new System.Windows.Forms.CheckBox();
            this.lblLiveMintCashFlowNone = new System.Windows.Forms.Label();
            this.lblLiveMintCashFlowAll = new System.Windows.Forms.Label();
            this.clbLiveMintCashFlow = new System.Windows.Forms.CheckedListBox();
            this.lblLiveMintCashFlow = new System.Windows.Forms.Label();
            this.cbExportLiveMintCashFlow = new System.Windows.Forms.CheckBox();
            this.lblLiveMintExportQuaterlyNone = new System.Windows.Forms.Label();
            this.lblLiveMintExportQuaterlyAll = new System.Windows.Forms.Label();
            this.clbLiveMintExportQuaterly = new System.Windows.Forms.CheckedListBox();
            this.lblLiveMintExportQuaterly = new System.Windows.Forms.Label();
            this.cbLiveMintExportQuaterly = new System.Windows.Forms.CheckBox();
            this.gb.SuspendLayout();
            this.tc.SuspendLayout();
            this.Home.SuspendLayout();
            this.liveMint.SuspendLayout();
            this.tbLiveMintSettings.SuspendLayout();
            this.stockData.SuspendLayout();
            this.liveMintBalanceSheet.SuspendLayout();
            this.tabLiveMintProfitLoss.SuspendLayout();
            this.tabLiveMintCashFlow.SuspendLayout();
            this.tabLiveMintQuaterly.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLivemint
            // 
            this.cbLivemint.AutoSize = true;
            this.cbLivemint.Location = new System.Drawing.Point(6, 21);
            this.cbLivemint.Name = "cbLivemint";
            this.cbLivemint.Size = new System.Drawing.Size(66, 17);
            this.cbLivemint.TabIndex = 2;
            this.cbLivemint.Text = "LiveMint";
            this.cbLivemint.UseVisualStyleBackColor = true;
            // 
            // cbFinExp
            // 
            this.cbFinExp.AutoSize = true;
            this.cbFinExp.Location = new System.Drawing.Point(6, 53);
            this.cbFinExp.Name = "cbFinExp";
            this.cbFinExp.Size = new System.Drawing.Size(108, 17);
            this.cbFinExp.TabIndex = 3;
            this.cbFinExp.Text = "Financial Express";
            this.cbFinExp.UseVisualStyleBackColor = true;
            // 
            // cbHBL
            // 
            this.cbHBL.AutoSize = true;
            this.cbHBL.Location = new System.Drawing.Point(6, 86);
            this.cbHBL.Name = "cbHBL";
            this.cbHBL.Size = new System.Drawing.Size(122, 17);
            this.cbHBL.TabIndex = 4;
            this.cbHBL.Text = "Hindu Business Line";
            this.cbHBL.UseVisualStyleBackColor = true;
            // 
            // lblSava
            // 
            this.lblSava.AutoSize = true;
            this.lblSava.Location = new System.Drawing.Point(12, 12);
            this.lblSava.Name = "lblSava";
            this.lblSava.Size = new System.Drawing.Size(72, 13);
            this.lblSava.TabIndex = 6;
            this.lblSava.Text = "Save location";
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOut.Location = new System.Drawing.Point(14, 30);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(374, 20);
            this.txtOut.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(417, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btxExec
            // 
            this.btxExec.Location = new System.Drawing.Point(397, 146);
            this.btxExec.Name = "btxExec";
            this.btxExec.Size = new System.Drawing.Size(95, 37);
            this.btxExec.TabIndex = 5;
            this.btxExec.Text = "Execute";
            this.btxExec.UseVisualStyleBackColor = true;
            this.btxExec.Click += new System.EventHandler(this.btxExec_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(14, 217);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(478, 131);
            this.txtLog.TabIndex = 9;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 201);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(25, 13);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "Info";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cbLivemint);
            this.gb.Controls.Add(this.cbFinExp);
            this.gb.Controls.Add(this.cbHBL);
            this.gb.Location = new System.Drawing.Point(223, 59);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(165, 124);
            this.gb.TabIndex = 10;
            this.gb.TabStop = false;
            this.gb.Text = "DataSource";
            // 
            // cList
            // 
            this.cList.FormattingEnabled = true;
            this.cList.Location = new System.Drawing.Point(15, 74);
            this.cList.Name = "cList";
            this.cList.ScrollAlwaysVisible = true;
            this.cList.Size = new System.Drawing.Size(174, 109);
            this.cList.TabIndex = 11;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(12, 59);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(38, 13);
            this.lblCat.TabIndex = 12;
            this.lblCat.Text = "Target";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAll.Location = new System.Drawing.Point(135, 59);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(18, 13);
            this.lblAll.TabIndex = 13;
            this.lblAll.Text = "All";
            this.lblAll.Click += new System.EventHandler(this.lblAll_Click);
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNone.Location = new System.Drawing.Point(159, 59);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(33, 13);
            this.lblNone.TabIndex = 14;
            this.lblNone.Text = "None";
            this.lblNone.Click += new System.EventHandler(this.lblNone_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.Home);
            this.tc.Controls.Add(this.liveMint);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(516, 384);
            this.tc.TabIndex = 15;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.lblSava);
            this.Home.Controls.Add(this.lblNone);
            this.Home.Controls.Add(this.txtOut);
            this.Home.Controls.Add(this.lblAll);
            this.Home.Controls.Add(this.btnBrowse);
            this.Home.Controls.Add(this.lblCat);
            this.Home.Controls.Add(this.btxExec);
            this.Home.Controls.Add(this.cList);
            this.Home.Controls.Add(this.txtLog);
            this.Home.Controls.Add(this.gb);
            this.Home.Controls.Add(this.lblMsg);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(508, 358);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // liveMint
            // 
            this.liveMint.Controls.Add(this.tbLiveMintSettings);
            this.liveMint.Location = new System.Drawing.Point(4, 22);
            this.liveMint.Name = "liveMint";
            this.liveMint.Padding = new System.Windows.Forms.Padding(3);
            this.liveMint.Size = new System.Drawing.Size(508, 358);
            this.liveMint.TabIndex = 1;
            this.liveMint.Text = "LiveMint settings";
            this.liveMint.UseVisualStyleBackColor = true;
            // 
            // tbLiveMintSettings
            // 
            this.tbLiveMintSettings.Controls.Add(this.stockData);
            this.tbLiveMintSettings.Controls.Add(this.liveMintBalanceSheet);
            this.tbLiveMintSettings.Controls.Add(this.tabLiveMintProfitLoss);
            this.tbLiveMintSettings.Controls.Add(this.tabLiveMintCashFlow);
            this.tbLiveMintSettings.Controls.Add(this.tabLiveMintQuaterly);
            this.tbLiveMintSettings.Location = new System.Drawing.Point(9, 7);
            this.tbLiveMintSettings.Name = "tbLiveMintSettings";
            this.tbLiveMintSettings.SelectedIndex = 0;
            this.tbLiveMintSettings.Size = new System.Drawing.Size(489, 341);
            this.tbLiveMintSettings.TabIndex = 0;
            // 
            // stockData
            // 
            this.stockData.Controls.Add(this.lblStockDataNone);
            this.stockData.Controls.Add(this.lblStockDataAll);
            this.stockData.Controls.Add(this.clbStockData);
            this.stockData.Controls.Add(this.lblStockDataSelection);
            this.stockData.Controls.Add(this.cbExportStockData);
            this.stockData.Location = new System.Drawing.Point(4, 22);
            this.stockData.Name = "stockData";
            this.stockData.Padding = new System.Windows.Forms.Padding(3);
            this.stockData.Size = new System.Drawing.Size(481, 315);
            this.stockData.TabIndex = 0;
            this.stockData.Text = "Stock Data";
            this.stockData.UseVisualStyleBackColor = true;
            // 
            // liveMintBalanceSheet
            // 
            this.liveMintBalanceSheet.Controls.Add(this.lblSelectBalanceSheetNone);
            this.liveMintBalanceSheet.Controls.Add(this.lblSelectBalanceSheetAll);
            this.liveMintBalanceSheet.Controls.Add(this.clbLiveMintBalanceSheet);
            this.liveMintBalanceSheet.Controls.Add(this.lblSelectBalanceSheet);
            this.liveMintBalanceSheet.Controls.Add(this.cbExportBalanceSheet);
            this.liveMintBalanceSheet.Location = new System.Drawing.Point(4, 22);
            this.liveMintBalanceSheet.Name = "liveMintBalanceSheet";
            this.liveMintBalanceSheet.Padding = new System.Windows.Forms.Padding(3);
            this.liveMintBalanceSheet.Size = new System.Drawing.Size(481, 315);
            this.liveMintBalanceSheet.TabIndex = 1;
            this.liveMintBalanceSheet.Text = "Balance Sheet";
            this.liveMintBalanceSheet.UseVisualStyleBackColor = true;
            // 
            // cbExportStockData
            // 
            this.cbExportStockData.AutoSize = true;
            this.cbExportStockData.Checked = true;
            this.cbExportStockData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportStockData.Location = new System.Drawing.Point(7, 7);
            this.cbExportStockData.Name = "cbExportStockData";
            this.cbExportStockData.Size = new System.Drawing.Size(113, 17);
            this.cbExportStockData.TabIndex = 0;
            this.cbExportStockData.Text = "Export Stock Data";
            this.cbExportStockData.UseVisualStyleBackColor = true;
            this.cbExportStockData.CheckedChanged += new System.EventHandler(this.cbExportStockData_CheckedChanged);
            // 
            // lblStockDataSelection
            // 
            this.lblStockDataSelection.AutoSize = true;
            this.lblStockDataSelection.Location = new System.Drawing.Point(4, 31);
            this.lblStockDataSelection.Name = "lblStockDataSelection";
            this.lblStockDataSelection.Size = new System.Drawing.Size(63, 13);
            this.lblStockDataSelection.TabIndex = 1;
            this.lblStockDataSelection.Text = "Select Data";
            // 
            // clbStockData
            // 
            this.clbStockData.FormattingEnabled = true;
            this.clbStockData.Location = new System.Drawing.Point(4, 48);
            this.clbStockData.Name = "clbStockData";
            this.clbStockData.Size = new System.Drawing.Size(205, 259);
            this.clbStockData.TabIndex = 2;
            // 
            // lblStockDataAll
            // 
            this.lblStockDataAll.AutoSize = true;
            this.lblStockDataAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStockDataAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStockDataAll.Location = new System.Drawing.Point(152, 32);
            this.lblStockDataAll.Name = "lblStockDataAll";
            this.lblStockDataAll.Size = new System.Drawing.Size(18, 13);
            this.lblStockDataAll.TabIndex = 3;
            this.lblStockDataAll.Text = "All";
            this.lblStockDataAll.Click += new System.EventHandler(this.lblStockDataAll_Click);
            // 
            // lblStockDataNone
            // 
            this.lblStockDataNone.AutoSize = true;
            this.lblStockDataNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStockDataNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStockDataNone.Location = new System.Drawing.Point(176, 32);
            this.lblStockDataNone.Name = "lblStockDataNone";
            this.lblStockDataNone.Size = new System.Drawing.Size(33, 13);
            this.lblStockDataNone.TabIndex = 4;
            this.lblStockDataNone.Text = "None";
            this.lblStockDataNone.Click += new System.EventHandler(this.lblStockDataNone_Click);
            // 
            // lblSelectBalanceSheetNone
            // 
            this.lblSelectBalanceSheetNone.AutoSize = true;
            this.lblSelectBalanceSheetNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectBalanceSheetNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectBalanceSheetNone.Location = new System.Drawing.Point(176, 32);
            this.lblSelectBalanceSheetNone.Name = "lblSelectBalanceSheetNone";
            this.lblSelectBalanceSheetNone.Size = new System.Drawing.Size(33, 13);
            this.lblSelectBalanceSheetNone.TabIndex = 9;
            this.lblSelectBalanceSheetNone.Text = "None";
            this.lblSelectBalanceSheetNone.Click += new System.EventHandler(this.lblSelectBalanceSheetNone_Click);
            // 
            // lblSelectBalanceSheetAll
            // 
            this.lblSelectBalanceSheetAll.AutoSize = true;
            this.lblSelectBalanceSheetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectBalanceSheetAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectBalanceSheetAll.Location = new System.Drawing.Point(152, 32);
            this.lblSelectBalanceSheetAll.Name = "lblSelectBalanceSheetAll";
            this.lblSelectBalanceSheetAll.Size = new System.Drawing.Size(18, 13);
            this.lblSelectBalanceSheetAll.TabIndex = 8;
            this.lblSelectBalanceSheetAll.Text = "All";
            this.lblSelectBalanceSheetAll.Click += new System.EventHandler(this.lblSelectBalanceSheetAll_Click);
            // 
            // clbLiveMintBalanceSheet
            // 
            this.clbLiveMintBalanceSheet.FormattingEnabled = true;
            this.clbLiveMintBalanceSheet.Location = new System.Drawing.Point(4, 48);
            this.clbLiveMintBalanceSheet.Name = "clbLiveMintBalanceSheet";
            this.clbLiveMintBalanceSheet.Size = new System.Drawing.Size(205, 259);
            this.clbLiveMintBalanceSheet.TabIndex = 7;
            // 
            // lblSelectBalanceSheet
            // 
            this.lblSelectBalanceSheet.AutoSize = true;
            this.lblSelectBalanceSheet.Location = new System.Drawing.Point(4, 31);
            this.lblSelectBalanceSheet.Name = "lblSelectBalanceSheet";
            this.lblSelectBalanceSheet.Size = new System.Drawing.Size(63, 13);
            this.lblSelectBalanceSheet.TabIndex = 6;
            this.lblSelectBalanceSheet.Text = "Select Data";
            // 
            // cbExportBalanceSheet
            // 
            this.cbExportBalanceSheet.AutoSize = true;
            this.cbExportBalanceSheet.Checked = true;
            this.cbExportBalanceSheet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportBalanceSheet.Location = new System.Drawing.Point(7, 7);
            this.cbExportBalanceSheet.Name = "cbExportBalanceSheet";
            this.cbExportBalanceSheet.Size = new System.Drawing.Size(129, 17);
            this.cbExportBalanceSheet.TabIndex = 5;
            this.cbExportBalanceSheet.Text = "Export Balance Sheet";
            this.cbExportBalanceSheet.UseVisualStyleBackColor = true;
            this.cbExportBalanceSheet.CheckedChanged += new System.EventHandler(this.cbExportBalanceSheet_CheckedChanged);
            // 
            // tabLiveMintProfitLoss
            // 
            this.tabLiveMintProfitLoss.Controls.Add(this.lblLiveMintProfitLossNone);
            this.tabLiveMintProfitLoss.Controls.Add(this.lblLiveMintProfitLossAll);
            this.tabLiveMintProfitLoss.Controls.Add(this.clbLiveMintProfitLoss);
            this.tabLiveMintProfitLoss.Controls.Add(this.lblLiveMintProfitLoss);
            this.tabLiveMintProfitLoss.Controls.Add(this.cbLiveMintProfitLoss);
            this.tabLiveMintProfitLoss.Location = new System.Drawing.Point(4, 22);
            this.tabLiveMintProfitLoss.Name = "tabLiveMintProfitLoss";
            this.tabLiveMintProfitLoss.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveMintProfitLoss.Size = new System.Drawing.Size(481, 315);
            this.tabLiveMintProfitLoss.TabIndex = 2;
            this.tabLiveMintProfitLoss.Text = "Profit / Loss";
            this.tabLiveMintProfitLoss.UseVisualStyleBackColor = true;
            // 
            // tabLiveMintCashFlow
            // 
            this.tabLiveMintCashFlow.Controls.Add(this.lblLiveMintCashFlowNone);
            this.tabLiveMintCashFlow.Controls.Add(this.lblLiveMintCashFlowAll);
            this.tabLiveMintCashFlow.Controls.Add(this.clbLiveMintCashFlow);
            this.tabLiveMintCashFlow.Controls.Add(this.lblLiveMintCashFlow);
            this.tabLiveMintCashFlow.Controls.Add(this.cbExportLiveMintCashFlow);
            this.tabLiveMintCashFlow.Location = new System.Drawing.Point(4, 22);
            this.tabLiveMintCashFlow.Name = "tabLiveMintCashFlow";
            this.tabLiveMintCashFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveMintCashFlow.Size = new System.Drawing.Size(481, 315);
            this.tabLiveMintCashFlow.TabIndex = 3;
            this.tabLiveMintCashFlow.Text = "Cash Flow";
            this.tabLiveMintCashFlow.UseVisualStyleBackColor = true;
            // 
            // tabLiveMintQuaterly
            // 
            this.tabLiveMintQuaterly.Controls.Add(this.lblLiveMintExportQuaterlyNone);
            this.tabLiveMintQuaterly.Controls.Add(this.lblLiveMintExportQuaterlyAll);
            this.tabLiveMintQuaterly.Controls.Add(this.clbLiveMintExportQuaterly);
            this.tabLiveMintQuaterly.Controls.Add(this.lblLiveMintExportQuaterly);
            this.tabLiveMintQuaterly.Controls.Add(this.cbLiveMintExportQuaterly);
            this.tabLiveMintQuaterly.Location = new System.Drawing.Point(4, 22);
            this.tabLiveMintQuaterly.Name = "tabLiveMintQuaterly";
            this.tabLiveMintQuaterly.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveMintQuaterly.Size = new System.Drawing.Size(481, 315);
            this.tabLiveMintQuaterly.TabIndex = 4;
            this.tabLiveMintQuaterly.Text = "Quaterly";
            this.tabLiveMintQuaterly.UseVisualStyleBackColor = true;
            // 
            // lblLiveMintProfitLossNone
            // 
            this.lblLiveMintProfitLossNone.AutoSize = true;
            this.lblLiveMintProfitLossNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintProfitLossNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintProfitLossNone.Location = new System.Drawing.Point(176, 32);
            this.lblLiveMintProfitLossNone.Name = "lblLiveMintProfitLossNone";
            this.lblLiveMintProfitLossNone.Size = new System.Drawing.Size(33, 13);
            this.lblLiveMintProfitLossNone.TabIndex = 14;
            this.lblLiveMintProfitLossNone.Text = "None";
            this.lblLiveMintProfitLossNone.Click += new System.EventHandler(this.lblLiveMintProfitLossNone_Click);
            // 
            // lblLiveMintProfitLossAll
            // 
            this.lblLiveMintProfitLossAll.AutoSize = true;
            this.lblLiveMintProfitLossAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintProfitLossAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintProfitLossAll.Location = new System.Drawing.Point(152, 32);
            this.lblLiveMintProfitLossAll.Name = "lblLiveMintProfitLossAll";
            this.lblLiveMintProfitLossAll.Size = new System.Drawing.Size(18, 13);
            this.lblLiveMintProfitLossAll.TabIndex = 13;
            this.lblLiveMintProfitLossAll.Text = "All";
            this.lblLiveMintProfitLossAll.Click += new System.EventHandler(this.lblLiveMintProfitLossAll_Click);
            // 
            // clbLiveMintProfitLoss
            // 
            this.clbLiveMintProfitLoss.FormattingEnabled = true;
            this.clbLiveMintProfitLoss.Location = new System.Drawing.Point(4, 48);
            this.clbLiveMintProfitLoss.Name = "clbLiveMintProfitLoss";
            this.clbLiveMintProfitLoss.Size = new System.Drawing.Size(205, 259);
            this.clbLiveMintProfitLoss.TabIndex = 12;
            // 
            // lblLiveMintProfitLoss
            // 
            this.lblLiveMintProfitLoss.AutoSize = true;
            this.lblLiveMintProfitLoss.Location = new System.Drawing.Point(4, 31);
            this.lblLiveMintProfitLoss.Name = "lblLiveMintProfitLoss";
            this.lblLiveMintProfitLoss.Size = new System.Drawing.Size(63, 13);
            this.lblLiveMintProfitLoss.TabIndex = 11;
            this.lblLiveMintProfitLoss.Text = "Select Data";
            // 
            // cbLiveMintProfitLoss
            // 
            this.cbLiveMintProfitLoss.AutoSize = true;
            this.cbLiveMintProfitLoss.Checked = true;
            this.cbLiveMintProfitLoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLiveMintProfitLoss.Location = new System.Drawing.Point(7, 7);
            this.cbLiveMintProfitLoss.Name = "cbLiveMintProfitLoss";
            this.cbLiveMintProfitLoss.Size = new System.Drawing.Size(116, 17);
            this.cbLiveMintProfitLoss.TabIndex = 10;
            this.cbLiveMintProfitLoss.Text = "Export Profit / Loss";
            this.cbLiveMintProfitLoss.UseVisualStyleBackColor = true;
            this.cbLiveMintProfitLoss.CheckedChanged += new System.EventHandler(this.cbLiveMintProfitLoss_CheckedChanged);
            // 
            // lblLiveMintCashFlowNone
            // 
            this.lblLiveMintCashFlowNone.AutoSize = true;
            this.lblLiveMintCashFlowNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintCashFlowNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintCashFlowNone.Location = new System.Drawing.Point(176, 32);
            this.lblLiveMintCashFlowNone.Name = "lblLiveMintCashFlowNone";
            this.lblLiveMintCashFlowNone.Size = new System.Drawing.Size(33, 13);
            this.lblLiveMintCashFlowNone.TabIndex = 14;
            this.lblLiveMintCashFlowNone.Text = "None";
            this.lblLiveMintCashFlowNone.Click += new System.EventHandler(this.lblLiveMintCashFlowNone_Click);
            // 
            // lblLiveMintCashFlowAll
            // 
            this.lblLiveMintCashFlowAll.AutoSize = true;
            this.lblLiveMintCashFlowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintCashFlowAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintCashFlowAll.Location = new System.Drawing.Point(152, 32);
            this.lblLiveMintCashFlowAll.Name = "lblLiveMintCashFlowAll";
            this.lblLiveMintCashFlowAll.Size = new System.Drawing.Size(18, 13);
            this.lblLiveMintCashFlowAll.TabIndex = 13;
            this.lblLiveMintCashFlowAll.Text = "All";
            this.lblLiveMintCashFlowAll.Click += new System.EventHandler(this.lblLiveMintCashFlowAll_Click);
            // 
            // clbLiveMintCashFlow
            // 
            this.clbLiveMintCashFlow.FormattingEnabled = true;
            this.clbLiveMintCashFlow.Location = new System.Drawing.Point(4, 48);
            this.clbLiveMintCashFlow.Name = "clbLiveMintCashFlow";
            this.clbLiveMintCashFlow.Size = new System.Drawing.Size(205, 259);
            this.clbLiveMintCashFlow.TabIndex = 12;
            // 
            // lblLiveMintCashFlow
            // 
            this.lblLiveMintCashFlow.AutoSize = true;
            this.lblLiveMintCashFlow.Location = new System.Drawing.Point(4, 31);
            this.lblLiveMintCashFlow.Name = "lblLiveMintCashFlow";
            this.lblLiveMintCashFlow.Size = new System.Drawing.Size(63, 13);
            this.lblLiveMintCashFlow.TabIndex = 11;
            this.lblLiveMintCashFlow.Text = "Select Data";
            // 
            // cbExportLiveMintCashFlow
            // 
            this.cbExportLiveMintCashFlow.AutoSize = true;
            this.cbExportLiveMintCashFlow.Checked = true;
            this.cbExportLiveMintCashFlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportLiveMintCashFlow.Location = new System.Drawing.Point(7, 7);
            this.cbExportLiveMintCashFlow.Name = "cbExportLiveMintCashFlow";
            this.cbExportLiveMintCashFlow.Size = new System.Drawing.Size(108, 17);
            this.cbExportLiveMintCashFlow.TabIndex = 10;
            this.cbExportLiveMintCashFlow.Text = "Export Cash Flow";
            this.cbExportLiveMintCashFlow.UseVisualStyleBackColor = true;
            this.cbExportLiveMintCashFlow.CheckedChanged += new System.EventHandler(this.cbExportLiveMintCashFlow_CheckedChanged);
            // 
            // lblLiveMintExportQuaterlyNone
            // 
            this.lblLiveMintExportQuaterlyNone.AutoSize = true;
            this.lblLiveMintExportQuaterlyNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintExportQuaterlyNone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintExportQuaterlyNone.Location = new System.Drawing.Point(176, 32);
            this.lblLiveMintExportQuaterlyNone.Name = "lblLiveMintExportQuaterlyNone";
            this.lblLiveMintExportQuaterlyNone.Size = new System.Drawing.Size(33, 13);
            this.lblLiveMintExportQuaterlyNone.TabIndex = 14;
            this.lblLiveMintExportQuaterlyNone.Text = "None";
            this.lblLiveMintExportQuaterlyNone.Click += new System.EventHandler(this.lblLiveMintExportQuaterlyNone_Click);
            // 
            // lblLiveMintExportQuaterlyAll
            // 
            this.lblLiveMintExportQuaterlyAll.AutoSize = true;
            this.lblLiveMintExportQuaterlyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveMintExportQuaterlyAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiveMintExportQuaterlyAll.Location = new System.Drawing.Point(152, 32);
            this.lblLiveMintExportQuaterlyAll.Name = "lblLiveMintExportQuaterlyAll";
            this.lblLiveMintExportQuaterlyAll.Size = new System.Drawing.Size(18, 13);
            this.lblLiveMintExportQuaterlyAll.TabIndex = 13;
            this.lblLiveMintExportQuaterlyAll.Text = "All";
            this.lblLiveMintExportQuaterlyAll.Click += new System.EventHandler(this.lblLiveMintExportQuaterlyAll_Click);
            // 
            // clbLiveMintExportQuaterly
            // 
            this.clbLiveMintExportQuaterly.FormattingEnabled = true;
            this.clbLiveMintExportQuaterly.Location = new System.Drawing.Point(4, 48);
            this.clbLiveMintExportQuaterly.Name = "clbLiveMintExportQuaterly";
            this.clbLiveMintExportQuaterly.Size = new System.Drawing.Size(205, 259);
            this.clbLiveMintExportQuaterly.TabIndex = 12;
            // 
            // lblLiveMintExportQuaterly
            // 
            this.lblLiveMintExportQuaterly.AutoSize = true;
            this.lblLiveMintExportQuaterly.Location = new System.Drawing.Point(4, 31);
            this.lblLiveMintExportQuaterly.Name = "lblLiveMintExportQuaterly";
            this.lblLiveMintExportQuaterly.Size = new System.Drawing.Size(63, 13);
            this.lblLiveMintExportQuaterly.TabIndex = 11;
            this.lblLiveMintExportQuaterly.Text = "Select Data";
            // 
            // cbLiveMintExportQuaterly
            // 
            this.cbLiveMintExportQuaterly.AutoSize = true;
            this.cbLiveMintExportQuaterly.Checked = true;
            this.cbLiveMintExportQuaterly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLiveMintExportQuaterly.Location = new System.Drawing.Point(7, 7);
            this.cbLiveMintExportQuaterly.Name = "cbLiveMintExportQuaterly";
            this.cbLiveMintExportQuaterly.Size = new System.Drawing.Size(124, 17);
            this.cbLiveMintExportQuaterly.TabIndex = 10;
            this.cbLiveMintExportQuaterly.Text = "Export Quaterly Data";
            this.cbLiveMintExportQuaterly.UseVisualStyleBackColor = true;
            this.cbLiveMintExportQuaterly.CheckedChanged += new System.EventHandler(this.cbLiveMintExportQuaterly_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Scraper";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.tc.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.liveMint.ResumeLayout(false);
            this.tbLiveMintSettings.ResumeLayout(false);
            this.stockData.ResumeLayout(false);
            this.stockData.PerformLayout();
            this.liveMintBalanceSheet.ResumeLayout(false);
            this.liveMintBalanceSheet.PerformLayout();
            this.tabLiveMintProfitLoss.ResumeLayout(false);
            this.tabLiveMintProfitLoss.PerformLayout();
            this.tabLiveMintCashFlow.ResumeLayout(false);
            this.tabLiveMintCashFlow.PerformLayout();
            this.tabLiveMintQuaterly.ResumeLayout(false);
            this.tabLiveMintQuaterly.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLivemint;
        private System.Windows.Forms.CheckBox cbFinExp;
        private System.Windows.Forms.CheckBox cbHBL;
        private System.Windows.Forms.Label lblSava;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btxExec;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckedListBox cList;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblNone;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage liveMint;
        private System.Windows.Forms.TabControl tbLiveMintSettings;
        private System.Windows.Forms.TabPage stockData;
        private System.Windows.Forms.TabPage liveMintBalanceSheet;
        private System.Windows.Forms.CheckedListBox clbStockData;
        private System.Windows.Forms.Label lblStockDataSelection;
        private System.Windows.Forms.CheckBox cbExportStockData;
        private System.Windows.Forms.Label lblStockDataNone;
        private System.Windows.Forms.Label lblStockDataAll;
        private System.Windows.Forms.Label lblSelectBalanceSheetNone;
        private System.Windows.Forms.Label lblSelectBalanceSheetAll;
        private System.Windows.Forms.CheckedListBox clbLiveMintBalanceSheet;
        private System.Windows.Forms.Label lblSelectBalanceSheet;
        private System.Windows.Forms.CheckBox cbExportBalanceSheet;
        private System.Windows.Forms.TabPage tabLiveMintProfitLoss;
        private System.Windows.Forms.TabPage tabLiveMintCashFlow;
        private System.Windows.Forms.TabPage tabLiveMintQuaterly;
        private System.Windows.Forms.Label lblLiveMintProfitLossNone;
        private System.Windows.Forms.Label lblLiveMintProfitLossAll;
        private System.Windows.Forms.CheckedListBox clbLiveMintProfitLoss;
        private System.Windows.Forms.Label lblLiveMintProfitLoss;
        private System.Windows.Forms.CheckBox cbLiveMintProfitLoss;
        private System.Windows.Forms.Label lblLiveMintCashFlowNone;
        private System.Windows.Forms.Label lblLiveMintCashFlowAll;
        private System.Windows.Forms.CheckedListBox clbLiveMintCashFlow;
        private System.Windows.Forms.Label lblLiveMintCashFlow;
        private System.Windows.Forms.CheckBox cbExportLiveMintCashFlow;
        private System.Windows.Forms.Label lblLiveMintExportQuaterlyNone;
        private System.Windows.Forms.Label lblLiveMintExportQuaterlyAll;
        private System.Windows.Forms.CheckedListBox clbLiveMintExportQuaterly;
        private System.Windows.Forms.Label lblLiveMintExportQuaterly;
        private System.Windows.Forms.CheckBox cbLiveMintExportQuaterly;
    }
}

