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
        public static string LOAITK_USER ;
        public static string MA_USER ;
        public static string TenTaiKhoan;
        public static string SDT_USER;
        public static string UserName = "";
        public fDangnhap()
        {
            InitializeComponent();
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

            return true;
        }
        private void Reset()
        {
            txttenTk.Text = "";
            txtPassWord.Text = "";
        }
        private string getLoaiTK(string username, string pass)
        {
            string id = "" ;
            try
            {
                if (KiemTraThongTin()) { 

                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenTaiKhoan ='" + username + "' and MatKhau='" + pass + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = dr["MaLoai"].ToString();
                        }                
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }
        private string getMaNV(string username, string pass)
        {
            string MaNV = "";
            try
            {
                if (KiemTraThongTin())
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenTaiKhoan ='" + username + "' and MatKhau='" + pass + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            MaNV = dr["MaNv"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                connection.Close();
            }
            return MaNV;
        }
        private string getSDT(string username, string pass)
        {
            string SDT = "";
            try
            {
                if (KiemTraThongTin())
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenTaiKhoan ='" + username + "' and MatKhau='" + pass + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            SDT = dr["SDT"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                connection.Close();
            }
            return SDT;
        }

        private string getTenTaiKhoan(string username, string pass)
        {
            string TenTK = "";
            try
            {
                if (KiemTraThongTin())
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenTaiKhoan ='" + username + "' and MatKhau='" + pass + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            TenTK = dr["TenTaiKhoan"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                connection.Close();
            }
            return TenTK;
        }
        private string getTenNV(string username, string pass)
        {
            string TenNV = "";
            try
            {
                if (KiemTraThongTin())
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenTaiKhoan ='" + username + "' and MatKhau='" + pass + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            TenNV = dr["TenNv"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                connection.Close();
            }
            return TenNV;
        }
        
        private void fDangnhap_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LOAITK_USER = getLoaiTK(txttenTk.Text, txtPassWord.Text);

            if (LOAITK_USER != "")
            {
                Variables.TenNV = getTenNV(txttenTk.Text, txtPassWord.Text);
                MA_USER = getMaNV(txttenTk.Text, txtPassWord.Text);
                SDT_USER = getSDT(txttenTk.Text, txtPassWord.Text);
                TenTaiKhoan = getTenTaiKhoan(txttenTk.Text, txtPassWord.Text);
                FlowerManager f = new FlowerManager();
                this.Hide();
                f.ShowDialog();
                this.Reset();
                this.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !!");
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN THOÁT CHƯƠNG TRÌNH ?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAnMK_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
            {
                picHienMK.BringToFront();
                txtPassWord.PasswordChar = '\0';
            }
        }

        private void picHienMK_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '\0')
            {
                picAnMK.BringToFront();
                txtPassWord.PasswordChar = '*';
            }
        }
    }
}
