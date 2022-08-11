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
        private bool KiemTraThongTin()
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return false;
            }
            if (txtMKmoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKmoi.Focus();
                return false;
            }
            if (txtNhapLaiMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMatkhau.Focus();
                return false;
            }           
            return true;
        }
        private void Thông_tin_tài_khoản_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();

            txtTenDangNhap.Text = fDangnhap.TenTaiKhoan;
            txtTenDangNhap.ReadOnly = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sqlCapNhatMK = " Select count(*) from NhanVien where TenTaiKhoan = '"+txtTenDangNhap.Text+"' and MatKhau = '" + txtMatKhau.Text +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlCapNhatMK, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProviderCapNhatMK.Clear();
            if (dt.Rows[0][0].ToString() == "1" && KiemTraThongTin())
            {
                if(txtMKmoi.Text == txtNhapLaiMatkhau.Text)
                {
                    if (txtMKmoi.Text.Length > 5 && txtMKmoi.Text.Length <20)
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
                        MessageBox.Show("Vui lòng nhập mật khẩu từ 6 đến 20 ký tự. Quý khách vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtMKmoi.Text = "";
                        txtNhapLaiMatkhau.Text = "";
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
                errorProviderCapNhatMK.SetError(txtMatKhau, "Mật khẩu không đúng!");
            }

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT KHỎI CHỨC NĂNG NÀY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
