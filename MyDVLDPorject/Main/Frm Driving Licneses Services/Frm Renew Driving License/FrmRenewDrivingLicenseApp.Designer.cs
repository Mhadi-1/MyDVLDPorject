namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License
{
    partial class FrmRenewDrivingLicenseApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlRenewApplicationInfo1 = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls.CtrlRenewApplicationInfo();
            this.ctrlLicenseInfoWithFilter1 = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(347, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renew Driving License ";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(810, 901);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 43);
            this.btnIssueLicense.TabIndex = 181;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(428, 908);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 25);
            this.llShowLicenseInfo.TabIndex = 185;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show Licenses Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(66, 908);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(213, 25);
            this.llShowLicenseHistory.TabIndex = 184;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // ctrlRenewApplicationInfo1
            // 
            this.ctrlRenewApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlRenewApplicationInfo1.Location = new System.Drawing.Point(50, 589);
            this.ctrlRenewApplicationInfo1.Name = "ctrlRenewApplicationInfo1";
            this.ctrlRenewApplicationInfo1.Size = new System.Drawing.Size(896, 353);
            this.ctrlRenewApplicationInfo1.TabIndex = 1;
            this.ctrlRenewApplicationInfo1.OnLicenseRenew += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlRenewApplicationInfo1_OnLicenseRenew);
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(4, 57);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1024, 506);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnlicenseFound += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlLicenseInfoWithFilter1_OnlicenseFound);
            // 
            // FrmRenewDrivingLicenseApp
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 951);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlRenewApplicationInfo1);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.recurrence;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRenewDrivingLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew Driving License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserCtrls.CtrlRenewApplicationInfo ctrlRenewApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private UserCtrls.CtrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
    }
}