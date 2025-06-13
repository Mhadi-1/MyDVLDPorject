namespace MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp
{
    partial class FrmShowLocalLicenseInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingLicenesInfo1 = new MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp.ContrlosLocalDrivingLicenses.CtrlLocalDrivingLicenesInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(342, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driving Licenes Information ";
            // 
            // ctrlLocalDrivingLicenesInfo1
            // 
            this.ctrlLocalDrivingLicenesInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenesInfo1.Location = new System.Drawing.Point(36, 86);
            this.ctrlLocalDrivingLicenesInfo1.Name = "ctrlLocalDrivingLicenesInfo1";
            this.ctrlLocalDrivingLicenesInfo1.Size = new System.Drawing.Size(1035, 460);
            this.ctrlLocalDrivingLicenesInfo1.TabIndex = 0;
            // 
            // FrmShowLocalLicenseInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1092, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLocalDrivingLicenesInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.bo_resume;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowLocalLicenseInfo";
            this.Text = "Local License Info";
            this.Load += new System.EventHandler(this.FrmShowLocalLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContrlosLocalDrivingLicenses.CtrlLocalDrivingLicenesInfo ctrlLocalDrivingLicenesInfo1;
        private System.Windows.Forms.Label label1;
    }
}