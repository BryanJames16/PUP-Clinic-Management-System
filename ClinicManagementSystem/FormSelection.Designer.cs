namespace ClinicManagementSystem
{
    partial class FormSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelection));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.btnFrontDesk = new MetroFramework.Controls.MetroTile();
            this.btnDoctor = new MetroFramework.Controls.MetroTile();
            this.btnAdmin = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(741, 124);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            // 
            // pboLogo
            // 
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(7, 0);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(191, 124);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            // 
            // btnFrontDesk
            // 
            this.btnFrontDesk.ActiveControl = null;
            this.btnFrontDesk.Location = new System.Drawing.Point(146, 153);
            this.btnFrontDesk.Name = "btnFrontDesk";
            this.btnFrontDesk.Size = new System.Drawing.Size(175, 123);
            this.btnFrontDesk.TabIndex = 2;
            this.btnFrontDesk.TileImage = ((System.Drawing.Image)(resources.GetObject("btnFrontDesk.TileImage")));
            this.btnFrontDesk.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFrontDesk.UseSelectable = true;
            this.btnFrontDesk.UseTileImage = true;
            this.btnFrontDesk.Click += new System.EventHandler(this.btnFrontDesk_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.ActiveControl = null;
            this.btnDoctor.Location = new System.Drawing.Point(414, 153);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(175, 123);
            this.btnDoctor.TabIndex = 3;
            this.btnDoctor.TileImage = ((System.Drawing.Image)(resources.GetObject("btnDoctor.TileImage")));
            this.btnDoctor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctor.UseSelectable = true;
            this.btnDoctor.UseTileImage = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.ActiveControl = null;
            this.btnAdmin.Location = new System.Drawing.Point(146, 316);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(175, 123);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.TileImage")));
            this.btnAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.UseSelectable = true;
            this.btnAdmin.UseTileImage = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveControl = null;
            this.btnExit.Location = new System.Drawing.Point(414, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 123);
            this.btnExit.TabIndex = 5;
            this.btnExit.TileImage = ((System.Drawing.Image)(resources.GetObject("btnExit.TileImage")));
            this.btnExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseTileImage = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnFrontDesk);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP CMS";
            this.Shown += new System.EventHandler(this.FormSelection_Shown);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroTile btnFrontDesk;
        private MetroFramework.Controls.MetroTile btnDoctor;
        private MetroFramework.Controls.MetroTile btnAdmin;
        private MetroFramework.Controls.MetroTile btnExit;
    }
}