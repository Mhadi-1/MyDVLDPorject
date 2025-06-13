namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests
{
    partial class FrmScheduleStreetTest
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
            this.ctrlGenralApplicationInfo1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlGenralApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlGenralAppointmentsList1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlGenralAppointmentsList();
            this.SuspendLayout();
            // 
            // ctrlGenralApplicationInfo1
            // 
            this.ctrlGenralApplicationInfo1.Location = new System.Drawing.Point(8, 69);
            this.ctrlGenralApplicationInfo1.Name = "ctrlGenralApplicationInfo1";
            this.ctrlGenralApplicationInfo1.Size = new System.Drawing.Size(1015, 467);
            this.ctrlGenralApplicationInfo1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(432, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 105;
            this.label1.Text = "Street Test ";
            // 
            // ctrlGenralAppointmentsList1
            // 
            this.ctrlGenralAppointmentsList1.Location = new System.Drawing.Point(4, 539);
            this.ctrlGenralAppointmentsList1.Name = "ctrlGenralAppointmentsList1";
            this.ctrlGenralAppointmentsList1.Size = new System.Drawing.Size(1029, 364);
            this.ctrlGenralAppointmentsList1.TabIndex = 106;
            // 
            // FrmScheduleStreetTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1033, 909);
            this.Controls.Add(this.ctrlGenralAppointmentsList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlGenralApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.Car;
            this.Name = "FrmScheduleStreetTest";
            this.Text = "Schedule Street Test";
            this.Load += new System.EventHandler(this.FrmScheduleStreetTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UsrControls.ctrlGenralApplicationInfo ctrlGenralApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private UsrControls.ctrlGenralAppointmentsList ctrlGenralAppointmentsList1;
    }
}