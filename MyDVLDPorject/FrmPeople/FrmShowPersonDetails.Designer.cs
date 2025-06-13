namespace MyDVLDPorject.Frms
{
    partial class FrmShowPersonDetails
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
            this.ctrlShowPesonDetails1 = new MyDVLDPorject.UserCtrls.ctrlShowPesonDetails();
            this.SuspendLayout();
            // 
            // ctrlShowPesonDetails1
            // 
            this.ctrlShowPesonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlShowPesonDetails1.Location = new System.Drawing.Point(5, 1);
            this.ctrlShowPesonDetails1.Name = "ctrlShowPesonDetails1";
            this.ctrlShowPesonDetails1.Size = new System.Drawing.Size(1122, 613);
            this.ctrlShowPesonDetails1.TabIndex = 0;
            this.ctrlShowPesonDetails1.Load += new System.EventHandler(this.ctrlShowPesonDetails1_Load);
            // 
            // FrmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 615);
            this.Controls.Add(this.ctrlShowPesonDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person/Details";
            this.ResumeLayout(false);

        }

        #endregion

        private UserCtrls.ctrlShowPesonDetails ctrlShowPesonDetails1;
    }
}