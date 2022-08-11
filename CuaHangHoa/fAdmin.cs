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
        }


        private void HienThi()
        {
            string sqlSelect = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvnhanvien.DataSource = table;

            if(table.Rows.Count > 0)
            {
                dgvnhanvien.Rows[0].Selected = true;
            }

            isThem = false;
            AnHienControl();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Thêm dữ liệu
                if (isThem)
                {
                    if (txtManv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên");
                        txtManv.Focus();
                        return;
                    }
                    // Kiem tra mã nhân viên có bị trùng không
                    String sqlSelect = "Select * From NhanVien Where MaNv = @MaNv";
                    SqlCommand commandSelect = new SqlCommand(sqlSelect, connection);
                    commandSelect.Parameters.AddWithValue("MaNv", txtManv.Text.Trim());
                    commandSelect.ExecuteNonQuery();
                    SqlDataReader dr = commandSelect.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(dr);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã nhân viên " + txtManv.Text + " đã tồn tại. Vui lòng nhập lại");
                        txtManv.Focus();
                        return;
                    }   
                    
                    if (KiemDuLieu())
                    {
                        String sqlThem = "INSERT INTO NhanVien VALUES (@MaNv, @TenNV, @SDT, @TenTaiKhoan, @MatKhau, @LoaiTaiKhoan)";
                        SqlCommand command = new SqlCommand(sqlThem, connection);
                        command.Parameters.AddWithValue("MaNv", txtManv.Text);
                        command.Parameters.AddWithValue("TenNV", txttennv.Text);
                        command.Parameters.AddWithValue("SDT", txtsdt.Text);
                        command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                        command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                        command.Parameters.AddWithValue("LoaiTaiKhoan ", cbbloai.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("BẠN ĐÃ THÊM THÀNH CÔNG ", "THÔNG BÁO ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HienThi();
                    }
                }
                else // Cập nhật dữ liệu
                {
                    if (KiemDuLieu())
                    {
                        string SqlEdit = @"
UPDATE NhanVien 
SET LoaiTaiKhoan = @LoaiTaiKhoan,
    TenNV = @TenNV,
    SDT = @SDT,
    TenTaiKhoan = @TenTaiKhoan,
    @MatKhau = @MatKhau 
WHERE MaNv = @MaNv";
                        SqlCommand command = new SqlCommand(SqlEdit, connection);
                        command.Parameters.AddWithValue("MaNv", txtManv.Text);
                        command.Parameters.AddWithValue("TenNV", txttennv.Text);
                        command.Parameters.AddWithValue("SDT", txtsdt.Text);
                        command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                        command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                        command.Parameters.AddWithValue("LoaiTaiKhoan ", cbbloai.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);
                        HienThi();
                    }
                }
            }
            catch
            {
                //LÕi CHƯA CHẠy ĐƯỢc 
            }
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
                MessageBox.Show("BẠN ĐÃ xoá THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);
                HienThi();
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
            DialogResult = MessageBox.Show("BẠN CÓ MUỐN THOÁT HAY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();

            }
            else
                Focus();
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

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}
