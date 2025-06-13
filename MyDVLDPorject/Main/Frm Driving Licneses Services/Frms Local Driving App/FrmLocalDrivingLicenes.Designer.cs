namespace MyDVLDPorject.FrmLicenses
{
    partial class FrmLocalDrivingLicenes
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
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpersonInfo = new System.Windows.Forms.TabPage();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabApplciationInfo = new System.Windows.Forms.TabPage();
            this.siticoneActivityButton1 = new SiticoneNetFrameworkUI.SiticoneActivityButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbxLicensesClassesTypes = new System.Windows.Forms.ComboBox();
            this.lblUserName = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblDate = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblFees = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneLabel6 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel5 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel2 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel4 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel3 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.usrctrlPersonWithFilter1 = new MyDVLDPorject.UserCtrls.usrctrlPersonWithFilter();
            this.tabControl1.SuspendLayout();
            this.tabpersonInfo.SuspendLayout();
            this.tabApplciationInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneLabel1.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Red;
            this.siticoneLabel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(1206, 53);
            this.siticoneLabel1.TabIndex = 0;
            this.siticoneLabel1.Text = "New Local Driving Licenes";
            this.siticoneLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpersonInfo);
            this.tabControl1.Controls.Add(this.tabApplciationInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1206, 646);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabpersonInfo
            // 
            this.tabpersonInfo.Controls.Add(this.siticoneButton1);
            this.tabpersonInfo.Controls.Add(this.usrctrlPersonWithFilter1);
            this.tabpersonInfo.Location = new System.Drawing.Point(4, 28);
            this.tabpersonInfo.Name = "tabpersonInfo";
            this.tabpersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpersonInfo.Size = new System.Drawing.Size(1198, 614);
            this.tabpersonInfo.TabIndex = 0;
            this.tabpersonInfo.Text = "Person Information";
            this.tabpersonInfo.UseVisualStyleBackColor = true;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(545, 552);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(117, 37);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "Next";
            this.siticoneButton1.Click += new System.EventHandler(this.btnNext_OnClick);
            // 
            // tabApplciationInfo
            // 
            this.tabApplciationInfo.BackColor = System.Drawing.Color.White;
            this.tabApplciationInfo.Controls.Add(this.siticoneActivityButton1);
            this.tabApplciationInfo.Controls.Add(this.groupBox1);
            this.tabApplciationInfo.Location = new System.Drawing.Point(4, 28);
            this.tabApplciationInfo.Name = "tabApplciationInfo";
            this.tabApplciationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplciationInfo.Size = new System.Drawing.Size(1198, 614);
            this.tabApplciationInfo.TabIndex = 1;
            this.tabApplciationInfo.Text = "Application Information";
            // 
            // siticoneActivityButton1
            // 
            this.siticoneActivityButton1.ActivityDuration = 2000;
            this.siticoneActivityButton1.ActivityIndicatorColor = System.Drawing.Color.White;
            this.siticoneActivityButton1.ActivityIndicatorSize = 4;
            this.siticoneActivityButton1.ActivityIndicatorSpeed = 100;
            this.siticoneActivityButton1.ActivityText = "";
            this.siticoneActivityButton1.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.Linear;
            this.siticoneActivityButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneActivityButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.siticoneActivityButton1.BorderWidth = 2;
            this.siticoneActivityButton1.CornerRadiusBottomLeft = 5;
            this.siticoneActivityButton1.CornerRadiusBottomRight = 5;
            this.siticoneActivityButton1.CornerRadiusTopLeft = 5;
            this.siticoneActivityButton1.CornerRadiusTopRight = 5;
            this.siticoneActivityButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.siticoneActivityButton1.Elevation = 2F;
            this.siticoneActivityButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneActivityButton1.HoverAnimationDuration = 200;
            this.siticoneActivityButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.siticoneActivityButton1.Location = new System.Drawing.Point(879, 526);
            this.siticoneActivityButton1.Name = "siticoneActivityButton1";
            this.siticoneActivityButton1.PressAnimationDuration = 150;
            this.siticoneActivityButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.siticoneActivityButton1.PressedElevation = 1F;
            this.siticoneActivityButton1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneActivityButton1.RippleDuration = 1800;
            this.siticoneActivityButton1.RippleSize = 5;
            this.siticoneActivityButton1.ShowActivityText = true;
            this.siticoneActivityButton1.Size = new System.Drawing.Size(118, 35);
            this.siticoneActivityButton1.TabIndex = 6;
            this.siticoneActivityButton1.Text = "Save";
            this.siticoneActivityButton1.TextColor = System.Drawing.Color.White;
            this.siticoneActivityButton1.UseAnimation = true;
            this.siticoneActivityButton1.UseElevation = false;
            this.siticoneActivityButton1.UseRippleEffect = true;
            this.siticoneActivityButton1.Click += new System.EventHandler(this.siticoneActivityButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.cmbxLicensesClassesTypes);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblFees);
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.siticoneLabel6);
            this.groupBox1.Controls.Add(this.siticoneLabel5);
            this.groupBox1.Controls.Add(this.siticoneLabel2);
            this.groupBox1.Controls.Add(this.siticoneLabel4);
            this.groupBox1.Controls.Add(this.siticoneLabel3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(209, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 475);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyDVLDPorject.Properties.Resources.transport;
            this.pictureBox3.Location = new System.Drawing.Point(279, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyDVLDPorject.Properties.Resources.account_maintenance;
            this.pictureBox5.Location = new System.Drawing.Point(279, 362);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyDVLDPorject.Properties.Resources.subscription;
            this.pictureBox4.Location = new System.Drawing.Point(279, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLDPorject.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(279, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // cmbxLicensesClassesTypes
            // 
            this.cmbxLicensesClassesTypes.BackColor = System.Drawing.Color.White;
            this.cmbxLicensesClassesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLicensesClassesTypes.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbxLicensesClassesTypes.FormattingEnabled = true;
            this.cmbxLicensesClassesTypes.Location = new System.Drawing.Point(344, 247);
            this.cmbxLicensesClassesTypes.Name = "cmbxLicensesClassesTypes";
            this.cmbxLicensesClassesTypes.Size = new System.Drawing.Size(306, 28);
            this.cmbxLicensesClassesTypes.TabIndex = 15;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(347, 362);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(151, 38);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(337, 168);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 38);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "01/01/1990";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFees
            // 
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(347, 304);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(151, 38);
            this.lblFees.TabIndex = 12;
            this.lblFees.Text = "0.0";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblApplicationID.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblApplicationID.Location = new System.Drawing.Point(406, 115);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(52, 24);
            this.lblApplicationID.TabIndex = 5;
            this.lblApplicationID.Text = "? ? ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLDPorject.Properties.Resources.student_card;
            this.pictureBox1.Location = new System.Drawing.Point(343, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel6.Location = new System.Drawing.Point(98, 360);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(148, 38);
            this.siticoneLabel6.TabIndex = 4;
            this.siticoneLabel6.Text = "Created By. ";
            this.siticoneLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.Location = new System.Drawing.Point(98, 302);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(175, 38);
            this.siticoneLabel5.TabIndex = 3;
            this.siticoneLabel5.Text = "Application Fees.";
            this.siticoneLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(103, 107);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(241, 37);
            this.siticoneLabel2.TabIndex = 0;
            this.siticoneLabel2.Text = "L.D.Application ID : ";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(98, 238);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(151, 38);
            this.siticoneLabel4.TabIndex = 2;
            this.siticoneLabel4.Text = "License Class.";
            this.siticoneLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(98, 168);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(176, 38);
            this.siticoneLabel3.TabIndex = 1;
            this.siticoneLabel3.Text = "Application Date.";
            this.siticoneLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrctrlPersonWithFilter1
            // 
            this.usrctrlPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.usrctrlPersonWithFilter1.Dock = System.Windows.Forms.DockStyle.Left;
            this.usrctrlPersonWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.usrctrlPersonWithFilter1.Name = "usrctrlPersonWithFilter1";
            this.usrctrlPersonWithFilter1.Size = new System.Drawing.Size(1183, 608);
            this.usrctrlPersonWithFilter1.TabIndex = 0;
            this.usrctrlPersonWithFilter1.OnPersonIDFound += new System.Action<int>(this.usrctrlPersonWithFilter1_OnPersonIDFound);
            // 
            // FrmLocalDrivingLicenes
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 732);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.siticoneLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.newemployee1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalDrivingLicenes";
            this.Text = "FrmLocalDrivingLicenes";
            this.Load += new System.EventHandler(this.FrmLocalDrivingLicenes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpersonInfo.ResumeLayout(false);
            this.tabApplciationInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpersonInfo;
        private UserCtrls.usrctrlPersonWithFilter usrctrlPersonWithFilter1;
        private System.Windows.Forms.TabPage tabApplciationInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel3;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel6;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel5;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel4;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private SiticoneNetFrameworkUI.SiticoneLabel lblUserName;
        private SiticoneNetFrameworkUI.SiticoneLabel lblDate;
        private SiticoneNetFrameworkUI.SiticoneLabel lblFees;
        private System.Windows.Forms.ComboBox cmbxLicensesClassesTypes;
        private SiticoneNetFrameworkUI.SiticoneActivityButton siticoneActivityButton1;
    }
}