namespace MyDVLDPorject.FrmUsers
{
    partial class FrmAddUser
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
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlShowPesonDetails1 = new MyDVLDPorject.UserCtrls.ctrlShowPesonDetails();
            this.userCtrlLoginBoard1 = new MyDVLDPorject.UserCtrls.UserCtrlLoginBoard();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.DodgerBlue;
            label1.Location = new System.Drawing.Point(498, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(236, 37);
            label1.TabIndex = 3;
            label1.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(3, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 667);
            this.tabControl1.TabIndex = 2;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.siticoneButton1);
            this.tbPersonInfo.Controls.Add(this.button1);
            this.tbPersonInfo.Controls.Add(this.ctrlShowPesonDetails1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 28);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1219, 635);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "PersonInfo";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(953, 53);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(188, 43);
            this.siticoneButton1.TabIndex = 5;
            this.siticoneButton1.Text = "select a perosn";
            this.siticoneButton1.Click += new System.EventHandler(this.btnSelectAPerson_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(543, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNext_OnClick);
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.userCtrlLoginBoard1);
            this.tbLoginInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginInfo.ForeColor = System.Drawing.Color.Black;
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 28);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(1219, 635);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "LoginInfo";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlShowPesonDetails1
            // 
            this.ctrlShowPesonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlShowPesonDetails1.Location = new System.Drawing.Point(41, 36);
            this.ctrlShowPesonDetails1.Name = "ctrlShowPesonDetails1";
            this.ctrlShowPesonDetails1.Size = new System.Drawing.Size(1138, 563);
            this.ctrlShowPesonDetails1.TabIndex = 6;
            // 
            // userCtrlLoginBoard1
            // 
            this.userCtrlLoginBoard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrlLoginBoard1.BackColor = System.Drawing.Color.GhostWhite;
            this.userCtrlLoginBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCtrlLoginBoard1.Location = new System.Drawing.Point(278, 39);
            this.userCtrlLoginBoard1.Margin = new System.Windows.Forms.Padding(4);
            this.userCtrlLoginBoard1.Name = "userCtrlLoginBoard1";
            this.userCtrlLoginBoard1.Size = new System.Drawing.Size(676, 561);
            this.userCtrlLoginBoard1.TabIndex = 0;
            // 
            // FrmAddUser
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1232, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.actions_user;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserCtrls.UserCtrlLoginBoard userCtrlLoginBoard1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Button button1;
        private UserCtrls.ctrlShowPesonDetails ctrlShowPesonDetails1;
    }
}