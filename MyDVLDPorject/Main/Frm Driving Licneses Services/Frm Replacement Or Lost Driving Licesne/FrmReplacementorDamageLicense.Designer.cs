namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne
{
    partial class FrmReplacementorDamageLicense
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
            this.rdoDamagelicense = new System.Windows.Forms.RadioButton();
            this.rdoLostLicense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblReplacementLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlLicenseInfoWithFilter1 = new MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter();
            this.gpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(443, 809);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 25);
            this.llShowLicenseInfo.TabIndex = 188;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show Licenses Info";
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(75, 809);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(213, 25);
            this.llShowLicenseHistory.TabIndex = 187;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(867, 800);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 43);
            this.btnIssueLicense.TabIndex = 186;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // rdoDamagelicense
            // 
            this.rdoDamagelicense.AutoSize = true;
            this.rdoDamagelicense.Checked = true;
            this.rdoDamagelicense.Enabled = false;
            this.rdoDamagelicense.Location = new System.Drawing.Point(890, 93);
            this.rdoDamagelicense.Name = "rdoDamagelicense";
            this.rdoDamagelicense.Size = new System.Drawing.Size(148, 23);
            this.rdoDamagelicense.TabIndex = 189;
            this.rdoDamagelicense.TabStop = true;
            this.rdoDamagelicense.Tag = "Damage";
            this.rdoDamagelicense.Text = "Damage License";
            this.rdoDamagelicense.UseVisualStyleBackColor = true;
            this.rdoDamagelicense.CheckedChanged += new System.EventHandler(this.rdolicense_CheckedChanged);
            // 
            // rdoLostLicense
            // 
            this.rdoLostLicense.AutoSize = true;
            this.rdoLostLicense.Enabled = false;
            this.rdoLostLicense.Location = new System.Drawing.Point(890, 131);
            this.rdoLostLicense.Name = "rdoLostLicense";
            this.rdoLostLicense.Size = new System.Drawing.Size(119, 23);
            this.rdoLostLicense.TabIndex = 190;
            this.rdoLostLicense.Tag = "Lost";
            this.rdoLostLicense.Text = "Lost License";
            this.rdoLostLicense.UseVisualStyleBackColor = true;
            this.rdoLostLicense.CheckedChanged += new System.EventHandler(this.rdolicense_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 33);
            this.label1.TabIndex = 191;
            this.label1.Text = "Replacement For Damage License";
            // 
            // gpApplicationInfo
            // 
            this.gpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.gpApplicationInfo.Controls.Add(this.pictureBox8);
            this.gpApplicationInfo.Controls.Add(this.lblOldLicenseID);
            this.gpApplicationInfo.Controls.Add(this.label12);
            this.gpApplicationInfo.Controls.Add(this.pictureBox7);
            this.gpApplicationInfo.Controls.Add(this.lblReplacementLicenseID);
            this.gpApplicationInfo.Controls.Add(this.label10);
            this.gpApplicationInfo.Controls.Add(this.pictureBox2);
            this.gpApplicationInfo.Controls.Add(this.pictureBox1);
            this.gpApplicationInfo.Controls.Add(this.label2);
            this.gpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.gpApplicationInfo.Controls.Add(this.label3);
            this.gpApplicationInfo.Controls.Add(this.pictureBox3);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gpApplicationInfo.Controls.Add(this.pictureBox4);
            this.gpApplicationInfo.Controls.Add(this.label5);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationID);
            this.gpApplicationInfo.Controls.Add(this.label4);
            this.gpApplicationInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpApplicationInfo.Location = new System.Drawing.Point(76, 610);
            this.gpApplicationInfo.Name = "gpApplicationInfo";
            this.gpApplicationInfo.Size = new System.Drawing.Size(915, 180);
            this.gpApplicationInfo.TabIndex = 192;
            this.gpApplicationInfo.TabStop = false;
            this.gpApplicationInfo.Text = "Replacement or Damage ApplicationInfo ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MyDVLDPorject.Properties.Resources.LicenseView_400;
            this.pictureBox8.Location = new System.Drawing.Point(695, 80);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 195;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblOldLicenseID.Location = new System.Drawing.Point(742, 77);
            this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(58, 27);
            this.lblOldLicenseID.TabIndex = 194;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.Location = new System.Drawing.Point(431, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 27);
            this.label12.TabIndex = 193;
            this.label12.Text = "Old License ID:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MyDVLDPorject.Properties.Resources.Driver_License_32;
            this.pictureBox7.Location = new System.Drawing.Point(695, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 192;
            this.pictureBox7.TabStop = false;
            // 
            // lblReplacementLicenseID
            // 
            this.lblReplacementLicenseID.AutoSize = true;
            this.lblReplacementLicenseID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblReplacementLicenseID.Location = new System.Drawing.Point(742, 45);
            this.lblReplacementLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplacementLicenseID.Name = "lblReplacementLicenseID";
            this.lblReplacementLicenseID.Size = new System.Drawing.Size(58, 27);
            this.lblReplacementLicenseID.TabIndex = 191;
            this.lblReplacementLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(431, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 27);
            this.label10.TabIndex = 190;
            this.label10.Text = "Replacement License ID:";
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
            this.pictureBox1.Location = new System.Drawing.Point(695, 114);
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
            this.label2.Location = new System.Drawing.Point(431, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 181;
            this.label2.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCreatedByUser.Location = new System.Drawing.Point(742, 111);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(68, 27);
            this.lblCreatedByUser.TabIndex = 180;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblApplicationFees.Location = new System.Drawing.Point(278, 113);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(64, 27);
            this.lblApplicationFees.TabIndex = 179;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 177;
            this.label3.Text = "Application Fees:";
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
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(277, 80);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(122, 27);
            this.lblApplicationDate.TabIndex = 176;
            this.lblApplicationDate.Text = "[??/??/????]";
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
            this.label5.Size = new System.Drawing.Size(182, 27);
            this.label5.TabIndex = 174;
            this.label5.Text = "Application Date:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblApplicationID.Location = new System.Drawing.Point(277, 48);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(58, 27);
            this.lblApplicationID.TabIndex = 173;
            this.lblApplicationID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 172;
            this.label4.Text = "R.L.Application ID:";
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(2, 71);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1036, 533);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnlicenseFound += new System.EventHandler<ClsLibraryBussniselayr.ClsLicenses>(this.ctrlLicenseInfoWithFilter1_OnlicenseFound);
            // 
            // FrmReplacementorDamageLicense
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1046, 877);
            this.Controls.Add(this.gpApplicationInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoLostLicense);
            this.Controls.Add(this.rdoDamagelicense);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.addparameter;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReplacementorDamageLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replacement or Damage License";
            this.gpApplicationInfo.ResumeLayout(false);
            this.gpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Frm_Renew_Driving_License.UserCtrls.CtrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.RadioButton rdoDamagelicense;
        private System.Windows.Forms.RadioButton rdoLostLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblReplacementLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label4;
    }
}