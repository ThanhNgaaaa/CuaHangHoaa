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
    public partial class Cập_nhật_giá : Form
    {   
        SqlConnection connection;
        void HienThi()
        {
            string sqlSelect = "select MaLoai, MaHoa, TenHoa, GiaGoc, GiaBan from Hoa ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dtgv_CapNhat.DataSource = table;
        }
        public Cập_nhật_giá()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //private void btn_Click(object sender, EventArgs e)
        //{
        //    String sqlTimKiem = "Select * from Hoa where MaHoa = @MaHoa ";
        //    SqlCommand command = new SqlCommand(sqlTimKiem, connection);
        //    command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
        //    command.ExecuteNonQuery();
        //    SqlDataReader dr = command.ExecuteReader();
        //    DataTable table = new DataTable(sqlTimKiem);
        //    table.Load(dr);
        //    dtgv_CapNhat.DataSource = table;

        //}
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cập_nhật_giá_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select MaLoai, MaHoa, TenHoa, GiaGoc, GiaBan from Hoa where  @TenHoa =TenHoa or @MaLoai =MaLoai or @MaHoa = MaHoa ";
            SqlCommand command = new SqlCommand(sqlTimKiem, connection);
            command.Parameters.AddWithValue("MaLoai", cmbMaLoai.Text);
            command.Parameters.AddWithValue("MaHoa", txtTenLoai.Text);
            command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            DataTable table = new DataTable(sqlTimKiem);
            table.Load(dr);
            dtgv_CapNhat.DataSource = table;

        }
        private bool KiemTraThongTin()
        {
            if (cmbMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaLoai.Focus();
                return false;
            }
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Mã Hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return false;
            }
            if (txtTenHoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHoa.Focus();
                return false;
            }
            if (txtGiaMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaMoi.Focus();
                return false;
            }
            if (Convert.ToDouble(txtGiaMoi.Text) < 0 )
            {
                MessageBox.Show("Vui lòng nhập giá lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaMoi.Focus();
                txtGiaMoi.SelectAll();
                return false;
            }
            return true;
        }

        private void dtgv_CapNhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_CapNhat.Rows[e.RowIndex];
            cmbMaLoai.Text = Convert.ToString(row.Cells["MaLoai"].Value);
            txtTenLoai.Text = Convert.ToString(row.Cells["MaHoa"].Value);
            txtTenHoa.Text = Convert.ToString(row.Cells["TenHoa"].Value);
            txtGiaBan.Text = Convert.ToString(row.Cells["GiaBan"].Value);
        }

        private void txtGiaMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {

                    String sqlCapNhatGia = "Update Hoa set GiaBan=@GiaMoi  where @MaHoa = MaHoa";
                    SqlCommand command = new SqlCommand(sqlCapNhatGia, connection);
                    command.Parameters.AddWithValue("MaHoa", txtTenLoai.Text);
                    command.Parameters.AddWithValue("GiaMoi", txtGiaMoi.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
