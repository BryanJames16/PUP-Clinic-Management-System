namespace ClinicManagementSystem
{
    partial class CtrlDoctReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDoctReports));
            this.tileTagHist = new MetroFramework.Controls.MetroTile();
            this.tileAppointRec = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileTagHist
            // 
            this.tileTagHist.ActiveControl = null;
            this.tileTagHist.Location = new System.Drawing.Point(347, 115);
            this.tileTagHist.Name = "tileTagHist";
            this.tileTagHist.Size = new System.Drawing.Size(296, 215);
            this.tileTagHist.TabIndex = 3;
            this.tileTagHist.Text = "Tag History";
            this.tileTagHist.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTagHist.TileImage")));
            this.tileTagHist.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTagHist.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTagHist.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileTagHist.UseSelectable = true;
            this.tileTagHist.UseTileImage = true;
            this.tileTagHist.Click += new System.EventHandler(this.tileTagHist_Click);
            // 
            // tileAppointRec
            // 
            this.tileAppointRec.ActiveControl = null;
            this.tileAppointRec.BackColor = System.Drawing.Color.Teal;
            this.tileAppointRec.Location = new System.Drawing.Point(31, 115);
            this.tileAppointRec.Name = "tileAppointRec";
            this.tileAppointRec.Size = new System.Drawing.Size(299, 215);
            this.tileAppointRec.TabIndex = 2;
            this.tileAppointRec.Text = "Appointments Records";
            this.tileAppointRec.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAppointRec.TileImage")));
            this.tileAppointRec.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAppointRec.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAppointRec.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAppointRec.UseCustomBackColor = true;
            this.tileAppointRec.UseSelectable = true;
            this.tileAppointRec.UseTileImage = true;
            this.tileAppointRec.Click += new System.EventHandler(this.tileAppointRec_Click);
            // 
            // CtrlDoctReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileTagHist);
            this.Controls.Add(this.tileAppointRec);
            this.Name = "CtrlDoctReports";
            this.Size = new System.Drawing.Size(674, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileTagHist;
        private MetroFramework.Controls.MetroTile tileAppointRec;
    }
}
