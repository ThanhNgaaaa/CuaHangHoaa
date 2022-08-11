namespace CuaHangHoa
{
    partial class fTimkiemhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTimkiemhanghoa));
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTentim = new System.Windows.Forms.TextBox();
            this.ckTimtheoten = new System.Windows.Forms.CheckBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.ckTimtheoloai = new System.Windows.Forms.CheckBox();
            this.ckTimkiem = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(2, 322);
            this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(957, 434);
            this.dgvTimKiem.TabIndex = 1;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.txtTentim);
            this.gbTimKiem.Controls.Add(this.ckTimtheoten);
            this.gbTimKiem.Controls.Add(this.cbLoai);
            this.gbTimKiem.Controls.Add(this.ckTimtheoloai);
            this.gbTimKiem.Controls.Add(this.ckTimkiem);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiem.Location = new System.Drawing.Point(14, 15);
            this.gbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTimKiem.Size = new System.Drawing.Size(934, 300);
            this.gbTimKiem.TabIndex = 6;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm hàng hóa";
            // 
            // txtTentim
            // 
            this.txtTentim.Location = new System.Drawing.Point(726, 155);
            this.txtTentim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentim.Name = "txtTentim";
            this.txtTentim.Size = new System.Drawing.Size(201, 35);
            this.txtTentim.TabIndex = 4;
            this.txtTentim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTentim_KeyDown);
            // 
            // ckTimtheoten
            // 
            this.ckTimtheoten.AutoSize = true;
            this.ckTimtheoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimtheoten.Location = new System.Drawing.Point(511, 155);
            this.ckTimtheoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTimtheoten.Name = "ckTimtheoten";
            this.ckTimtheoten.Size = new System.Drawing.Size(213, 36);
            this.ckTimtheoten.TabIndex = 3;
            this.ckTimtheoten.Text = "Tìm theo tên : ";
            this.ckTimtheoten.UseVisualStyleBackColor = true;
            this.ckTimtheoten.CheckedChanged += new System.EventHandler(this.ckTimtheoten_CheckedChanged);
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(260, 155);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(222, 34);
            this.cbLoai.TabIndex = 2;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // ckTimtheoloai
            // 
            this.ckTimtheoloai.AutoSize = true;
            this.ckTimtheoloai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimtheoloai.Location = new System.Drawing.Point(42, 156);
            this.ckTimtheoloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTimtheoloai.Name = "ckTimtheoloai";
            this.ckTimtheoloai.Size = new System.Drawing.Size(220, 36);
            this.ckTimtheoloai.TabIndex = 1;
            this.ckTimtheoloai.Text = "Tìm theo loại : ";
            this.ckTimtheoloai.UseVisualStyleBackColor = true;
            this.ckTimtheoloai.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckTimkiem
            // 
            this.ckTimkiem.AutoSize = true;
            this.ckTimkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimkiem.Location = new System.Drawing.Point(42, 74);
            this.ckTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTimkiem.Name = "ckTimkiem";
            this.ckTimkiem.Size = new System.Drawing.Size(210, 36);
            this.ckTimkiem.TabIndex = 0;
            this.ckTimkiem.Text = "Tìm kiếm hoa ";
            this.ckTimkiem.UseVisualStyleBackColor = true;
            this.ckTimkiem.CheckedChanged += new System.EventHandler(this.ckTimkiemhoa_CheckedChanged);
            // 
            // fTimkiemhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(961, 771);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.dgvTimKiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTimkiemhanghoa";
            this.Text = "Tìm_kiếm_hàng_hóa";
            this.Load += new System.EventHandler(this.Tìm_kiếm_hàng_hóa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.TextBox txtTentim;
        private System.Windows.Forms.CheckBox ckTimtheoten;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.CheckBox ckTimtheoloai;
        private System.Windows.Forms.CheckBox ckTimkiem;
    }
}