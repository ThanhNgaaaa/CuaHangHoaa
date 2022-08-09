﻿namespace CuaHangHoa
{
    partial class FlowerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowerManager));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcThongTinAccount = new DevExpress.XtraEditors.GroupControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtChucVu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinAccount)).BeginInit();
            this.gcThongTinAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 38);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1375, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTaiKhoan,
            this.quảnLýToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.doanhthuToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1375, 38);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItemTaiKhoan
            // 
            this.toolStripMenuItemTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemThongTinTaiKhoan,
            this.toolStripMenuItemDangXuat});
            this.toolStripMenuItemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItemTaiKhoan.Name = "toolStripMenuItemTaiKhoan";
            this.toolStripMenuItemTaiKhoan.Size = new System.Drawing.Size(120, 34);
            this.toolStripMenuItemTaiKhoan.Text = "Tài khoản";
            // 
            // toolStripMenuItemThongTinTaiKhoan
            // 
            this.toolStripMenuItemThongTinTaiKhoan.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripMenuItemThongTinTaiKhoan.Name = "toolStripMenuItemThongTinTaiKhoan";
            this.toolStripMenuItemThongTinTaiKhoan.Size = new System.Drawing.Size(308, 38);
            this.toolStripMenuItemThongTinTaiKhoan.Text = "Thông tin tài khoản ";
            this.toolStripMenuItemThongTinTaiKhoan.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItemDangXuat
            // 
            this.toolStripMenuItemDangXuat.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripMenuItemDangXuat.Name = "toolStripMenuItemDangXuat";
            this.toolStripMenuItemDangXuat.Size = new System.Drawing.Size(308, 38);
            this.toolStripMenuItemDangXuat.Text = "Đăng xuất";
            this.toolStripMenuItemDangXuat.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem,
            this.tìmKiếmHàngHóaToolStripMenuItem,
            this.cậpNhậtGiáToolStripMenuItem,
            this.KhachHangtoolStripMenuItem2,
            this.hóaĐơnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // tìmKiếmHàngHóaToolStripMenuItem
            // 
            this.tìmKiếmHàngHóaToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.tìmKiếmHàngHóaToolStripMenuItem.Name = "tìmKiếmHàngHóaToolStripMenuItem";
            this.tìmKiếmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.tìmKiếmHàngHóaToolStripMenuItem.Text = "Tìm kiếm hàng hóa";
            this.tìmKiếmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHàngHóaToolStripMenuItem_Click);
            // 
            // cậpNhậtGiáToolStripMenuItem
            // 
            this.cậpNhậtGiáToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.cậpNhậtGiáToolStripMenuItem.Name = "cậpNhậtGiáToolStripMenuItem";
            this.cậpNhậtGiáToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.cậpNhậtGiáToolStripMenuItem.Text = "Cập nhật giá";
            this.cậpNhậtGiáToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtGiáToolStripMenuItem_Click);
            // 
            // KhachHangtoolStripMenuItem2
            // 
            this.KhachHangtoolStripMenuItem2.BackColor = System.Drawing.Color.MistyRose;
            this.KhachHangtoolStripMenuItem2.Name = "KhachHangtoolStripMenuItem2";
            this.KhachHangtoolStripMenuItem2.Size = new System.Drawing.Size(301, 38);
            this.KhachHangtoolStripMenuItem2.Text = "Khách hàng";
            this.KhachHangtoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // doanhthuToolStripMenuItem
            // 
            this.doanhthuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doanhthuToolStripMenuItem.Name = "doanhthuToolStripMenuItem";
            this.doanhthuToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.doanhthuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.doanhthuToolStripMenuItem.Click += new System.EventHandler(this.doanhthuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(850, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(272, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(812, 46);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "CHÀO  MỪNG  BẠN  ĐẾN  BFLOWER  SHOP";
            // 
            // gcThongTinAccount
            // 
            this.gcThongTinAccount.Appearance.BackColor = System.Drawing.Color.White;
            this.gcThongTinAccount.Appearance.Options.UseBackColor = true;
            this.gcThongTinAccount.ContentImage = ((System.Drawing.Image)(resources.GetObject("gcThongTinAccount.ContentImage")));
            this.gcThongTinAccount.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.gcThongTinAccount.Controls.Add(this.txtChucVu);
            this.gcThongTinAccount.Controls.Add(this.labelControl5);
            this.gcThongTinAccount.Controls.Add(this.txtSDT);
            this.gcThongTinAccount.Controls.Add(this.labelControl4);
            this.gcThongTinAccount.Controls.Add(this.txtTen);
            this.gcThongTinAccount.Controls.Add(this.labelControl3);
            this.gcThongTinAccount.Controls.Add(this.txtMa);
            this.gcThongTinAccount.Controls.Add(this.labelControl2);
            this.gcThongTinAccount.Location = new System.Drawing.Point(12, 193);
            this.gcThongTinAccount.Name = "gcThongTinAccount";
            this.gcThongTinAccount.Size = new System.Drawing.Size(568, 378);
            this.gcThongTinAccount.TabIndex = 5;
            this.gcThongTinAccount.Text = "Thông Tin Nhân Viên";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(235, 61);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Properties.Appearance.Options.UseBackColor = true;
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(330, 40);
            this.txtMa.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 33);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Nhân Viên :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(235, 131);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(330, 40);
            this.txtTen.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 33);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Họ Và Tên :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(235, 202);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Properties.Appearance.Options.UseBackColor = true;
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(330, 40);
            this.txtSDT.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 205);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(176, 33);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Số Điện Thoại :";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(235, 276);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtChucVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVu.Properties.Appearance.Options.UseBackColor = true;
            this.txtChucVu.Properties.Appearance.Options.UseFont = true;
            this.txtChucVu.Size = new System.Drawing.Size(330, 40);
            this.txtChucVu.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 279);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 33);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Chức Vụ :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.BackgroundImage")));
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1101, 38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 50D;
            this.pictureEdit1.Size = new System.Drawing.Size(179, 158);
            this.pictureEdit1.TabIndex = 6;
            // 
            // FlowerManager
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 711);
            this.Controls.Add(this.gcThongTinAccount);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FlowerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG HOA";
            this.Load += new System.EventHandler(this.FlowerManager_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinAccount)).EndInit();
            this.gcThongTinAccount.ResumeLayout(false);
            this.gcThongTinAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangtoolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem doanhthuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gcThongTinAccount;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}