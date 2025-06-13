namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    partial class ctrlGenralAppointmentsList
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
            this.siticoneActivityButton1 = new SiticoneNetFrameworkUI.SiticoneActivityButton();
            this.siticoneShimmerLabel2 = new SiticoneNetFrameworkUI.SiticoneShimmerLabel();
            this.dgrvAppointmentsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAppointmentsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneActivityButton1
            // 
            this.siticoneActivityButton1.ActivityDuration = 1000;
            this.siticoneActivityButton1.ActivityIndicatorColor = System.Drawing.Color.White;
            this.siticoneActivityButton1.ActivityIndicatorSize = 4;
            this.siticoneActivityButton1.ActivityIndicatorSpeed = 100;
            this.siticoneActivityButton1.ActivityText = "...";
            this.siticoneActivityButton1.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad;
            this.siticoneActivityButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneActivityButton1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.siticoneActivityButton1.BorderColor = System.Drawing.Color.White;
            this.siticoneActivityButton1.BorderWidth = 2;
            this.siticoneActivityButton1.CornerRadiusBottomLeft = 0;
            this.siticoneActivityButton1.CornerRadiusBottomRight = 5;
            this.siticoneActivityButton1.CornerRadiusTopLeft = 5;
            this.siticoneActivityButton1.CornerRadiusTopRight = 5;
            this.siticoneActivityButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.siticoneActivityButton1.Elevation = 2F;
            this.siticoneActivityButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneActivityButton1.HoverAnimationDuration = 200;
            this.siticoneActivityButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.siticoneActivityButton1.Location = new System.Drawing.Point(827, 6);
            this.siticoneActivityButton1.Name = "siticoneActivityButton1";
            this.siticoneActivityButton1.PressAnimationDuration = 150;
            this.siticoneActivityButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.siticoneActivityButton1.PressedElevation = 1F;
            this.siticoneActivityButton1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneActivityButton1.RippleDuration = 1800;
            this.siticoneActivityButton1.RippleSize = 5;
            this.siticoneActivityButton1.ShowActivityText = true;
            this.siticoneActivityButton1.Size = new System.Drawing.Size(196, 40);
            this.siticoneActivityButton1.TabIndex = 107;
            this.siticoneActivityButton1.Text = "New Appointment";
            this.siticoneActivityButton1.TextColor = System.Drawing.Color.White;
            this.siticoneActivityButton1.UseAnimation = true;
            this.siticoneActivityButton1.UseElevation = false;
            this.siticoneActivityButton1.UseRippleEffect = true;
            this.siticoneActivityButton1.Click += new System.EventHandler(this.siticoneActivityButton1_Click);
            // 
            // siticoneShimmerLabel2
            // 
            this.siticoneShimmerLabel2.AutoReverse = false;
            this.siticoneShimmerLabel2.BaseColor = System.Drawing.Color.Red;
            this.siticoneShimmerLabel2.Direction = SiticoneNetFrameworkUI.ShimmerDirection.LeftToRight;
            this.siticoneShimmerLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.siticoneShimmerLabel2.IsAnimating = true;
            this.siticoneShimmerLabel2.IsPaused = false;
            this.siticoneShimmerLabel2.Location = new System.Drawing.Point(7, 6);
            this.siticoneShimmerLabel2.Name = "siticoneShimmerLabel2";
            this.siticoneShimmerLabel2.PauseDuration = 0;
            this.siticoneShimmerLabel2.ShimmerColor = System.Drawing.Color.RoyalBlue;
            this.siticoneShimmerLabel2.ShimmerOpacity = 1F;
            this.siticoneShimmerLabel2.ShimmerSpeed = 50;
            this.siticoneShimmerLabel2.ShimmerWidth = 0.2F;
            this.siticoneShimmerLabel2.Size = new System.Drawing.Size(196, 40);
            this.siticoneShimmerLabel2.TabIndex = 106;
            this.siticoneShimmerLabel2.Text = "Appointments List";
            this.siticoneShimmerLabel2.ToolTipText = "";
            // 
            // dgrvAppointmentsList
            // 
            this.dgrvAppointmentsList.AllowUserToAddRows = false;
            this.dgrvAppointmentsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgrvAppointmentsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvAppointmentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvAppointmentsList.BackgroundColor = System.Drawing.Color.White;
            this.dgrvAppointmentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrvAppointmentsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvAppointmentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvAppointmentsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgrvAppointmentsList.EnableHeadersVisualStyles = false;
            this.dgrvAppointmentsList.GridColor = System.Drawing.Color.White;
            this.dgrvAppointmentsList.Location = new System.Drawing.Point(2, 74);
            this.dgrvAppointmentsList.MultiSelect = false;
            this.dgrvAppointmentsList.Name = "dgrvAppointmentsList";
            this.dgrvAppointmentsList.ReadOnly = true;
            this.dgrvAppointmentsList.RowHeadersVisible = false;
            this.dgrvAppointmentsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgrvAppointmentsList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvAppointmentsList.RowTemplate.Height = 28;
            this.dgrvAppointmentsList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgrvAppointmentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvAppointmentsList.ShowCellErrors = false;
            this.dgrvAppointmentsList.ShowCellToolTips = false;
            this.dgrvAppointmentsList.ShowEditingIcon = false;
            this.dgrvAppointmentsList.ShowRowErrors = false;
            this.dgrvAppointmentsList.Size = new System.Drawing.Size(1023, 302);
            this.dgrvAppointmentsList.TabIndex = 105;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 101);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.plus1;
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editeToolStripMenuItem.Text = "Edite";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::MyDVLDPorject.Properties.Resources.note;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ctrlGenralAppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneActivityButton1);
            this.Controls.Add(this.siticoneShimmerLabel2);
            this.Controls.Add(this.dgrvAppointmentsList);
            this.Name = "ctrlGenralAppointmentsList";
            this.Size = new System.Drawing.Size(1029, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAppointmentsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneActivityButton siticoneActivityButton1;
        private SiticoneNetFrameworkUI.SiticoneShimmerLabel siticoneShimmerLabel2;
        private System.Windows.Forms.DataGridView dgrvAppointmentsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}
