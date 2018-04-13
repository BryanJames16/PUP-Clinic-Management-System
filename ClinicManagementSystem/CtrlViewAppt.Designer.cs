namespace ClinicManagementSystem
{
    partial class CtrlViewAppt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlViewAppt));
            this.dgvAppointment = new MetroFramework.Controls.MetroGrid();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnAdmit = new MetroFramework.Controls.MetroTile();
            this.colPatLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatLastName,
            this.colPatFirstName,
            this.colPatContact,
            this.colPatGender,
            this.colDateTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointment.EnableHeadersVisualStyles = false;
            this.dgvAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppointment.Location = new System.Drawing.Point(19, 32);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(634, 313);
            this.dgvAppointment.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvAppointment.TabIndex = 0;
            this.dgvAppointment.UseStyleColors = true;
            this.dgvAppointment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancel.Location = new System.Drawing.Point(173, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.TileImage")));
            this.btnCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseTileImage = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.ActiveControl = null;
            this.btnAdmit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdmit.Location = new System.Drawing.Point(404, 366);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(86, 37);
            this.btnAdmit.TabIndex = 2;
            this.btnAdmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmit.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdmit.TileImage")));
            this.btnAdmit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmit.UseCustomBackColor = true;
            this.btnAdmit.UseCustomForeColor = true;
            this.btnAdmit.UseSelectable = true;
            this.btnAdmit.UseTileImage = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // colPatLastName
            // 
            this.colPatLastName.HeaderText = "Patient Last Name";
            this.colPatLastName.Name = "colPatLastName";
            this.colPatLastName.ReadOnly = true;
            this.colPatLastName.Width = 150;
            // 
            // colPatFirstName
            // 
            this.colPatFirstName.HeaderText = "Patient First Name";
            this.colPatFirstName.Name = "colPatFirstName";
            this.colPatFirstName.ReadOnly = true;
            this.colPatFirstName.Width = 150;
            // 
            // colPatContact
            // 
            this.colPatContact.HeaderText = "Contact Number";
            this.colPatContact.Name = "colPatContact";
            this.colPatContact.ReadOnly = true;
            this.colPatContact.Width = 150;
            // 
            // colPatGender
            // 
            this.colPatGender.HeaderText = "Gender";
            this.colPatGender.Name = "colPatGender";
            this.colPatGender.ReadOnly = true;
            this.colPatGender.Width = 150;
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date and Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // CtrlViewAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvAppointment);
            this.Name = "CtrlViewAppt";
            this.Size = new System.Drawing.Size(674, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAppointment;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroTile btnAdmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
    }
}
