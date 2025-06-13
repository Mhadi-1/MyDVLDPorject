namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests
{
    partial class FrmTestAppointment
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
            this.ctrlShudleTest1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.CtrlShudleTestAppointment();
            this.SuspendLayout();
            // 
            // ctrlShudleTest1
            // 
            this.ctrlShudleTest1.Location = new System.Drawing.Point(7, 3);
            this.ctrlShudleTest1.Name = "ctrlShudleTest1";
            this.ctrlShudleTest1.Size = new System.Drawing.Size(642, 708);
            this.ctrlShudleTest1.TabIndex = 0;
            // 
            // FrmTestAppointment
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(657, 717);
            this.Controls.Add(this.ctrlShudleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.listviewappointment;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointment";
            this.Load += new System.EventHandler(this.FrmTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsrControls.CtrlShudleTestAppointment ctrlShudleTest1;
    }
}