namespace MyDVLDPorject.UserCtrls
{
    partial class UserCtrlLoginBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxConfirtPassWord = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxPassWod = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(184, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "IsActive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(57, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 85;
            this.label5.Text = "PassWord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "ConfirPassWord:";
            // 
            // txtbxConfirtPassWord
            // 
            this.txtbxConfirtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtbxConfirtPassWord.BorderColor = System.Drawing.Color.Black;
            this.txtbxConfirtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxConfirtPassWord.DefaultText = "";
            this.txtbxConfirtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxConfirtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxConfirtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxConfirtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxConfirtPassWord.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtbxConfirtPassWord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirtPassWord.ForeColor = System.Drawing.Color.Black;
            this.txtbxConfirtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxConfirtPassWord.IconRight = global::MyDVLDPorject.Properties.Resources.show_password;
            this.txtbxConfirtPassWord.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtbxConfirtPassWord.IconRightOffset = new System.Drawing.Point(2, -1);
            this.txtbxConfirtPassWord.Location = new System.Drawing.Point(184, 266);
            this.txtbxConfirtPassWord.Name = "txtbxConfirtPassWord";
            this.txtbxConfirtPassWord.PasswordChar = '\0';
            this.txtbxConfirtPassWord.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbxConfirtPassWord.PlaceholderText = "ConfirPassword";
            this.txtbxConfirtPassWord.SelectedText = "";
            this.txtbxConfirtPassWord.Size = new System.Drawing.Size(280, 33);
            this.txtbxConfirtPassWord.TabIndex = 83;
            this.txtbxConfirtPassWord.IconRightClick += new System.EventHandler(this.IconPassWord_OnClick);
            this.txtbxConfirtPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxConfirtPassWord_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(57, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "UserName :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderColor = System.Drawing.Color.Black;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(184, 152);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "user name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(280, 33);
            this.txtUserName.TabIndex = 81;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserID.ForeColor = System.Drawing.Color.Gray;
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblUserID.Location = new System.Drawing.Point(236, 85);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 31);
            this.lblUserID.TabIndex = 79;
            this.lblUserID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "UserID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.ImageToTextIndent = 35;
            this.simpleButton1.ImageOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.Save;
            this.simpleButton1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.simpleButton1.Location = new System.Drawing.Point(341, 365);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 40);
            this.simpleButton1.TabIndex = 90;
            this.simpleButton1.Text = " Save";
            this.simpleButton1.Click += new System.EventHandler(this.btnSave_OnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVLDPorject.Properties.Resources.student_card;
            this.pictureBox1.Location = new System.Drawing.Point(183, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxPassWod
            // 
            this.txtbxPassWod.BackColor = System.Drawing.Color.Transparent;
            this.txtbxPassWod.BorderColor = System.Drawing.Color.Black;
            this.txtbxPassWod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassWod.DefaultText = "";
            this.txtbxPassWod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassWod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassWod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassWod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassWod.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtbxPassWod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassWod.ForeColor = System.Drawing.Color.Black;
            this.txtbxPassWod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassWod.IconRight = global::MyDVLDPorject.Properties.Resources.show_password;
            this.txtbxPassWod.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtbxPassWod.IconRightOffset = new System.Drawing.Point(2, -1);
            this.txtbxPassWod.Location = new System.Drawing.Point(184, 209);
            this.txtbxPassWod.Name = "txtbxPassWod";
            this.txtbxPassWod.PasswordChar = '\0';
            this.txtbxPassWod.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbxPassWod.PlaceholderText = "Password";
            this.txtbxPassWod.SelectedText = "";
            this.txtbxPassWod.Size = new System.Drawing.Size(280, 33);
            this.txtbxPassWod.TabIndex = 91;
            this.txtbxPassWod.IconRightClick += new System.EventHandler(this.IconPassWord_OnClick);
            // 
            // UserCtrlLoginBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtbxPassWod);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxConfirtPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserCtrlLoginBoard";
            this.Size = new System.Drawing.Size(508, 450);
            this.Load += new System.EventHandler(this.UserCtrlLoginBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxConfirtPassWord;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxPassWod;
    }
}
