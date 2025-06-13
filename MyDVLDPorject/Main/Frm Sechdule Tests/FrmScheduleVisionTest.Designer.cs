namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests
{
    partial class FrmScheduleVisionTest
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
            this.siticonePanel1 = new SiticoneNetFrameworkUI.SiticonePanel();
            this.ctrlGenralApplicationInfo1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlGenralApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlGenralAppointmentsList1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlGenralAppointmentsList();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticonePanel1.AutoSize = true;
            this.siticonePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.siticonePanel1.BorderDashPattern = null;
            this.siticonePanel1.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.siticonePanel1.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.siticonePanel1.BorderThickness = 2F;
            this.siticonePanel1.CornerRadiusBottomLeft = 10F;
            this.siticonePanel1.CornerRadiusBottomRight = 10F;
            this.siticonePanel1.CornerRadiusTopLeft = 10F;
            this.siticonePanel1.CornerRadiusTopRight = 10F;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.EnableAcrylicEffect = false;
            this.siticonePanel1.EnableMicaEffect = false;
            this.siticonePanel1.EnableRippleEffect = false;
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.siticonePanel1.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.siticonePanel1.RippleAlpha = 50;
            this.siticonePanel1.RippleAlphaDecrement = 3;
            this.siticonePanel1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticonePanel1.RippleMaxSize = 600F;
            this.siticonePanel1.RippleSpeed = 15F;
            this.siticonePanel1.ShowBorder = true;
            this.siticonePanel1.Size = new System.Drawing.Size(1033, 0);
            this.siticonePanel1.TabIndex = 3;
            this.siticonePanel1.TabStop = true;
            this.siticonePanel1.UseBorderGradient = false;
            this.siticonePanel1.UseMultiGradient = false;
            this.siticonePanel1.UsePatternTexture = false;
            this.siticonePanel1.UseRadialGradient = false;
            // 
            // ctrlGenralApplicationInfo1
            // 
            this.ctrlGenralApplicationInfo1.Location = new System.Drawing.Point(8, 69);
            this.ctrlGenralApplicationInfo1.Name = "ctrlGenralApplicationInfo1";
            this.ctrlGenralApplicationInfo1.Size = new System.Drawing.Size(1015, 467);
            this.ctrlGenralApplicationInfo1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(432, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 106;
            this.label1.Text = "Vrisition Test ";
            // 
            // ctrlGenralAppointmentsList1
            // 
            this.ctrlGenralAppointmentsList1.Location = new System.Drawing.Point(4, 539);
            this.ctrlGenralAppointmentsList1.Name = "ctrlGenralAppointmentsList1";
            this.ctrlGenralAppointmentsList1.Size = new System.Drawing.Size(1029, 364);
            this.ctrlGenralAppointmentsList1.TabIndex = 107;
            // 
            // FrmScheduleVisionTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1033, 909);
            this.Controls.Add(this.ctrlGenralAppointmentsList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.ctrlGenralApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.EyeGaze;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScheduleVisionTest";
            this.Text = "Vrisual Shuel Test";
            this.Load += new System.EventHandler(this.FrmScheduleVisionTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SiticoneNetFrameworkUI.SiticonePanel siticonePanel1;
        private UsrControls.ctrlGenralApplicationInfo ctrlGenralApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private UsrControls.ctrlGenralAppointmentsList ctrlGenralAppointmentsList1;
    }
}