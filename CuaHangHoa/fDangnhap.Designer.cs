namespace CuaHangHoa
{
    partial class fDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbPassWord = new System.Windows.Forms.Panel();
            this.picAnMK = new System.Windows.Forms.PictureBox();
            this.picHienMK = new System.Windows.Forms.PictureBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.tnbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttenTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.txbPassWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHienMK)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-6, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 246);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(380, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(187, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Controls.Add(this.picAnMK);
            this.txbPassWord.Controls.Add(this.picHienMK);
            this.txbPassWord.Controls.Add(this.txtPassWord);
            this.txbPassWord.Controls.Add(this.tnbUserName);
            this.txbPassWord.Location = new System.Drawing.Point(3, 82);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(583, 65);
            this.txbPassWord.TabIndex = 1;
            // 
            // picAnMK
            // 
            this.picAnMK.Image = ((System.Drawing.Image)(resources.GetObject("picAnMK.Image")));
            this.picAnMK.Location = new System.Drawing.Point(528, 20);
            this.picAnMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAnMK.Name = "picAnMK";
            this.picAnMK.Size = new System.Drawing.Size(54, 26);
            this.picAnMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAnMK.TabIndex = 4;
            this.picAnMK.TabStop = false;
            this.picAnMK.Click += new System.EventHandler(this.picAnMK_Click);
            // 
            // picHienMK
            // 
            this.picHienMK.Image = ((System.Drawing.Image)(resources.GetObject("picHienMK.Image")));
            this.picHienMK.Location = new System.Drawing.Point(526, 20);
            this.picHienMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHienMK.Name = "picHienMK";
            this.picHienMK.Size = new System.Drawing.Size(54, 26);
            this.picHienMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHienMK.TabIndex = 3;
            this.picHienMK.TabStop = false;
            this.picHienMK.Click += new System.EventHandler(this.picHienMK_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(244, 14);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(276, 34);
            this.txtPassWord.TabIndex = 2;
            // 
            // tnbUserName
            // 
            this.tnbUserName.AutoSize = true;
            this.tnbUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnbUserName.Location = new System.Drawing.Point(31, 14);
            this.tnbUserName.Name = "tnbUserName";
            this.tnbUserName.Size = new System.Drawing.Size(137, 25);
            this.tnbUserName.TabIndex = 0;
            this.tnbUserName.Text = "Mật Khẩu : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttenTk);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 65);
            this.panel2.TabIndex = 0;
            // 
            // txttenTk
            // 
            this.txttenTk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenTk.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttenTk.Location = new System.Drawing.Point(244, 14);
            this.txttenTk.Name = "txttenTk";
            this.txttenTk.Size = new System.Drawing.Size(276, 34);
            this.txttenTk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to BFlower";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fDangnhap
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(593, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "fDangnhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.fDangnhap_Load);
            this.panel1.ResumeLayout(false);
            this.txbPassWord.ResumeLayout(false);
            this.txbPassWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHienMK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel txbPassWord;
        private System.Windows.Forms.Label tnbUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txttenTk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picAnMK;
        private System.Windows.Forms.PictureBox picHienMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

