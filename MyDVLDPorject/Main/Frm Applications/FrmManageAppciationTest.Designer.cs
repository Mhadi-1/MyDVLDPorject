namespace MyDVLDPorject.Frm_Appliciation
{
    partial class FrmManageAppciationTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgrvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 41);
            this.label2.TabIndex = 99;
            this.label2.Text = "Manage Applicaition Test";
            // 
            // dgrvApplicationTypes
            // 
            this.dgrvApplicationTypes.AllowUserToAddRows = false;
            this.dgrvApplicationTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgrvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgrvApplicationTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrvApplicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgrvApplicationTypes.EnableHeadersVisualStyles = false;
            this.dgrvApplicationTypes.GridColor = System.Drawing.Color.White;
            this.dgrvApplicationTypes.Location = new System.Drawing.Point(5, 265);
            this.dgrvApplicationTypes.MultiSelect = false;
            this.dgrvApplicationTypes.Name = "dgrvApplicationTypes";
            this.dgrvApplicationTypes.ReadOnly = true;
            this.dgrvApplicationTypes.RowHeadersVisible = false;
            this.dgrvApplicationTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgrvApplicationTypes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvApplicationTypes.RowTemplate.Height = 28;
            this.dgrvApplicationTypes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgrvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvApplicationTypes.ShowCellErrors = false;
            this.dgrvApplicationTypes.ShowCellToolTips = false;
            this.dgrvApplicationTypes.ShowEditingIcon = false;
            this.dgrvApplicationTypes.ShowRowErrors = false;
            this.dgrvApplicationTypes.Size = new System.Drawing.Size(824, 437);
            this.dgrvApplicationTypes.TabIndex = 96;
            this.dgrvApplicationTypes.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgrvApplicationTypes_CellContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 36);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.student_card;
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.editeToolStripMenuItem.Text = "Edite Test Type";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLDPorject.Properties.Resources.development_plan;
            this.pictureBox2.Location = new System.Drawing.Point(285, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 725);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(87, 23);
            this.lblRecord.TabIndex = 102;
            this.lblRecord.Text = "#Records";
            // 
            // FrmManageAppciationTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 783);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrvApplicationTypes);
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.managerules;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageAppciationTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Type";
            this.Load += new System.EventHandler(this.FrmManageAppciationTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrvApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.Label lblRecord;
    }
}