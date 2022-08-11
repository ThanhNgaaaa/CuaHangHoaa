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
    public partial class fKhachHang : Form
    {
        SqlConnection connection;
        public fKhachHang()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            string sqlSelect = "select MaKh as[Mã Khách Hàng], TenKh as[Tên Khách Hàng], SDT as[Số điện thoại] from KhachHang ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dtgv_KhachHang.DataSource = table;
            dtgv_KhachHang.Columns["Mã Khách Hàng"].Width = 150;
            dtgv_KhachHang.Columns["Tên Khách Hàng"].Width = 150;
            dtgv_KhachHang.Columns["Số điện thoại"].Width = 150;

        }
        private void fKhachHang_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
        }
        private bool KiemTraThongTin()
        {
            if(txtMaKh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKh.Focus();
                return false;
            }
            if(txtTenKh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKh.Focus();
                return false;
            }
            if(txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return false;
            }
            return true;    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT KHỎI CHỨC NĂNG NÀY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        { try
            {
                if (KiemTraThongTin())
                {
                    string sqlThem = "insert into KhachHang values(@MaKH, @TenKH, @SDT)";
                    SqlCommand command = new SqlCommand(sqlThem, connection);
                    command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                    command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                    command.Parameters.AddWithValue("SDT", txtSdt.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }
            }
            catch
            {
                MessageBox.Show("THÊM BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            txtMaKh.ReadOnly = false;
            txtMaKh.Text = "";
            txtTenKh.Text = "";
            txtSdt.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try {
                if (KiemTraThongTin())
                {
                    string sqlSua = "Update KhachHang set MaKh = @MaKh, TenKh= @TenKh, SDT = @SDT where MaKh = @MaKh";
                    SqlCommand command = new SqlCommand(sqlSua, connection);
                    command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                    command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                    command.Parameters.AddWithValue("SDT", txtSdt.Text.Trim());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }
            }
            catch
            {
                MessageBox.Show("SỬA THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnThoat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                string sqlXoa = "Delete from KhachHang where @MaKh = MaKh";
                SqlCommand command = new SqlCommand(sqlXoa, connection);
                command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                command.Parameters.AddWithValue("SDT", txtSdt.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
            }
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
        }

        
        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMaKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_KhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaKh.ReadOnly = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_KhachHang.Rows[e.RowIndex];
            txtMaKh.Text = Convert.ToString(row.Cells["Mã Khách Hàng"].Value);
            txtTenKh.Text = Convert.ToString(row.Cells["Tên Khách Hàng"].Value);
            txtSdt.Text = Convert.ToString(row.Cells["Số điện thoại"].Value);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }
    }
}
