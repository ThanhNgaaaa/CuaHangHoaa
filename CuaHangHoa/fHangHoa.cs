using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CuaHangHoa
{
    public partial class fHangHoa : Form
    {
       
        SqlConnection connection;

        public static SqlConnection Connection { get; private set; }

        public fHangHoa()
        {
            InitializeComponent();
         
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHoa.ReadOnly = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHangHoa.Rows[e.RowIndex];
            txtMaHoa.Text = Convert.ToString(row.Cells["MaHoa"].Value);
            txtTenHoa.Text = Convert.ToString(row.Cells["TenHoa"].Value);
            txtGiaGoc.Text = Convert.ToString(row.Cells["GiaGoc"].Value);
            txtGiaBan.Text = Convert.ToString(row.Cells["GiaGoc"].Value);
            txtSoLuongTon.Text = Convert.ToString(row.Cells["SoLuongTon"].Value);
            cbMaLoai.Text = Convert.ToString(row.Cells["MaLoai"].Value);

        }
        
        private void fHangHoa_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSelect = "select *from Hoa ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvHangHoa.DataSource = table;
        }
        private void fHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();   
        }
        
        private bool ThongTinHangHoa()
        {
            {
                if (txtMaHoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHoa.Focus();
                    return false;
                }
                if (txtTenHoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenHoa.Focus();
                    return false;
                }
                if (txtGiaGoc.Text =="")
                {
                    MessageBox.Show("Vui lòng nhập giá gốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiaGoc.Focus();
                    return false;
                }
                if (txtGiaBan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiaBan.Focus();
                    return false;
                }
                if (txtSoLuongTon.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongTon.Focus();
                    return false;
                }
                if (cbMaLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaLoai.Focus();
                    return false;
                }
                return true;
            }
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                String sqlThem = "INSERT INTO Hoa VALUES (@MaHoa,@TenHoa ,@GiaGoc,@GiaBan,@SoLuongTon,@MaLoai)";
                SqlCommand command = new SqlCommand(sqlThem, connection);
                command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
                command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
                command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
                command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
                command.Parameters.AddWithValue("MaLoai ", cbMaLoai.Text);
                command.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("BẠN ĐÃ THÊM HOA THÀNH CÔNG ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                string SqlEdit = "update Hoa set TenHoa = @TenHoa ,GiaGoc = @GiaGoc, " +
                "GiaBan = @GiaBan,SoLuongTon = @SoLuongTon,@MaLoai = @MaLoai where MaHoa = @MaHoa  ";
                SqlCommand command = new SqlCommand(SqlEdit, connection);
                command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
                command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
                command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
                command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
                command.Parameters.AddWithValue("MaLoai", cbMaLoai.Text);
                command.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                string SqlXoa = "DELETE FROM Hoa where MaHoa = @MaHoa";
                SqlCommand command = new SqlCommand(SqlXoa, connection);
                command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
                command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
                command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
                command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
                command.Parameters.AddWithValue("MaLoai", cbMaLoai.Text);
                command.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaGoc_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
