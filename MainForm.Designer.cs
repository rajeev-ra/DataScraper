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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gb.SuspendLayout();
            this.tc.SuspendLayout();
            this.Home.SuspendLayout();
            this.liveMint.SuspendLayout();
            this.tbLiveMintSettings.SuspendLayout();
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
            this.tbLiveMintSettings.Controls.Add(this.tabPage2);
            this.tbLiveMintSettings.Location = new System.Drawing.Point(9, 7);
            this.tbLiveMintSettings.Name = "tbLiveMintSettings";
            this.tbLiveMintSettings.SelectedIndex = 0;
            this.tbLiveMintSettings.Size = new System.Drawing.Size(489, 341);
            this.tbLiveMintSettings.TabIndex = 0;
            // 
            // stockData
            // 
            this.stockData.Location = new System.Drawing.Point(4, 22);
            this.stockData.Name = "stockData";
            this.stockData.Padding = new System.Windows.Forms.Padding(3);
            this.stockData.Size = new System.Drawing.Size(481, 315);
            this.stockData.TabIndex = 0;
            this.stockData.Text = "Stock Data";
            this.stockData.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}

