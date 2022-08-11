namespace CuaHangHoa
{
    partial class fDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoanhThu));
            this.TDT_btShow = new System.Windows.Forms.Button();
            this.TDT_dtpTo = new System.Windows.Forms.DateTimePicker();
            this.TDT_dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.TDT_dgvStatistics = new System.Windows.Forms.DataGridView();
            this.MaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TDT_dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // TDT_btShow
            // 
            this.TDT_btShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TDT_btShow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDT_btShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TDT_btShow.Location = new System.Drawing.Point(591, 14);
            this.TDT_btShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDT_btShow.Name = "TDT_btShow";
            this.TDT_btShow.Size = new System.Drawing.Size(183, 37);
            this.TDT_btShow.TabIndex = 5;
            this.TDT_btShow.Text = "Thống kê";
            this.TDT_btShow.UseVisualStyleBackColor = false;
            this.TDT_btShow.Click += new System.EventHandler(this.TDT_btShow_Click);
            // 
            // TDT_dtpTo
            // 
            this.TDT_dtpTo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDT_dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDT_dtpTo.Location = new System.Drawing.Point(309, 16);
            this.TDT_dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDT_dtpTo.Name = "TDT_dtpTo";
            this.TDT_dtpTo.Size = new System.Drawing.Size(276, 34);
            this.TDT_dtpTo.TabIndex = 4;
            // 
            // TDT_dtpFrom
            // 
            this.TDT_dtpFrom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDT_dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDT_dtpFrom.Location = new System.Drawing.Point(12, 17);
            this.TDT_dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDT_dtpFrom.Name = "TDT_dtpFrom";
            this.TDT_dtpFrom.Size = new System.Drawing.Size(279, 34);
            this.TDT_dtpFrom.TabIndex = 3;
            // 
            // TDT_dgvStatistics
            // 
            this.TDT_dgvStatistics.AllowUserToAddRows = false;
            this.TDT_dgvStatistics.AllowUserToDeleteRows = false;
            this.TDT_dgvStatistics.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TDT_dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TDT_dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDT_dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNv,
            this.TenNv,
            this.TongTien});
            this.TDT_dgvStatistics.Location = new System.Drawing.Point(12, 68);
            this.TDT_dgvStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDT_dgvStatistics.Name = "TDT_dgvStatistics";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TDT_dgvStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TDT_dgvStatistics.RowHeadersWidth = 51;
            this.TDT_dgvStatistics.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDT_dgvStatistics.RowTemplate.Height = 24;
            this.TDT_dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TDT_dgvStatistics.Size = new System.Drawing.Size(762, 371);
            this.TDT_dgvStatistics.TabIndex = 6;
            // 
            // MaNv
            // 
            this.MaNv.DataPropertyName = "MaNv";
            this.MaNv.HeaderText = "Mã NV";
            this.MaNv.MinimumWidth = 6;
            this.MaNv.Name = "MaNv";
            this.MaNv.Width = 125;
            // 
            // TenNv
            // 
            this.TenNv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNv.DataPropertyName = "TenNv";
            this.TenNv.HeaderText = "Tên nhân viên";
            this.TenNv.MinimumWidth = 6;
            this.TenNv.Name = "TenNv";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // fDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TDT_dgvStatistics);
            this.Controls.Add(this.TDT_btShow);
            this.Controls.Add(this.TDT_dtpTo);
            this.Controls.Add(this.TDT_dtpFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDoanhThu";
            this.Text = "fDoanhThu";
            this.Load += new System.EventHandler(this.fDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDT_dgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TDT_btShow;
        private System.Windows.Forms.DateTimePicker TDT_dtpTo;
        private System.Windows.Forms.DateTimePicker TDT_dtpFrom;
        private System.Windows.Forms.DataGridView TDT_dgvStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}