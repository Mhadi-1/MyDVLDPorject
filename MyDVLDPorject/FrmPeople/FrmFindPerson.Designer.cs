namespace MyDVLDPorject.FrmPeople
{
    partial class FrmFindPerson
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.usrctrlPersonWithFilter1 = new MyDVLDPorject.UserCtrls.usrctrlPersonWithFilter();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(566, 583);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(117, 37);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "Select ";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // usrctrlPersonWithFilter1
            // 
            this.usrctrlPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.usrctrlPersonWithFilter1.Location = new System.Drawing.Point(10, 12);
            this.usrctrlPersonWithFilter1.Name = "usrctrlPersonWithFilter1";
            this.usrctrlPersonWithFilter1.Size = new System.Drawing.Size(1156, 623);
            this.usrctrlPersonWithFilter1.TabIndex = 2;
            this.usrctrlPersonWithFilter1.OnPersonIDFound += new System.Action<int>(this.usrctrlPersonWithFilter1_OnPersonIDFound);
            // 
            // FrmFindPerson
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1178, 658);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.usrctrlPersonWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.actions_add;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Person";
            this.Load += new System.EventHandler(this.FrmFindPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCtrls.usrctrlPersonWithFilter usrctrlPersonWithFilter1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}