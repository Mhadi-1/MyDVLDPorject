namespace MyDVLDPorject.UserCtrls
{
    partial class UsrCtrlShowPersonInfoAndUsrLoginInfo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.usrCtrlPersonCard1 = new MyDVLDPorject.UserCtrls.UsrCtrlPersonCard();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblIsActive);
            this.groupBox3.Controls.Add(this.lbluserName);
            this.groupBox3.Controls.Add(this.lblUserID);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(9, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1113, 97);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIsActive.Location = new System.Drawing.Point(883, 45);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(119, 30);
            this.lblIsActive.TabIndex = 2;
            this.lblIsActive.Text = "IsActive :  ";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbluserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbluserName.Location = new System.Drawing.Point(493, 45);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(145, 30);
            this.lbluserName.TabIndex = 1;
            this.lbluserName.Text = "User Name : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserID.Location = new System.Drawing.Point(160, 45);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(107, 30);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID : ";
            // 
            // usrCtrlPersonCard1
            // 
            this.usrCtrlPersonCard1.Location = new System.Drawing.Point(58, 13);
            this.usrCtrlPersonCard1.Name = "usrCtrlPersonCard1";
            this.usrCtrlPersonCard1.Size = new System.Drawing.Size(1014, 457);
            this.usrCtrlPersonCard1.TabIndex = 9;
            // 
            // UsrCtrlShowPersonInfoAndUsrLoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usrCtrlPersonCard1);
            this.Controls.Add(this.groupBox3);
            this.Name = "UsrCtrlShowPersonInfoAndUsrLoginInfo";
            this.Size = new System.Drawing.Size(1131, 587);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Label lblUserID;
        private UsrCtrlPersonCard usrCtrlPersonCard1;
    }
}
