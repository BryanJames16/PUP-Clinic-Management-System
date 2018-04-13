namespace ClinicManagementSystem
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.pboIcon = new System.Windows.Forms.PictureBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.pnlNavBar = new MetroFramework.Controls.MetroPanel();
            this.btnLogOut = new MetroFramework.Controls.MetroTile();
            this.btnRemoveStaff = new MetroFramework.Controls.MetroTile();
            this.btnMeta = new MetroFramework.Controls.MetroTile();
            this.btnAddStaff = new MetroFramework.Controls.MetroTile();
            this.btnPatient = new MetroFramework.Controls.MetroTile();
            this.pnlControl = new MetroFramework.Controls.MetroPanel();
            this.lblAction = new MetroFramework.Controls.MetroLabel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(0, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(792, 121);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            // 
            // pboLogo
            // 
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(5, 5);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(168, 108);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
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
            this.pnlProfile.Location = new System.Drawing.Point(498, 1);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(282, 108);
            this.pnlProfile.TabIndex = 3;
            this.pnlProfile.UseCustomBackColor = true;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
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
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.btnLogOut);
            this.pnlNavBar.Controls.Add(this.btnRemoveStaff);
            this.pnlNavBar.Controls.Add(this.btnMeta);
            this.pnlNavBar.Controls.Add(this.btnAddStaff);
            this.pnlNavBar.Controls.Add(this.btnPatient);
            this.pnlNavBar.HorizontalScrollbarBarColor = true;
            this.pnlNavBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlNavBar.HorizontalScrollbarSize = 10;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 121);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(183, 399);
            this.pnlNavBar.TabIndex = 3;
            this.pnlNavBar.UseCustomBackColor = true;
            this.pnlNavBar.VerticalScrollbarBarColor = true;
            this.pnlNavBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlNavBar.VerticalScrollbarSize = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveControl = null;
            this.btnLogOut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogOut.Location = new System.Drawing.Point(5, 291);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 59);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.TileImage")));
            this.btnLogOut.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.UseTileImage = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.ActiveControl = null;
            this.btnRemoveStaff.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRemoveStaff.Location = new System.Drawing.Point(5, 156);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(168, 59);
            this.btnRemoveStaff.TabIndex = 2;
            this.btnRemoveStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveStaff.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveStaff.TileImage")));
            this.btnRemoveStaff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveStaff.UseCustomBackColor = true;
            this.btnRemoveStaff.UseCustomForeColor = true;
            this.btnRemoveStaff.UseSelectable = true;
            this.btnRemoveStaff.UseTileImage = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // btnMeta
            // 
            this.btnMeta.ActiveControl = null;
            this.btnMeta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMeta.Location = new System.Drawing.Point(5, 224);
            this.btnMeta.Name = "btnMeta";
            this.btnMeta.Size = new System.Drawing.Size(168, 59);
            this.btnMeta.TabIndex = 4;
            this.btnMeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMeta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnMeta.TileImage")));
            this.btnMeta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMeta.UseCustomBackColor = true;
            this.btnMeta.UseCustomForeColor = true;
            this.btnMeta.UseSelectable = true;
            this.btnMeta.UseTileImage = true;
            this.btnMeta.Visible = false;
            this.btnMeta.Click += new System.EventHandler(this.btnMeta_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.ActiveControl = null;
            this.btnAddStaff.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddStaff.Location = new System.Drawing.Point(5, 91);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(168, 59);
            this.btnAddStaff.TabIndex = 3;
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStaff.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.TileImage")));
            this.btnAddStaff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStaff.UseCustomBackColor = true;
            this.btnAddStaff.UseCustomForeColor = true;
            this.btnAddStaff.UseSelectable = true;
            this.btnAddStaff.UseTileImage = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.ActiveControl = null;
            this.btnPatient.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPatient.Location = new System.Drawing.Point(5, 26);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(168, 59);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatient.TileImage = ((System.Drawing.Image)(resources.GetObject("btnPatient.TileImage")));
            this.btnPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatient.UseCustomBackColor = true;
            this.btnPatient.UseCustomForeColor = true;
            this.btnPatient.UseSelectable = true;
            this.btnPatient.UseTileImage = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.BackColor = System.Drawing.Color.Lavender;
            this.pnlControl.HorizontalScrollbar = true;
            this.pnlControl.HorizontalScrollbarBarColor = true;
            this.pnlControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControl.HorizontalScrollbarSize = 10;
            this.pnlControl.Location = new System.Drawing.Point(183, 168);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(609, 349);
            this.pnlControl.TabIndex = 4;
            this.pnlControl.UseCustomBackColor = true;
            this.pnlControl.VerticalScrollbar = true;
            this.pnlControl.VerticalScrollbarBarColor = true;
            this.pnlControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControl.VerticalScrollbarSize = 10;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAction.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAction.ForeColor = System.Drawing.Color.White;
            this.lblAction.Location = new System.Drawing.Point(552, 131);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(81, 25);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "ACTION";
            this.lblAction.UseCustomBackColor = true;
            this.lblAction.UseCustomForeColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(792, 518);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP CMS";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private System.Windows.Forms.PictureBox pboIcon;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroPanel pnlNavBar;
        private MetroFramework.Controls.MetroTile btnPatient;
        private MetroFramework.Controls.MetroTile btnAddStaff;
        private MetroFramework.Controls.MetroTile btnMeta;
        private MetroFramework.Controls.MetroPanel pnlControl;
        private MetroFramework.Controls.MetroLabel lblAction;
        private MetroFramework.Controls.MetroTile btnRemoveStaff;
        private MetroFramework.Controls.MetroTile btnLogOut;
    }
}