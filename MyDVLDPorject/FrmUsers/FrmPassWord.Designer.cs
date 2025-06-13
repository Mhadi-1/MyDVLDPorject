namespace MyDVLDPorject.FrmUsers
{
    partial class FrmPassWord
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
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1 = new MyDVLDPorject.UserCtrls.UsrCtrlShowPersonInfoAndUsrLoginInfo();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxNewPassWord = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbxConfirtPassWord = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbxPassWod = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usrCtrlShowPersonInfoAndUsrLoginInfo1
            // 
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.BackColor = System.Drawing.Color.White;
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Location = new System.Drawing.Point(12, 8);
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Name = "usrCtrlShowPersonInfoAndUsrLoginInfo1";
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Size = new System.Drawing.Size(1131, 582);
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(839, 796);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 38);
            this.button2.TabIndex = 107;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(998, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 106;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Savebtn_OnClick);
            // 
            // txtbxNewPassWord
            // 
            this.txtbxNewPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtbxNewPassWord.BorderColor = System.Drawing.Color.Black;
            this.txtbxNewPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxNewPassWord.DefaultText = "";
            this.txtbxNewPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxNewPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxNewPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNewPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNewPassWord.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtbxNewPassWord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNewPassWord.ForeColor = System.Drawing.Color.Black;
            this.txtbxNewPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxNewPassWord.IconRight = global::MyDVLDPorject.Properties.Resources.show_password;
            this.txtbxNewPassWord.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtbxNewPassWord.IconRightOffset = new System.Drawing.Point(2, -1);
            this.txtbxNewPassWord.Location = new System.Drawing.Point(204, 656);
            this.txtbxNewPassWord.Name = "txtbxNewPassWord";
            this.txtbxNewPassWord.PasswordChar = '\0';
            this.txtbxNewPassWord.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbxNewPassWord.PlaceholderText = "New Password";
            this.txtbxNewPassWord.SelectedText = "";
            this.txtbxNewPassWord.Size = new System.Drawing.Size(280, 33);
            this.txtbxNewPassWord.TabIndex = 105;
            this.txtbxNewPassWord.IconRightClick += new System.EventHandler(this.PassWod_IconRightClick);
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
            this.txtbxConfirtPassWord.Location = new System.Drawing.Point(204, 706);
            this.txtbxConfirtPassWord.Name = "txtbxConfirtPassWord";
            this.txtbxConfirtPassWord.PasswordChar = '\0';
            this.txtbxConfirtPassWord.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbxConfirtPassWord.PlaceholderText = "Confirt Password";
            this.txtbxConfirtPassWord.SelectedText = "";
            this.txtbxConfirtPassWord.Size = new System.Drawing.Size(280, 33);
            this.txtbxConfirtPassWord.TabIndex = 104;
            this.txtbxConfirtPassWord.IconRightClick += new System.EventHandler(this.PassWod_IconRightClick);
            this.txtbxConfirtPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxConfirtPassWord_Validating);
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
            this.txtbxPassWod.Location = new System.Drawing.Point(204, 608);
            this.txtbxPassWod.Name = "txtbxPassWod";
            this.txtbxPassWod.PasswordChar = '\0';
            this.txtbxPassWod.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbxPassWod.PlaceholderText = "Current ";
            this.txtbxPassWod.SelectedText = "";
            this.txtbxPassWod.Size = new System.Drawing.Size(280, 33);
            this.txtbxPassWod.TabIndex = 103;
            this.txtbxPassWod.IconRightClick += new System.EventHandler(this.PassWod_IconRightClick);
            this.txtbxPassWod.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxPassWod_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 706);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 102;
            this.label6.Text = "Confirt PassWord :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 101;
            this.label5.Text = "New PassWord :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Current :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPassWord
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1156, 864);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxNewPassWord);
            this.Controls.Add(this.txtbxConfirtPassWord);
            this.Controls.Add(this.txtbxPassWod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usrCtrlShowPersonInfoAndUsrLoginInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPassWord";
            this.Text = "Change PassWord";
            this.Load += new System.EventHandler(this.FrmPassWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserCtrls.UsrCtrlShowPersonInfoAndUsrLoginInfo usrCtrlShowPersonInfoAndUsrLoginInfo1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxNewPassWord;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxConfirtPassWord;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxPassWod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}