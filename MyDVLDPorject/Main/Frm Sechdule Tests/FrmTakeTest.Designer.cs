namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests
{
    partial class FrmTakeTest
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
            this.ctrlSheduleTakeTest1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.CtrlSheduleTakeTest();
            this.SuspendLayout();
            // 
            // ctrlSheduleTakeTest1
            // 
            this.ctrlSheduleTakeTest1.BackColor = System.Drawing.Color.White;
            this.ctrlSheduleTakeTest1.Location = new System.Drawing.Point(-1, 22);
            this.ctrlSheduleTakeTest1.Name = "ctrlSheduleTakeTest1";
            this.ctrlSheduleTakeTest1.Size = new System.Drawing.Size(767, 814);
            this.ctrlSheduleTakeTest1.TabIndex = 0;
            this.ctrlSheduleTakeTest1.Load += new System.EventHandler(this.ctrlSheduleTakeTest1_Load);
            // 
            // FrmTakeTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 852);
            this.Controls.Add(this.ctrlSheduleTakeTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.floatingobjectbringinfrontoftext;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.FrmTakeTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsrControls.CtrlSheduleTakeTest ctrlSheduleTakeTest1;
    }
}