using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace CuaHangHoa
{
    public partial class Thông_tin_tài_khoản : Form
    {
        SqlConnection connection;
        public Thông_tin_tài_khoản()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Thông_tin_tài_khoản_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sqlCapNhatMK = " Select count(*) from NhanVien where TenTaiKhoan = '"+txtTenDangNhap.Text+"' and MatKhau = '" + txtMatKhau.Text +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlCapNhatMK, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProviderCapNhatMK.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(txtMKmoi.Text == txtNhapLaiMatkhau.Text)
                {
                    if (txtMKmoi.Text.Length > 0)
                    {
                        string sqlCapNhatMKmoi = "update NhanVien set MatKhau ='" + txtMKmoi.Text + "' where TenTaiKhoan ='"+ txtTenDangNhap.Text + "' and MatKhau ='" + txtMatKhau.Text + "'";
                        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCapNhatMKmoi, connection);
                        DataTable dt1 = new DataTable();
                        sqlDataAdapter1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu dài hơn 6 kí tự ");
                    }
                }
                else
                {
                    errorProviderCapNhatMK.SetError(txtMKmoi, "Bạn chưa điền mật khẩu!");
                    errorProviderCapNhatMK.SetError(txtNhapLaiMatkhau, "Mật khẩu nhập lại không đúng rồi!");
                }
            }
            else
            {
                errorProviderCapNhatMK.SetError(txtTenDangNhap, "Tên đăng nhập không đúng!");
                errorProviderCapNhatMK.SetError(txtMatKhau, "Mật khẩu không đúng!");
            }

        }
    }
}
