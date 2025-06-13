namespace MyDVLDPorject.Frm_Appliciation
{
    partial class FrmApplicicationType
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
            this.lblRecord = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvApplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 758);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(87, 23);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "#Records";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 36);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.student_card;
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.editeToolStripMenuItem.Text = "Edite";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 739);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 74);
            this.panel1.TabIndex = 93;
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
            this.dgrvApplicationTypes.Location = new System.Drawing.Point(10, 288);
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
            this.dgrvApplicationTypes.Size = new System.Drawing.Size(824, 436);
            this.dgrvApplicationTypes.TabIndex = 0;
            this.dgrvApplicationTypes.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgrvApplicationTypes_CellContextMenuStripNeeded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 41);
            this.label2.TabIndex = 94;
            this.label2.Text = "Manage Applicaition Types";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDVLDPorject.Properties.Resources.planning;
            this.pictureBox2.Location = new System.Drawing.Point(290, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // FrmApplicicationType
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(845, 813);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrvApplicationTypes);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::MyDVLDPorject.Properties.Resources.Manage;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApplicicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Applicication Type";
            this.Load += new System.EventHandler(this.FrmApplicicationType_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvApplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrvApplicationTypes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}