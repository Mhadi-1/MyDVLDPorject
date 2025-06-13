namespace MyDVLDPorject.FrmUsers
{
    partial class FrmUpdateUser
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
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.userCtrlLoginBoard1 = new MyDVLDPorject.UserCtrls.UserCtrlLoginBoard();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usrctrlPersonWithFilter1 = new MyDVLDPorject.UserCtrls.usrctrlPersonWithFilter();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.DodgerBlue;
            label1.Location = new System.Drawing.Point(524, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 37);
            label1.TabIndex = 4;
            label1.Text = "Update User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Location = new System.Drawing.Point(7, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 708);
            this.tabControl1.TabIndex = 5;
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.userCtrlLoginBoard1);
            this.tbLoginInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginInfo.ForeColor = System.Drawing.Color.Black;
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 28);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(1233, 676);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "LoginInfo";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // userCtrlLoginBoard1
            // 
            this.userCtrlLoginBoard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrlLoginBoard1.BackColor = System.Drawing.Color.GhostWhite;
            this.userCtrlLoginBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCtrlLoginBoard1.Location = new System.Drawing.Point(271, 46);
            this.userCtrlLoginBoard1.Margin = new System.Windows.Forms.Padding(4);
            this.userCtrlLoginBoard1.Name = "userCtrlLoginBoard1";
            this.userCtrlLoginBoard1.Size = new System.Drawing.Size(619, 579);
            this.userCtrlLoginBoard1.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.groupBox2);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 28);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1233, 676);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "PersonInfo";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usrctrlPersonWithFilter1);
            this.groupBox2.Location = new System.Drawing.Point(26, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1189, 644);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Information";
            // 
            // usrctrlPersonWithFilter1
            // 
            this.usrctrlPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.usrctrlPersonWithFilter1.Location = new System.Drawing.Point(20, 23);
            this.usrctrlPersonWithFilter1.Name = "usrctrlPersonWithFilter1";
            this.usrctrlPersonWithFilter1.Size = new System.Drawing.Size(1146, 598);
            this.usrctrlPersonWithFilter1.TabIndex = 0;
            // 
            // FrmUpdateUser
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1252, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.SwitchUser;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateUser";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserCtrls.usrctrlPersonWithFilter usrctrlPersonWithFilter1;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private UserCtrls.UserCtrlLoginBoard userCtrlLoginBoard1;
    }
}