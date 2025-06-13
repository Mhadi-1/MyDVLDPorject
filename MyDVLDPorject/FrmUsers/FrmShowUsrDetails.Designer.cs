namespace MyDVLDPorject.FrmUsers
{
    partial class FrmShowUsrDetails
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
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1 = new MyDVLDPorject.UserCtrls.UsrCtrlShowPersonInfoAndUsrLoginInfo();
            this.SuspendLayout();
            // 
            // usrCtrlShowPersonInfoAndUsrLoginInfo1
            // 
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.BackColor = System.Drawing.Color.White;
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Location = new System.Drawing.Point(3, 13);
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Name = "usrCtrlShowPersonInfoAndUsrLoginInfo1";
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.Size = new System.Drawing.Size(1139, 575);
            this.usrCtrlShowPersonInfoAndUsrLoginInfo1.TabIndex = 0;
            // 
            // FrmShowUsrDetails
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1146, 601);
            this.Controls.Add(this.usrCtrlShowPersonInfoAndUsrLoginInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::MyDVLDPorject.Properties.Resources.resume1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowUsrDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_CurrentUser Details";
            this.Load += new System.EventHandler(this.FrmShowUsrDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCtrls.UsrCtrlShowPersonInfoAndUsrLoginInfo usrCtrlShowPersonInfoAndUsrLoginInfo1;
    }
}