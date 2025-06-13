namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s
{
    partial class FrmListDetainLicenseApplication
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
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(-3, 199);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersWidth = 62;
            this.dgvDetainedLicenses.RowTemplate.Height = 28;
            this.dgvDetainedLicenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1297, 458);
            this.dgvDetainedLicenses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Detian Licenses";
            // 
            // FrmListDetainLicenseApplication
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1296, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.managerelations;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListDetainLicenseApplication";
            this.Text = "List Detian Licenses";
            this.Load += new System.EventHandler(this.ManageReleasedApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Label label1;
    }
}