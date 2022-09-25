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
            string sqlSelect = "select MaHoa as[Mã Hoa],TenHoa as[Tên Hoa],GiaGoc as[Giá Gốc],GiaBan as [Giá Bán],SoLuongTon as[Số Lượng Tồn],TenLoai as[Tên Loại] from Hoa, LoaiHoa where Hoa.MaLoai = LoaiHoa.MaLoai ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvHangHoa.DataSource = table;
            dgvHangHoa.Columns["Tên hoa"].Width = 150;
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
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            txtMaHoa.ReadOnly = false;
            txtMaHoa.Text = "";
            txtTenHoa.Text = "";
            txtGiaGoc.Text = "";
            txtGiaBan.Text = "";
            txtSoLuongTon.Text = "";

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
                btnThoat.Enabled = false;
                btnThem.Enabled = false;    
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
            }

        }
        private void Reset()
        {
            txtGiaBan.Text = "";
            txtMaHoa.Text = "";
            txtSoLuongTon.Text = "";
            txtTenHoa.Text = "";
            txtGiaGoc.Text = "";
            cbLoai.Text = "";
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
                Reset();
            }
            btnThem.Enabled=false;
            btnSua.Enabled=false;
            btnHuy.Enabled=true;
            btnThoat.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT KHỎI CHỨC NĂNG NÀY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
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
            txtMaHoa.Text = Convert.ToString(row.Cells["Mã Hoa"].Value);
            txtTenHoa.Text = Convert.ToString(row.Cells["Tên Hoa"].Value);
            txtGiaGoc.Text = Convert.ToString(row.Cells["Giá Bán"].Value);
            txtGiaBan.Text = Convert.ToString(row.Cells["Giá Gốc"].Value);
            txtSoLuongTon.Text = Convert.ToString(row.Cells["Số Lượng Tồn"].Value);
            cbLoai.Text = Convert.ToString(row.Cells["Tên Loại"].Value);

        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
