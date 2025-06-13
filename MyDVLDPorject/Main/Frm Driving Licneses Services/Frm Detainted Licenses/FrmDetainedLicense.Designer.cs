namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Detainted_Licenses
{
    partial class FrmDetainedLicense
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
            this.components = new System.ComponentModel.Container();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.txtbxFineFees = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetainD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlLicenseInfoWithFilter1 = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(439, 829);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 25);
            this.llShowLicenseInfo.TabIndex = 191;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show Licenses Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(71, 829);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(213, 25);
            this.llShowLicenseHistory.TabIndex = 190;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(862, 820);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 43);
            this.btnIssueLicense.TabIndex = 189;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(416, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 41);
            this.label1.TabIndex = 192;
            this.label1.Text = "Detain License";
            // 
            // gpApplicationInfo
            // 
            this.gpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.gpApplicationInfo.Controls.Add(this.txtbxFineFees);
            this.gpApplicationInfo.Controls.Add(this.pictureBox8);
            this.gpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gpApplicationInfo.Controls.Add(this.label12);
            this.gpApplicationInfo.Controls.Add(this.lblLicenseID);
            this.gpApplicationInfo.Controls.Add(this.pictureBox2);
            this.gpApplicationInfo.Controls.Add(this.pictureBox1);
            this.gpApplicationInfo.Controls.Add(this.label2);
            this.gpApplicationInfo.Controls.Add(this.label3);
            this.gpApplicationInfo.Controls.Add(this.pictureBox3);
            this.gpApplicationInfo.Controls.Add(this.lblDetainDate);
            this.gpApplicationInfo.Controls.Add(this.pictureBox4);
            this.gpApplicationInfo.Controls.Add(this.label5);
            this.gpApplicationInfo.Controls.Add(this.lblDetainD);
            this.gpApplicationInfo.Controls.Add(this.label4);
            this.gpApplicationInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpApplicationInfo.Location = new System.Drawing.Point(74, 623);
            this.gpApplicationInfo.Name = "gpApplicationInfo";
            this.gpApplicationInfo.Size = new System.Drawing.Size(915, 181);
            this.gpApplicationInfo.TabIndex = 193;
            this.gpApplicationInfo.TabStop = false;
            this.gpApplicationInfo.Text = "Detain ApplicationInfo ";
            // 
            // txtbxFineFees
            // 
            this.txtbxFineFees.Location = new System.Drawing.Point(282, 112);
            this.txtbxFineFees.Multiline = true;
            this.txtbxFineFees.Name = "txtbxFineFees";
            this.txtbxFineFees.Size = new System.Drawing.Size(111, 28);
            this.txtbxFineFees.TabIndex = 196;
            this.txtbxFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFineFees_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MyDVLDPorject.Properties.Resources.LicenseView_400;
            this.pictureBox8.Location = new System.Drawing.Point(738, 45);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 195;
            this.pictureBox8.TabStop = false;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCreatedByUser.Location = new System.Drawing.Point(776, 77);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(58, 27);
            this.lblCreatedByUser.TabIndex = 194;
            this.lblCreatedByUser.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.Location = new System.Drawing.Point(534, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 27);
            this.label12.TabIndex = 193;
            this.label12.Text = " License ID:";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLicenseID.Location = new System.Drawing.Point(776, 45);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(58, 27);
            this.lblLicenseID.TabIndex = 191;
            this.lblLicenseID.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLDPorject.Properties.Resources.IssueDrivingLicense_32;
            this.pictureBox2.Location = new System.Drawing.Point(227, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLDPorject.Properties.Resources.User_32__2;
            this.pictureBox1.Location = new System.Drawing.Point(738, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(534, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 181;
            this.label2.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 177;
            this.label3.Text = "Fine Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyDVLDPorject.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(227, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 178;
            this.pictureBox3.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDetainDate.Location = new System.Drawing.Point(277, 80);
            this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(122, 27);
            this.lblDetainDate.TabIndex = 176;
            this.lblDetainDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyDVLDPorject.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(227, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 175;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 174;
            this.label5.Text = "Detain Date:";
            // 
            // lblDetainD
            // 
            this.lblDetainD.AutoSize = true;
            this.lblDetainD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDetainD.Location = new System.Drawing.Point(277, 48);
            this.lblDetainD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainD.Name = "lblDetainD";
            this.lblDetainD.Size = new System.Drawing.Size(58, 27);
            this.lblDetainD.TabIndex = 173;
            this.lblDetainD.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 172;
            this.label4.Text = "Detain ID:";
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 93);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1036, 535);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnlicenseFound += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlLicenseInfoWithFilter1_OnlicenseFound);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDetainedLicense
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1053, 903);
            this.Controls.Add(this.gpApplicationInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained Licenses";
            this.gpApplicationInfo.ResumeLayout(false);
            this.gpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.TextBox txtbxFineFees;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetainD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}