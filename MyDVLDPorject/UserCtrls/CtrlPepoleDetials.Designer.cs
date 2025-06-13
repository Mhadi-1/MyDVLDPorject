namespace MyDVLDPorject.UserCtrls
{
    partial class CtrlPepoleDetials
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cmbobxFilterKeys = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataRecords = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.MainContextStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContextStrip
            // 
            this.MainContextStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailesToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.MainContextStrip.Name = "MainContextStrip";
            this.MainContextStrip.Size = new System.Drawing.Size(225, 196);
            // 
            // showDetailesToolStripMenuItem
            // 
            this.showDetailesToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.clipboard;
            this.showDetailesToolStripMenuItem.Name = "showDetailesToolStripMenuItem";
            this.showDetailesToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.showDetailesToolStripMenuItem.Text = "Show Details";
            this.showDetailesToolStripMenuItem.Click += new System.EventHandler(this.showDetailesToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.add_user1;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.btnAddNew_OnClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.note;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.remove_user;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.email__1_;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.mobile;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtbxSearch);
            this.panel1.Controls.Add(this.cmbobxFilterKeys);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 97);
            this.panel1.TabIndex = 1;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSearch.DefaultText = "";
            this.txtbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearch.Location = new System.Drawing.Point(426, 30);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PasswordChar = '\0';
            this.txtbxSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbxSearch.PlaceholderText = "Search";
            this.txtbxSearch.SelectedText = "";
            this.txtbxSearch.Size = new System.Drawing.Size(278, 38);
            this.txtbxSearch.TabIndex = 17;
            this.txtbxSearch.Visible = false;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // cmbobxFilterKeys
            // 
            this.cmbobxFilterKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobxFilterKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbobxFilterKeys.FormattingEnabled = true;
            this.cmbobxFilterKeys.Location = new System.Drawing.Point(136, 31);
            this.cmbobxFilterKeys.Name = "cmbobxFilterKeys";
            this.cmbobxFilterKeys.Size = new System.Drawing.Size(278, 37);
            this.cmbobxFilterKeys.TabIndex = 14;
            this.cmbobxFilterKeys.SelectedIndexChanged += new System.EventHandler(this.cmbobxFilterKeys_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::MyDVLDPorject.Properties.Resources.add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(1467, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 76);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAddNew_OnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By : ";
            // 
            // lblDataRecords
            // 
            this.lblDataRecords.AutoSize = true;
            this.lblDataRecords.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblDataRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(54)))));
            this.lblDataRecords.Location = new System.Drawing.Point(53, 510);
            this.lblDataRecords.Name = "lblDataRecords";
            this.lblDataRecords.Size = new System.Drawing.Size(119, 30);
            this.lblDataRecords.TabIndex = 15;
            this.lblDataRecords.Text = "#Records ";
            // 
            // dgvUser
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.MainContextStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.Location = new System.Drawing.Point(8, 102);
            this.dgvPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvUser";
            this.dgvPeople.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.RowHeadersWidth = 62;
            this.dgvPeople.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1561, 399);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.TabStop = false;
            this.dgvPeople.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvPeople_CellContextMenuStripNeeded);
            // 
            // CtrlPepoleDetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataRecords);
            this.Name = "CtrlPepoleDetials";
            this.Size = new System.Drawing.Size(1582, 546);
            this.Load += new System.EventHandler(this.CtrlPepoleDetials_Load);
            this.MainContextStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip MainContextStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxSearch;
        private System.Windows.Forms.ComboBox cmbobxFilterKeys;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataRecords;
        private System.Windows.Forms.DataGridView dgvPeople;
    }
}
