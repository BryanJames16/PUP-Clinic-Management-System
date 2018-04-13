namespace ClinicManagementSystem
{
    partial class FormAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmission));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.pboIcon = new System.Windows.Forms.PictureBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlCatcher = new MetroFramework.Controls.MetroPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.pnlProfile);
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(666, 117);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.SlateGray;
            this.pnlProfile.Controls.Add(this.lblFirstName);
            this.pnlProfile.Controls.Add(this.pboIcon);
            this.pnlProfile.Controls.Add(this.lblUserType);
            this.pnlProfile.Controls.Add(this.lblUserID);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(346, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(282, 108);
            this.pnlProfile.TabIndex = 4;
            this.pnlProfile.UseCustomBackColor = true;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            this.pnlProfile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlProfile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(10, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.Style = MetroFramework.MetroColorStyle.White;
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.UseCustomBackColor = true;
            this.lblFirstName.UseStyleColors = true;
            // 
            // pboIcon
            // 
            this.pboIcon.Image = ((System.Drawing.Image)(resources.GetObject("pboIcon.Image")));
            this.pboIcon.Location = new System.Drawing.Point(162, 0);
            this.pboIcon.Name = "pboIcon";
            this.pboIcon.Size = new System.Drawing.Size(94, 91);
            this.pboIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboIcon.TabIndex = 5;
            this.pboIcon.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserType.Location = new System.Drawing.Point(10, 72);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(67, 19);
            this.lblUserType.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "User Type";
            this.lblUserType.UseCustomBackColor = true;
            this.lblUserType.UseStyleColors = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserID.Location = new System.Drawing.Point(10, 53);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 19);
            this.lblUserID.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User ID";
            this.lblUserID.UseCustomBackColor = true;
            this.lblUserID.UseStyleColors = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastName.Location = new System.Drawing.Point(9, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 25);
            this.lblLastName.Style = MetroFramework.MetroColorStyle.White;
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.UseCustomBackColor = true;
            this.lblLastName.UseStyleColors = true;
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(5, 5);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(168, 108);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            this.pboLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pboLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pboLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlCatcher
            // 
            this.pnlCatcher.BackColor = System.Drawing.Color.Lavender;
            this.pnlCatcher.HorizontalScrollbarBarColor = true;
            this.pnlCatcher.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCatcher.HorizontalScrollbarSize = 10;
            this.pnlCatcher.Location = new System.Drawing.Point(4, 119);
            this.pnlCatcher.Name = "pnlCatcher";
            this.pnlCatcher.Size = new System.Drawing.Size(666, 467);
            this.pnlCatcher.TabIndex = 4;
            this.pnlCatcher.UseCustomBackColor = true;
            this.pnlCatcher.VerticalScrollbarBarColor = true;
            this.pnlCatcher.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCatcher.VerticalScrollbarSize = 10;
            // 
            // FormAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(676, 591);
            this.Controls.Add(this.pnlCatcher);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP CMS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private System.Windows.Forms.PictureBox pboIcon;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroPanel pnlCatcher;
    }
}