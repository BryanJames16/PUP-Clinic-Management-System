namespace ClinicManagementSystem
{
    partial class CtrlReportNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlReportNav));
            this.tilePatMedHist = new MetroFramework.Controls.MetroTile();
            this.tilePatHisto = new MetroFramework.Controls.MetroTile();
            this.tileRegiPats = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tilePatMedHist
            // 
            this.tilePatMedHist.ActiveControl = null;
            this.tilePatMedHist.Location = new System.Drawing.Point(446, 131);
            this.tilePatMedHist.Name = "tilePatMedHist";
            this.tilePatMedHist.Size = new System.Drawing.Size(206, 182);
            this.tilePatMedHist.TabIndex = 5;
            this.tilePatMedHist.Text = "Patient Medical History";
            this.tilePatMedHist.TileImage = ((System.Drawing.Image)(resources.GetObject("tilePatMedHist.TileImage")));
            this.tilePatMedHist.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePatMedHist.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePatMedHist.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePatMedHist.UseSelectable = true;
            this.tilePatMedHist.UseTileImage = true;
            this.tilePatMedHist.Click += new System.EventHandler(this.tilePatMedHist_Click);
            // 
            // tilePatHisto
            // 
            this.tilePatHisto.ActiveControl = null;
            this.tilePatHisto.BackColor = System.Drawing.Color.LawnGreen;
            this.tilePatHisto.Location = new System.Drawing.Point(235, 131);
            this.tilePatHisto.Name = "tilePatHisto";
            this.tilePatHisto.Size = new System.Drawing.Size(206, 182);
            this.tilePatHisto.TabIndex = 4;
            this.tilePatHisto.Text = "Patient Log History";
            this.tilePatHisto.TileImage = ((System.Drawing.Image)(resources.GetObject("tilePatHisto.TileImage")));
            this.tilePatHisto.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePatHisto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePatHisto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePatHisto.UseSelectable = true;
            this.tilePatHisto.UseTileImage = true;
            this.tilePatHisto.Click += new System.EventHandler(this.tilePatHisto_Click);
            // 
            // tileRegiPats
            // 
            this.tileRegiPats.ActiveControl = null;
            this.tileRegiPats.Location = new System.Drawing.Point(23, 131);
            this.tileRegiPats.Name = "tileRegiPats";
            this.tileRegiPats.Size = new System.Drawing.Size(206, 182);
            this.tileRegiPats.TabIndex = 3;
            this.tileRegiPats.Text = "Registered Patients";
            this.tileRegiPats.TileImage = ((System.Drawing.Image)(resources.GetObject("tileRegiPats.TileImage")));
            this.tileRegiPats.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRegiPats.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRegiPats.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRegiPats.UseSelectable = true;
            this.tileRegiPats.UseTileImage = true;
            this.tileRegiPats.Click += new System.EventHandler(this.tileRegiPats_Click);
            // 
            // CtrlReportNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tilePatHisto);
            this.Controls.Add(this.tilePatMedHist);
            this.Controls.Add(this.tileRegiPats);
            this.Name = "CtrlReportNav";
            this.Size = new System.Drawing.Size(674, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tilePatMedHist;
        private MetroFramework.Controls.MetroTile tilePatHisto;
        private MetroFramework.Controls.MetroTile tileRegiPats;
    }
}
