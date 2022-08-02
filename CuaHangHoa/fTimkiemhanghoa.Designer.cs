namespace CuaHangHoa
{
    partial class Tìm_kiếm_hàng_hóa
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã hoa : ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(240, 150);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 39);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoa.Location = new System.Drawing.Point(154, 72);
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(242, 34);
            this.txtMaHoa.TabIndex = 2;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(2, 258);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(733, 293);
            this.dgvTimKiem.TabIndex = 1;
            
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.label3);
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txtMaHoa);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiem.Location = new System.Drawing.Point(12, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(713, 240);
            this.gbTimKiem.TabIndex = 6;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm hàng hóa";
            // 
            // Tìm_kiếm_hàng_hóa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 556);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.dgvTimKiem);
            this.Name = "Tìm_kiếm_hàng_hóa";
            this.Text = "Tìm_kiếm_hàng_hóa";
            this.Load += new System.EventHandler(this.Tìm_kiếm_hàng_hóa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.GroupBox gbTimKiem;
    }
}