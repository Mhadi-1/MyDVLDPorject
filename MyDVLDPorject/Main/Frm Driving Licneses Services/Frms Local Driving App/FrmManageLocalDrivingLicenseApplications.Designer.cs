namespace MyDVLDPorject.Frm_Appliciation
{
    partial class FrmManageLocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dtgridviewLocalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbobxFilterKeys = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewLocalLicenses)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 985);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1664, 985);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtbxSearch);
            this.panel3.Controls.Add(this.dtgridviewLocalLicenses);
            this.panel3.Controls.Add(this.cmbobxFilterKeys);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1664, 603);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::MyDVLDPorject.Properties.Resources.add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(1544, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 76);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtbxSearch.Location = new System.Drawing.Point(430, 50);
            this.txtbxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PasswordChar = '\0';
            this.txtbxSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbxSearch.PlaceholderText = "Search";
            this.txtbxSearch.SelectedText = "";
            this.txtbxSearch.Size = new System.Drawing.Size(278, 33);
            this.txtbxSearch.TabIndex = 20;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // dtgridviewLocalLicenses
            // 
            this.dtgridviewLocalLicenses.AllowUserToAddRows = false;
            this.dtgridviewLocalLicenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgridviewLocalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridviewLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgridviewLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dtgridviewLocalLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridviewLocalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridviewLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewLocalLicenses.ContextMenuStrip = this.cmsApplications;
            this.dtgridviewLocalLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgridviewLocalLicenses.GridColor = System.Drawing.Color.White;
            this.dtgridviewLocalLicenses.Location = new System.Drawing.Point(0, 117);
            this.dtgridviewLocalLicenses.Name = "dtgridviewLocalLicenses";
            this.dtgridviewLocalLicenses.ReadOnly = true;
            this.dtgridviewLocalLicenses.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgridviewLocalLicenses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgridviewLocalLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgridviewLocalLicenses.RowTemplate.Height = 28;
            this.dtgridviewLocalLicenses.Size = new System.Drawing.Size(1664, 486);
            this.dtgridviewLocalLicenses.TabIndex = 2;
            this.dtgridviewLocalLicenses.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dtgridviewLocalLicenses_CellContextMenuStripNeeded);
            // 
            // cmsApplications
            // 
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editToolStripMenuItem,
            this.DeleteApplicationToolStripMenuItem,
            this.toolStripSeparator5,
            this.CancelApplicaitonToolStripMenuItem,
            this.toolStripSeparator1,
            this.ScheduleTestsMenue,
            this.toolStripSeparator3,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator4,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsApplications.Size = new System.Drawing.Size(347, 329);
            this.cmsApplications.Opened += new System.EventHandler(this.cmsApplications_Opened);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.clipboard;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showDetailsToolStripMenuItem.Text = "&Show Application Details";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(343, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.account1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.editToolStripMenuItem.Text = "&Edit Application";
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            this.DeleteApplicationToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.delete;
            this.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            this.DeleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.DeleteApplicationToolStripMenuItem.Text = "&Delete Application";
            this.DeleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.DeleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(343, 6);
            // 
            // CancelApplicaitonToolStripMenuItem
            // 
            this.CancelApplicaitonToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.icons8_enter_50__1_;
            this.CancelApplicaitonToolStripMenuItem.Name = "CancelApplicaitonToolStripMenuItem";
            this.CancelApplicaitonToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.CancelApplicaitonToolStripMenuItem.Text = "&Cancel Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(343, 6);
            // 
            // ScheduleTestsMenue
            // 
            this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsMenue.Image = global::MyDVLDPorject.Properties.Resources.resume1;
            this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            this.ScheduleTestsMenue.Size = new System.Drawing.Size(346, 32);
            this.ScheduleTestsMenue.Text = "Sechdule &Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.icons8_show_password_30;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(289, 40);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.note;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(289, 40);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.license1;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(289, 40);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(343, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.student_card;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "&Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(343, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.search;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showLicenseToolStripMenuItem.Text = "Show &License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(343, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.planning;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // cmbobxFilterKeys
            // 
            this.cmbobxFilterKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobxFilterKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbobxFilterKeys.FormattingEnabled = true;
            this.cmbobxFilterKeys.Items.AddRange(new object[] {
            "None",
            "LocalDrivingLicenseApplicationID",
            "ClassName",
            "NationalNo",
            "FullName",
            "PassedTestCount",
            "Status"});
            this.cmbobxFilterKeys.Location = new System.Drawing.Point(134, 48);
            this.cmbobxFilterKeys.Name = "cmbobxFilterKeys";
            this.cmbobxFilterKeys.Size = new System.Drawing.Size(278, 37);
            this.cmbobxFilterKeys.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filter By : ";
            // 
            // FrmManageLocalDrivingLicenseApplications
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 985);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.managequeries1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.FrmManageLocalDrivingLicenseApplications_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewLocalLicenses)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbxSearch;
        private System.Windows.Forms.DataGridView dtgridviewLocalLicenses;
        private System.Windows.Forms.ComboBox cmbobxFilterKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicaitonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}