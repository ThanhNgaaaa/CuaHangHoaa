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
            this.dgvTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(2, 258);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(851, 347);
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
            this.gbTimKiem.Location = new System.Drawing.Point(12, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(830, 240);
            this.gbTimKiem.TabIndex = 6;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm hàng hóa";
            // 
            // txtTentim
            // 
            this.txtTentim.Location = new System.Drawing.Point(645, 124);
            this.txtTentim.Name = "txtTentim";
            this.txtTentim.Size = new System.Drawing.Size(179, 30);
            this.txtTentim.TabIndex = 4;
            this.txtTentim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTentim_KeyDown);
            // 
            // ckTimtheoten
            // 
            this.ckTimtheoten.AutoSize = true;
            this.ckTimtheoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimtheoten.Location = new System.Drawing.Point(454, 124);
            this.ckTimtheoten.Name = "ckTimtheoten";
            this.ckTimtheoten.Size = new System.Drawing.Size(181, 29);
            this.ckTimtheoten.TabIndex = 3;
            this.ckTimtheoten.Text = "Tìm theo tên : ";
            this.ckTimtheoten.UseVisualStyleBackColor = true;
            this.ckTimtheoten.CheckedChanged += new System.EventHandler(this.ckTimtheoten_CheckedChanged);
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(231, 124);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(198, 31);
            this.cbLoai.TabIndex = 2;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // ckTimtheoloai
            // 
            this.ckTimtheoloai.AutoSize = true;
            this.ckTimtheoloai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimtheoloai.Location = new System.Drawing.Point(37, 125);
            this.ckTimtheoloai.Name = "ckTimtheoloai";
            this.ckTimtheoloai.Size = new System.Drawing.Size(184, 29);
            this.ckTimtheoloai.TabIndex = 1;
            this.ckTimtheoloai.Text = "Tìm theo loại : ";
            this.ckTimtheoloai.UseVisualStyleBackColor = true;
            this.ckTimtheoloai.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckTimkiem
            // 
            this.ckTimkiem.AutoSize = true;
            this.ckTimkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTimkiem.Location = new System.Drawing.Point(37, 59);
            this.ckTimkiem.Name = "ckTimkiem";
            this.ckTimkiem.Size = new System.Drawing.Size(176, 29);
            this.ckTimkiem.TabIndex = 0;
            this.ckTimkiem.Text = "Tìm kiếm hoa ";
            this.ckTimkiem.UseVisualStyleBackColor = true;
            this.ckTimkiem.CheckedChanged += new System.EventHandler(this.ckTimkiemhoa_CheckedChanged);
            // 
            // fTimkiemhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(854, 617);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.dgvTimKiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTimkiemhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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