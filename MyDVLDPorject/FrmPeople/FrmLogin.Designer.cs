namespace MyMemeoryGame
{
    partial class FrmLogin
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
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TxtBxUserName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.TxtBxPassWord = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIncrrectPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_HIDE;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(481, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 68);
            this.label3.TabIndex = 12;
            this.label3.Text = "ENTER USER NAME AND PASSWORD PLEASE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(507, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 68);
            this.label2.TabIndex = 10;
            this.label2.Text = "DVDL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.checkBox1.Location = new System.Drawing.Point(492, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 26);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Rember Me ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TxtBxUserName
            // 
            this.TxtBxUserName.Animated = true;
            this.TxtBxUserName.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtBxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxUserName.DefaultText = "";
            this.TxtBxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxUserName.FocusedState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.FocusedState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(98)))));
            this.TxtBxUserName.HoverState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.HoverState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxUserName.Location = new System.Drawing.Point(487, 285);
            this.TxtBxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBxUserName.MaxLength = 37;
            this.TxtBxUserName.Name = "TxtBxUserName";
            this.TxtBxUserName.PasswordChar = '\0';
            this.TxtBxUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtBxUserName.PlaceholderText = "_CurrentUser Name";
            this.TxtBxUserName.SelectedText = "";
            this.TxtBxUserName.Size = new System.Drawing.Size(428, 46);
            this.TxtBxUserName.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TxtBxUserName.TabIndex = 8;
            this.TxtBxUserName.TabStop = false;
            this.TxtBxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx_Validating);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.Red;
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(935, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(51, 41);
            this.siticoneButton1.TabIndex = 14;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.BtnCancel_OnClick);
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(93)))), ((int)(((byte)(54)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Location = new System.Drawing.Point(623, 467);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.Btn_Next_OnClick);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.siticoneBorderlessForm1.BorderRadius = 5;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockForm = false;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragStartTransparencyValue = 1D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // TxtBxPassWord
            // 
            this.TxtBxPassWord.Animated = true;
            this.TxtBxPassWord.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtBxPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxPassWord.DefaultText = "";
            this.TxtBxPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxPassWord.FocusedState.BorderColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.FocusedState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(98)))));
            this.TxtBxPassWord.HoverState.BorderColor = System.Drawing.Color.Red;
            this.TxtBxPassWord.HoverState.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.TxtBxPassWord.IconRight = global::MyDVLDPorject.Properties.Resources.hide_Password;
            this.TxtBxPassWord.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBxPassWord.IconRightOffset = new System.Drawing.Point(-3, 0);
            this.TxtBxPassWord.Location = new System.Drawing.Point(487, 360);
            this.TxtBxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBxPassWord.MaxLength = 32;
            this.TxtBxPassWord.Name = "TxtBxPassWord";
            this.TxtBxPassWord.PasswordChar = '\0';
            this.TxtBxPassWord.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtBxPassWord.PlaceholderText = "PassWord";
            this.TxtBxPassWord.SelectedText = "";
            this.TxtBxPassWord.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.TxtBxPassWord.Size = new System.Drawing.Size(428, 46);
            this.TxtBxPassWord.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TxtBxPassWord.TabIndex = 9;
            this.TxtBxPassWord.TabStop = false;
            this.TxtBxPassWord.IconRightClick += new System.EventHandler(this.TxtBxPassWord_IconRightClick);
            this.TxtBxPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(218)))), ((int)(((byte)(209)))));
            this.panel1.BackgroundImage = global::MyDVLDPorject.Properties.Resources.car_driver_license_identification_with_photo_and_car_illustration_vector;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 666);
            this.panel1.TabIndex = 0;
            // 
            // lblIncrrectPass
            // 
            this.lblIncrrectPass.AutoSize = true;
            this.lblIncrrectPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncrrectPass.ForeColor = System.Drawing.Color.Red;
            this.lblIncrrectPass.Location = new System.Drawing.Point(488, 548);
            this.lblIncrrectPass.Name = "lblIncrrectPass";
            this.lblIncrrectPass.Size = new System.Drawing.Size(435, 20);
            this.lblIncrrectPass.TabIndex = 16;
            this.lblIncrrectPass.Text = "Sorry user name or password is incorrect  please try agin !!";
            this.lblIncrrectPass.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(987, 666);
            this.Controls.Add(this.lblIncrrectPass);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtBxPassWord);
            this.Controls.Add(this.TxtBxUserName);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TxtBxPassWord;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TxtBxUserName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNext;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label lblIncrrectPass;
    }
}

