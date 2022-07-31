using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangHoa
{
    public partial class fDangnhap : Form
    {
        SqlConnection connection;
        public fDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool KiemTraThongTin()
        {
            if(txttenTk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản đừng để trống nhé !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenTk.Focus();
                return false;
            }
            if (txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đừng để trống nhé !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassWord.Focus();
                return false;
            }
            if (cmbLoaiTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản đừng để trống nhé !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLoaiTK.Focus();
                return false;
            }
            return true;
        }
        private void Reset()
        {
            txttenTk.Text = "";
            txtPassWord.Text = "";
            cmbLoaiTK.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
                string userName = txttenTk.Text;
                string passWord = txtPassWord.Text;
                if (KiemTraThongTin())
                {
                    string sqlLogin = " select * from NhanVien where TenTaiKhoan = '" + userName + "' and MatKhau = '" + passWord + "' and LoaiTaiKhoan ='" + loaiTK() +"'";
                    SqlDataAdapter da = new SqlDataAdapter(sqlLogin,connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >0)
                    {
                        FlowerManager f = new FlowerManager();
                        this.Hide();
                        f.ShowDialog();
                        this.Reset();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu hoặc loại tài khoản!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN THOÁT CHƯƠNG TRÌNH ?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void fDangnhap_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
        }

        private void cmbLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int loaiTK()
        {
            if(cmbLoaiTK.SelectedIndex == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
