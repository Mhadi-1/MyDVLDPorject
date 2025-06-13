namespace MyDVLDPorject.UserCtrls
{
    partial class usrctrlPersonWithFilter
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
            this.grbxfilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchTextBx = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ctrlShowPesonDetails1 = new MyDVLDPorject.UserCtrls.ctrlShowPesonDetails();
            this.grbxfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxfilter
            // 
            this.grbxfilter.Controls.Add(this.btnSearch);
            this.grbxfilter.Controls.Add(this.SearchTextBx);
            this.grbxfilter.Controls.Add(this.comboBox1);
            this.grbxfilter.Controls.Add(this.label2);
            this.grbxfilter.Location = new System.Drawing.Point(76, 9);
            this.grbxfilter.Name = "grbxfilter";
            this.grbxfilter.Size = new System.Drawing.Size(909, 87);
            this.grbxfilter.TabIndex = 1;
            this.grbxfilter.TabStop = false;
            this.grbxfilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::MyDVLDPorject.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(804, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 53);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchTextBx
            // 
            this.SearchTextBx.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBx.BorderColor = System.Drawing.Color.Black;
            this.SearchTextBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBx.DefaultText = "";
            this.SearchTextBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBx.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.SearchTextBx.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBx.Location = new System.Drawing.Point(515, 29);
            this.SearchTextBx.Name = "SearchTextBx";
            this.SearchTextBx.PasswordChar = '\0';
            this.SearchTextBx.PlaceholderForeColor = System.Drawing.Color.Red;
            this.SearchTextBx.PlaceholderText = "Search";
            this.SearchTextBx.SelectedText = "";
            this.SearchTextBx.Size = new System.Drawing.Size(280, 35);
            this.SearchTextBx.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "None";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 35);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(86, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(961, 580);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 39);
            this.btnClear.TabIndex = 96;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ctrlShowPesonDetails1
            // 
            this.ctrlShowPesonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlShowPesonDetails1.Location = new System.Drawing.Point(20, 100);
            this.ctrlShowPesonDetails1.Name = "ctrlShowPesonDetails1";
            this.ctrlShowPesonDetails1.Size = new System.Drawing.Size(1129, 549);
            this.ctrlShowPesonDetails1.TabIndex = 97;
            // 
            // usrctrlPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbxfilter);
            this.Controls.Add(this.ctrlShowPesonDetails1);
            this.Name = "usrctrlPersonWithFilter";
            this.Size = new System.Drawing.Size(1162, 665);
            this.Load += new System.EventHandler(this.usrctrlPersonWithFilter_Load);
            this.grbxfilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxfilter;
        private System.Windows.Forms.Button btnSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SearchTextBx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private ctrlShowPesonDetails ctrlShowPesonDetails1;
    }
}
