namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s
{
    partial class FrmReleaseLicense
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
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.ctrlLicesenDetainedInfo = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne.UserCtrls.CtrlApplicationInfoForLicesenReplacement();
            this.ctrlLicenseInfoWithFilter1 = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(440, 801);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 25);
            this.llShowLicenseInfo.TabIndex = 194;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show Licenses Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(74, 801);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(213, 25);
            this.llShowLicenseHistory.TabIndex = 193;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(863, 792);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 43);
            this.btnIssueLicense.TabIndex = 192;
            this.btnIssueLicense.Text = "Release";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // ctrlLicesenDetainedInfo
            // 
            this.ctrlLicesenDetainedInfo.Location = new System.Drawing.Point(60, 551);
            this.ctrlLicesenDetainedInfo.Name = "ctrlLicesenDetainedInfo";
            this.ctrlLicesenDetainedInfo.Size = new System.Drawing.Size(918, 235);
            this.ctrlLicesenDetainedInfo.TabIndex = 195;
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(1, 17);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1036, 528);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnlicenseFound += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlLicenseInfoWithFilter1_OnlicenseFound);
            // 
            // FrmReleaseLicense
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1039, 873);
            this.Controls.Add(this.ctrlLicesenDetainedInfo);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.automaticupdates;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReleaseLicense";
            this.Text = "Release License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnIssueLicense;
        private Frm_Replacement_Or_Lost_Driving_Licesne.UserCtrls.CtrlApplicationInfoForLicesenReplacement ctrlLicesenDetainedInfo;
    }
}