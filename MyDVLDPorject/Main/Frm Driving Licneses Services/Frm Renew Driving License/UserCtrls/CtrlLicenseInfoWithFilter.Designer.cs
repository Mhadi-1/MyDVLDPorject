namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls
{
    partial class CtrlLicenseInfoWithFilter
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
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingLicenesInfo1 = new MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp.ContrlosLocalDrivingLicenses.CtrlLocalDrivingLicenesInfo();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.Color.White;
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtLicenseID);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(217, 19);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilters.Size = new System.Drawing.Size(602, 98);
            this.gbFilters.TabIndex = 20;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::MyDVLDPorject.Properties.Resources.search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Location = new System.Drawing.Point(520, 31);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(57, 44);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenseID.Location = new System.Drawing.Point(170, 40);
            this.txtLicenseID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(320, 26);
            this.txtLicenseID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "LicenseID:";
            // 
            // ctrlLocalDrivingLicenesInfo1
            // 
            this.ctrlLocalDrivingLicenesInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenesInfo1.Location = new System.Drawing.Point(3, 124);
            this.ctrlLocalDrivingLicenesInfo1.Name = "ctrlLocalDrivingLicenesInfo1";
            this.ctrlLocalDrivingLicenesInfo1.Size = new System.Drawing.Size(1031, 436);
            this.ctrlLocalDrivingLicenesInfo1.TabIndex = 19;
            // 
            // CtrlLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlLocalDrivingLicenesInfo1);
            this.Name = "CtrlLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1036, 562);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private Frm_Appliciation.Frms_LocalDrivingApp.ContrlosLocalDrivingLicenses.CtrlLocalDrivingLicenesInfo ctrlLocalDrivingLicenesInfo1;
    }
}
