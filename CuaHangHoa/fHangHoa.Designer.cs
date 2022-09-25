namespace CuaHangHoa
{
    partial class fHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHangHoa));
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 344);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(1064, 310);
            this.dgvHangHoa.TabIndex = 1;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            this.dgvHangHoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHangHoa_CellMouseClick);
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.MistyRose;
            this.grb1.Controls.Add(this.btnHuy);
            this.grb1.Controls.Add(this.btnThoat);
            this.grb1.Controls.Add(this.btnXoa);
            this.grb1.Controls.Add(this.btnSua);
            this.grb1.Controls.Add(this.btnThem);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.cbLoai);
            this.grb1.Controls.Add(this.txtGiaGoc);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.txtSoLuongTon);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.txtGiaBan);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.txtTenHoa);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtMaHoa);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(1059, 327);
            this.grb1.TabIndex = 2;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin hàng hóa ";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::CuaHangHoa.Properties.Resources.Graphicloads_100_Flat_Close3;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(657, 248);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 54);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::CuaHangHoa.Properties.Resources.dong3;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(866, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 54);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::CuaHangHoa.Properties.Resources.Button_Delete_icon__1_1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(239, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 54);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::CuaHangHoa.Properties.Resources.Etherbrian_Webuosities_Fix_it1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(446, 248);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 54);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::CuaHangHoa.Properties.Resources.them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(40, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 54);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại hoa : ";
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(717, 198);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(208, 33);
            this.cbLoai.TabIndex = 10;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.Location = new System.Drawing.Point(162, 201);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(263, 34);
            this.txtGiaGoc.TabIndex = 9;
            this.txtGiaGoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaGoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá gốc : ";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(717, 121);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(208, 34);
            this.txtSoLuongTon.TabIndex = 7;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng tồn : ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(717, 37);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(208, 34);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán : ";
            // 
            // txtTenHoa
            // 
            this.txtTenHoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHoa.Location = new System.Drawing.Point(162, 115);
            this.txtTenHoa.Name = "txtTenHoa";
            this.txtTenHoa.Size = new System.Drawing.Size(263, 34);
            this.txtTenHoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hoa : ";
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoa.Location = new System.Drawing.Point(162, 46);
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(263, 34);
            this.txtMaHoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoa : ";
            // 
            // fHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.dgvHangHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHangHoa_FormClosing);
            this.Load += new System.EventHandler(this.fHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtGiaGoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
    }
}