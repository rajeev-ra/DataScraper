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
            this.SuspendLayout();
            // 
            // cbLivemint
            // 
            this.cbLivemint.AutoSize = true;
            this.cbLivemint.Location = new System.Drawing.Point(14, 71);
            this.cbLivemint.Name = "cbLivemint";
            this.cbLivemint.Size = new System.Drawing.Size(66, 17);
            this.cbLivemint.TabIndex = 2;
            this.cbLivemint.Text = "LiveMint";
            this.cbLivemint.UseVisualStyleBackColor = true;
            // 
            // cbFinExp
            // 
            this.cbFinExp.AutoSize = true;
            this.cbFinExp.Location = new System.Drawing.Point(14, 98);
            this.cbFinExp.Name = "cbFinExp";
            this.cbFinExp.Size = new System.Drawing.Size(108, 17);
            this.cbFinExp.TabIndex = 3;
            this.cbFinExp.Text = "Financial Express";
            this.cbFinExp.UseVisualStyleBackColor = true;
            // 
            // cbHBL
            // 
            this.cbHBL.AutoSize = true;
            this.cbHBL.Location = new System.Drawing.Point(14, 124);
            this.cbHBL.Name = "cbHBL";
            this.cbHBL.Size = new System.Drawing.Size(122, 17);
            this.cbHBL.TabIndex = 4;
            this.cbHBL.Text = "Hindu Business Line";
            this.cbHBL.UseVisualStyleBackColor = true;
            // 
            // lblSava
            // 
            this.lblSava.AutoSize = true;
            this.lblSava.Location = new System.Drawing.Point(10, 13);
            this.lblSava.Name = "lblSava";
            this.lblSava.Size = new System.Drawing.Size(72, 13);
            this.lblSava.TabIndex = 6;
            this.lblSava.Text = "Save location";
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOut.Location = new System.Drawing.Point(12, 31);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(374, 20);
            this.txtOut.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(392, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btxExec
            // 
            this.btxExec.Location = new System.Drawing.Point(187, 154);
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
            this.txtLog.Location = new System.Drawing.Point(12, 218);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(455, 86);
            this.txtLog.TabIndex = 9;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(10, 202);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(25, 13);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 316);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btxExec);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.lblSava);
            this.Controls.Add(this.cbHBL);
            this.Controls.Add(this.cbFinExp);
            this.Controls.Add(this.cbLivemint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

