namespace MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License
{
    partial class FrmIssueInternationalDrivingLicenes
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlDrivingLiceseInfoWithFilter1 = new MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License.UserCtrls.CtrlDrivingLiceseInfoWithFilter();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(96, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(875, 54);
            this.lblTitle.TabIndex = 124;
            this.lblTitle.Text = "International License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(928, 850);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 43);
            this.btnIssueLicense.TabIndex = 180;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(439, 827);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 25);
            this.llShowLicenseInfo.TabIndex = 183;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show Licenses Info";
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(90, 827);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(213, 25);
            this.llShowLicenseHistory.TabIndex = 182;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // ctrlDrivingLiceseInfoWithFilter1
            // 
            this.ctrlDrivingLiceseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDrivingLiceseInfoWithFilter1.Location = new System.Drawing.Point(4, 85);
            this.ctrlDrivingLiceseInfoWithFilter1.Name = "ctrlDrivingLiceseInfoWithFilter1";
            this.ctrlDrivingLiceseInfoWithFilter1.Size = new System.Drawing.Size(1054, 825);
            this.ctrlDrivingLiceseInfoWithFilter1.TabIndex = 0;
            this.ctrlDrivingLiceseInfoWithFilter1.OnLicenseFound += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlDrivingLiceseInfoWithFilter1_OnLicenseFound);
            // 
            // FrmIssueInternationalDrivingLicenes
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1064, 914);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDrivingLiceseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.bo_localization;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIssueInternationalDrivingLicenes";
            this.Text = "Issue International Driving Licenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserCtrls.CtrlDrivingLiceseInfoWithFilter ctrlDrivingLiceseInfoWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
    }
}