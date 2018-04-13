namespace ClinicManagementSystem
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblUsername);
            this.pnlHeader.Controls.Add(this.btnLogIn);
            this.pnlHeader.Controls.Add(this.textUsername);
            this.pnlHeader.Controls.Add(this.btnClear);
            this.pnlHeader.Controls.Add(this.lblPassword);
            this.pnlHeader.Controls.Add(this.textPassword);
            this.pnlHeader.ForeColor = System.Drawing.Color.SkyBlue;
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(380, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(392, 316);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.UseCustomForeColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(40, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Location = new System.Drawing.Point(40, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 25);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.UseCustomForeColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.Location = new System.Drawing.Point(250, 222);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(86, 37);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // textUsername
            // 
            this.textUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textUsername.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(44, 71);
            this.textUsername.MaxLength = 32;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PromptText = "Rowan0897";
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.ShowClearButton = true;
            this.textUsername.Size = new System.Drawing.Size(292, 28);
            this.textUsername.Style = MetroFramework.MetroColorStyle.Lime;
            this.textUsername.TabIndex = 9;
            this.textUsername.UseSelectable = true;
            this.textUsername.UseStyleColors = true;
            this.textUsername.WaterMark = "Rowan0897";
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(146, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 37);
            this.btnClear.TabIndex = 12;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(40, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.UseCustomBackColor = true;
            this.lblPassword.UseCustomForeColor = true;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(44, 161);
            this.textPassword.MaxLength = 32;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.PromptText = "•••••••••••";
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(292, 28);
            this.textPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.textPassword.TabIndex = 11;
            this.textPassword.UseSelectable = true;
            this.textPassword.UseStyleColors = true;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.WaterMark = "•••••••••••";
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(26, 26);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(334, 277);
            this.pboLogo.TabIndex = 3;
            this.pboLogo.TabStop = false;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(777, 326);
            this.Controls.Add(this.pboLogo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP CMS - Log In";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.Button btnLogIn;
        private MetroFramework.Controls.MetroTextBox textUsername;
        private System.Windows.Forms.Button btnClear;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private System.Windows.Forms.PictureBox pboLogo;

    }
}

