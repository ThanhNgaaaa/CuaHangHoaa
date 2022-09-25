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
    public partial class fAdmin : Form
    {

        SqlConnection connection;
        public static SqlConnection Connection { get; private set; }
        private bool isThem = false; // true: thêm, false: cập nhật

        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
            loadcombo();
        }
        private void loadcombo()
        {
            string sqlSelect = "select *from LoaiTaiKhoan";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cbbloai.DataSource = table;
            cbbloai.DisplayMember = table.Columns["TenLoai"].ToString();
            cbbloai.ValueMember = table.Columns["MaLoai"].ToString();
        }

        private void HienThi()
        {
            string sqlSelect = " select MaNv as [Mã Nhân Viên], TenNv as [Tên Nhân Viên], SDT , TenTaiKhoan as [Tên Tài Khoản], MatKhau as [Mật Khẩu], TenLoai as [Tên Loại]  from NhanVien,LoaiTaiKhoan where NhanVien.MaLoai = LoaiTaiKhoan.MaLoai";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvnhanvien.DataSource = table;

            if (table.Rows.Count > 0)
            {
                dgvnhanvien.Rows[0].Selected = true;
            }

            isThem = false;
            AnHienControl();
            dgvnhanvien.Columns["Tên Nhân Viên"].Width = 150;
        }
        private void TimKiem()
        {
            if (txttimkiemten.Text.Trim().Length > 0)
            {
                // N là tìm kiếm ký tự có dấu
                // % là tìm kiếm gần đúng
                String sqlTimKiem = "Select * From NhanVien Where TenNv LIKE N'%' + @TenNv + '%'";
                SqlCommand command = new SqlCommand(sqlTimKiem, connection);
                command.Parameters.AddWithValue("TenNV", txttimkiemten.Text);
                command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();
                DataTable table = new DataTable(sqlTimKiem);
                table.Load(dr);
                dgvnhanvien.DataSource = table;

                if (table.Rows.Count > 0)
                {
                    dgvnhanvien.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("Không có nhân viên tên này");
                }  
                
                isThem = false;
                AnHienControl();
            }
            else // Hiển thị tất cả dữ liệu khi tìm kiếm trống
            {
                HienThi();
            }    
        }

        private void HienThiNhanVien(int SoDong)
        {
            txtManv.Text = dgvnhanvien.Rows[SoDong].Cells[0].Value.ToString();
            txttennv.Text = dgvnhanvien.Rows[SoDong].Cells[1].Value.ToString();
            txtsdt.Text = dgvnhanvien.Rows[SoDong].Cells[2].Value.ToString();
            txttentk.Text = dgvnhanvien.Rows[SoDong].Cells[3].Value.ToString();
            txtmk.Text = dgvnhanvien.Rows[SoDong].Cells[4].Value.ToString();
            cbbloai.Text = dgvnhanvien.Rows[SoDong].Cells[5].Value.ToString();
            dgvnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvnhanvien.Columns[2].HeaderText = "Số điện thoại";
            dgvnhanvien.Columns[3].HeaderText = "Tên tài khoản";
            dgvnhanvien.Columns[4].HeaderText = "Mật khẩu";
            dgvnhanvien.Columns[5].HeaderText = "Loại tài khoản";
          
        }

        private void AnHienControl()
        {
            // Khi them du lieu
            if (isThem)
            {
                txtManv.ReadOnly = false;
                btnthemm.Enabled = false;
                btnxoa.Enabled = false;
                btnHuy.Enabled = true;
                dgvnhanvien.Enabled = false;

                txtManv.Text = "";
                txttennv.Text = "";
                txtsdt.Text = "";
                txttentk.Text = "";
                txtmk.Text = "";
                cbbloai.Text = "";
                txtManv.Focus();
            }
            else // Khi cap nhat du lieu
            {
                txtManv.ReadOnly = true;
                btnthemm.Enabled = true;
                btnxoa.Enabled = true;
                btnHuy.Enabled = false;
                dgvnhanvien.Enabled = true;
            }
        }

        private bool KiemDuLieu()
        {
            if(txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                txttennv.Focus();
                return false;
            }
            if (txttentk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
                txttentk.Focus();
                return false;
            }
            return true;
        }

        private void btnthemm_Click(object sender, EventArgs e)
        {
            isThem = true;
            AnHienControl();
        }

       
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string SqlXoa = "DELETE FROM NhanVien where MaNv = @MaNv";
                SqlCommand command = new SqlCommand(SqlXoa, connection);
                command.Parameters.AddWithValue("MaNv", txtManv.Text);
                command.Parameters.AddWithValue("TenNV", txttennv.Text);
                command.Parameters.AddWithValue("SDT", txtsdt.Text);
                command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                command.Parameters.AddWithValue("LoaiTaiKhoan ", cbbloai.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);
                HienThi();
                Reset();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isThem = false;
            AnHienControl();
            HienThiNhanVien(dgvnhanvien.CurrentRow.Index);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT KHỎI CHỨC NĂNG NÀY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttimkiemten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiem();
            }
        }

        private void dgvnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            HienThiNhanVien(dgvnhanvien.CurrentRow.Index);
        }


        private void Reset()
        {
            txtManv.Text = "";
            txtmk.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txttentk.Text = "";
            cbbloai.Text = "";
        }
        private bool ThongTinHangHoa()
        {
            {

                if (txtManv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtManv.Focus();
                    return false;
                }
                if (txttennv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttennv.Focus();
                    return false;
                }
                if (txtsdt.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsdt.Focus();
                    return false;
                }
                if (txttentk.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttentk.Focus();
                    return false;
                }
                if (txtmk.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmk.Focus();
                    return false;
                }
                if (cbbloai.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbloai.Focus();
                    return false;
                }
                return true;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (ThongTinHangHoa())
            {
                try
                {
                    string SqlEdit = "update NhanVien set TenNv = @TenNv ,SDT = @SDT, TenTaiKhoan = @TenTaiKhoan,MatKhau = @MatKhau, MaLoai = @MaLoai Where MaNv = @MaNv ";
                    SqlCommand command = new SqlCommand(SqlEdit, connection);
                    command.Parameters.AddWithValue("MaNv", txtManv.Text);
                    command.Parameters.AddWithValue("TenNv", txttennv.Text);
                    command.Parameters.AddWithValue("SDT", txtsdt.Text);
                    command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                    command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                    command.Parameters.AddWithValue("MaLoai", cbbloai.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("SỬA THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnThoat.Enabled = false;
                btnthemm.Enabled = false;
                btnxoa.Enabled = false;
                btnHuy.Enabled = true;
            }
        }
    }
}
