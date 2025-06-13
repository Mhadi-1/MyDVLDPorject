namespace MyDVLDPorject.Frm_Appliciation
{
    partial class FrmIssueNewLocalDrivingLicnese
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
            this.button1 = new System.Windows.Forms.Button();
            this.mySiticoneLicenseSettings1 = new SiticoneNetFrameworkUI.MySiticoneLicenseSettings();
            this.txtboxNotes = new System.Windows.Forms.RichTextBox();
            this.ctrlGenralApplicationInfo1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlGenralApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(905, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Issue License";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySiticoneLicenseSettings1
            // 
            this.mySiticoneLicenseSettings1.OpenLicenseSettings = null;
            // 
            // txtboxNotes
            // 
            this.txtboxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNotes.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxNotes.Location = new System.Drawing.Point(122, 485);
            this.txtboxNotes.Name = "txtboxNotes";
            this.txtboxNotes.Size = new System.Drawing.Size(766, 190);
            this.txtboxNotes.TabIndex = 4;
            this.txtboxNotes.Text = "";
            // 
            // ctrlGenralApplicationInfo1
            // 
            this.ctrlGenralApplicationInfo1.Location = new System.Drawing.Point(9, 9);
            this.ctrlGenralApplicationInfo1.Name = "ctrlGenralApplicationInfo1";
            this.ctrlGenralApplicationInfo1.Size = new System.Drawing.Size(1034, 518);
            this.ctrlGenralApplicationInfo1.TabIndex = 0;
            this.ctrlGenralApplicationInfo1.Load += new System.EventHandler(this.ctrlGenralApplicationInfo1_Load);
            // 
            // FrmIssueNewLocalDrivingLicnese
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1056, 697);
            this.Controls.Add(this.txtboxNotes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlGenralApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.newtask;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIssueNewLocalDrivingLicnese";
            this.Text = "Issue New Local Driving Licnese";
            this.Load += new System.EventHandler(this.FrmIssueNewLocalDrivingLicnese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Frm_Sechdule_Tests.UsrControls.ctrlGenralApplicationInfo ctrlGenralApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private SiticoneNetFrameworkUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private System.Windows.Forms.RichTextBox txtboxNotes;
    }
}