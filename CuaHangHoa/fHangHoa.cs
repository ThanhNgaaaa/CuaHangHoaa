using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        }

        private void fHangHoa_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
            loadcombo();
        }
        public void HienThi()
        {
            string sqlSelect = "select MaHoa,TenHoa,GiaGoc,GiaBan,SoLuongTon,TenLoai from Hoa, LoaiHoa where Hoa.MaLoai = LoaiHoa.MaLoai ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvHangHoa.DataSource = table;
        }
        private void loadcombo()
        {
            string sqlSelect = "select *from LoaiHoa";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cbLoai.DataSource = table;
            cbLoai.DisplayMember = table.Columns["TenLoai"].ToString();
            cbLoai.ValueMember = table.Columns["MaLoai"].ToString();
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
                if (txtGiaGoc.Text == "")
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
                if (cbLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbLoai.Focus();
                    return false;
                }
                return true;
            }
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                try
                {
                    String sqlThem = "INSERT INTO Hoa VALUES (@MaHoa,@TenHoa ,@GiaGoc,@GiaBan,@SoLuongTon,@MaLoai)";
                    SqlCommand command = new SqlCommand(sqlThem, connection);
                    command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                    command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
                    command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
                    command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
                    command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
                    command.Parameters.AddWithValue("MaLoai", cbLoai.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("BẠN ĐÃ THÊM HOA THÀNH CÔNG ", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("THÊM THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                try
                {
                    string SqlEdit = "update Hoa set TenHoa = @TenHoa ,GiaGoc = @GiaGoc, GiaBan = @GiaBan,SoLuongTon = @SoLuongTon, MaLoai = @MaLoai Where MaHoa = @MaHoa ";
                    SqlCommand command = new SqlCommand(SqlEdit, connection);
                    command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                    command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
                    command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
                    command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
                    command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
                    command.Parameters.AddWithValue("MaLoai", cbLoai.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("SỬA THẤT BẠI","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
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
                command.Parameters.AddWithValue("MaLoai", cbLoai.Text);
                command.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();

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

        private void txtGiaGoc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaHoa.ReadOnly = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHangHoa.Rows[e.RowIndex];
            txtMaHoa.Text = Convert.ToString(row.Cells["MaHoa"].Value);
            txtTenHoa.Text = Convert.ToString(row.Cells["TenHoa"].Value);
            txtGiaGoc.Text = Convert.ToString(row.Cells["GiaGoc"].Value);
            txtGiaBan.Text = Convert.ToString(row.Cells["GiaGoc"].Value);
            txtSoLuongTon.Text = Convert.ToString(row.Cells["SoLuongTon"].Value);
            cbLoai.Text = Convert.ToString(row.Cells["TenLoai"].Value);

        }
    }
}
