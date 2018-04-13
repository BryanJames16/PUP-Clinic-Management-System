namespace ClinicManagementSystem
{
    partial class FormQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.btnMinimize = new MetroFramework.Controls.MetroTile();
            this.lblHead = new MetroFramework.Controls.MetroLabel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.dgvTagged = new MetroFramework.Controls.MetroGrid();
            this.lblTagged = new MetroFramework.Controls.MetroLabel();
            this.lblQueue = new MetroFramework.Controls.MetroLabel();
            this.dgvQueue = new MetroFramework.Controls.MetroGrid();
            this.colQueueNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatQID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatQLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatQFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.lblHead);
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(667, 120);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveControl = null;
            this.btnMinimize.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMinimize.Location = new System.Drawing.Point(620, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TileImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.TileImage")));
            this.btnMinimize.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.UseCustomBackColor = true;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.UseTileImage = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.Transparent;
            this.lblHead.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHead.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHead.Location = new System.Drawing.Point(247, 51);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(332, 25);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "PATIENT\'S QUEUE AND TAGGED LIST";
            this.lblHead.UseCustomBackColor = true;
            this.lblHead.UseCustomForeColor = true;
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(7, 0);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(191, 124);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            // 
            // dgvTagged
            // 
            this.dgvTagged.AllowUserToAddRows = false;
            this.dgvTagged.AllowUserToDeleteRows = false;
            this.dgvTagged.AllowUserToResizeRows = false;
            this.dgvTagged.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTagged.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTagged.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTagged.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTagged.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTagged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTagged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocID,
            this.colDocLastName,
            this.colPatID,
            this.colPatNo,
            this.colPatLastName,
            this.colPatFirstName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTagged.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTagged.EnableHeadersVisualStyles = false;
            this.dgvTagged.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTagged.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTagged.Location = new System.Drawing.Point(12, 303);
            this.dgvTagged.Name = "dgvTagged";
            this.dgvTagged.ReadOnly = true;
            this.dgvTagged.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTagged.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTagged.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTagged.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTagged.Size = new System.Drawing.Size(642, 123);
            this.dgvTagged.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvTagged.TabIndex = 2;
            this.dgvTagged.UseStyleColors = true;
            // 
            // lblTagged
            // 
            this.lblTagged.AutoSize = true;
            this.lblTagged.BackColor = System.Drawing.Color.Transparent;
            this.lblTagged.Location = new System.Drawing.Point(13, 278);
            this.lblTagged.Name = "lblTagged";
            this.lblTagged.Size = new System.Drawing.Size(59, 19);
            this.lblTagged.TabIndex = 3;
            this.lblTagged.Text = "TAGGED";
            this.lblTagged.UseCustomBackColor = true;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.BackColor = System.Drawing.Color.Transparent;
            this.lblQueue.Location = new System.Drawing.Point(13, 132);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(52, 19);
            this.lblQueue.TabIndex = 4;
            this.lblQueue.Text = "QUEUE";
            this.lblQueue.UseCustomBackColor = true;
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.AllowUserToResizeRows = false;
            this.dgvQueue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQueueNo,
            this.colPatQID,
            this.colPatQNo,
            this.colPatQLastName,
            this.colPatQFirstName,
            this.colStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQueue.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQueue.EnableHeadersVisualStyles = false;
            this.dgvQueue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQueue.Location = new System.Drawing.Point(12, 155);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueue.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQueue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.Size = new System.Drawing.Size(642, 120);
            this.dgvQueue.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvQueue.TabIndex = 5;
            this.dgvQueue.UseStyleColors = true;
            // 
            // colQueueNo
            // 
            this.colQueueNo.HeaderText = "Queue Number";
            this.colQueueNo.Name = "colQueueNo";
            this.colQueueNo.ReadOnly = true;
            // 
            // colPatQID
            // 
            this.colPatQID.HeaderText = "Patient ID";
            this.colPatQID.Name = "colPatQID";
            this.colPatQID.ReadOnly = true;
            // 
            // colPatQNo
            // 
            this.colPatQNo.HeaderText = "ID Number";
            this.colPatQNo.Name = "colPatQNo";
            this.colPatQNo.ReadOnly = true;
            // 
            // colPatQLastName
            // 
            this.colPatQLastName.HeaderText = "Patient Last Name";
            this.colPatQLastName.Name = "colPatQLastName";
            this.colPatQLastName.ReadOnly = true;
            // 
            // colPatQFirstName
            // 
            this.colPatQFirstName.HeaderText = "Patient First Name";
            this.colPatQFirstName.Name = "colPatQFirstName";
            this.colPatQFirstName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Queue Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colDocID
            // 
            this.colDocID.HeaderText = "Doctor\'s ID";
            this.colDocID.Name = "colDocID";
            this.colDocID.ReadOnly = true;
            // 
            // colDocLastName
            // 
            this.colDocLastName.HeaderText = "Doctor\'s Last Name";
            this.colDocLastName.Name = "colDocLastName";
            this.colDocLastName.ReadOnly = true;
            // 
            // colPatID
            // 
            this.colPatID.HeaderText = "Patient ID";
            this.colPatID.Name = "colPatID";
            this.colPatID.ReadOnly = true;
            // 
            // colPatNo
            // 
            this.colPatNo.HeaderText = "Patient No";
            this.colPatNo.Name = "colPatNo";
            this.colPatNo.ReadOnly = true;
            // 
            // colPatLastName
            // 
            this.colPatLastName.HeaderText = "Patient\'s Last Name";
            this.colPatLastName.Name = "colPatLastName";
            this.colPatLastName.ReadOnly = true;
            // 
            // colPatFirstName
            // 
            this.colPatFirstName.HeaderText = "Patient\'s First Name";
            this.colPatFirstName.Name = "colPatFirstName";
            this.colPatFirstName.ReadOnly = true;
            // 
            // FormQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(675, 438);
            this.Controls.Add(this.dgvQueue);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblTagged);
            this.Controls.Add(this.dgvTagged);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQueue";
            this.Text = "PUP CMS";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQueue_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroLabel lblHead;
        private MetroFramework.Controls.MetroGrid dgvTagged;
        private MetroFramework.Controls.MetroLabel lblTagged;
        private MetroFramework.Controls.MetroLabel lblQueue;
        private MetroFramework.Controls.MetroGrid dgvQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatQID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatQLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatQFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private MetroFramework.Controls.MetroTile btnMinimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatFirstName;

    }
}