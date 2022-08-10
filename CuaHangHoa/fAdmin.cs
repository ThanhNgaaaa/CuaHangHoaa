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

        private void btnthemm_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlThem = "INSERT INTO NhanVien VALUES (@MaNv,@TenNV ,@SDT,@TenTaiKhoan,@MatKhau,@LoaiTaiKhoan)";
                SqlCommand command = new SqlCommand(sqlThem, connection);
                command.Parameters.AddWithValue("MaNv", txtManv.Text);
                command.Parameters.AddWithValue("TenNV", txttennv.Text);
                command.Parameters.AddWithValue("SDT", txtsdt.Text);
                command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                command.Parameters.AddWithValue("LoaiTaiKhoan ", cbbloai.Text);
                command.ExecuteNonQuery();
                HienThi();
                DialogResult = MessageBox.Show("BẠN ĐÃ THÊM THÀNH CÔNG ", "THÔNG BÁO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("NHẬP THÔNG TIN ĐỂ THÊM","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            txtManv.ReadOnly = false;
            btntim.Enabled = false;
            txtManv.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txttentk.Text = "";
            txtmk.Text = "";
            
        }

        private void HienThi()
        {

            string sqlSelect = "select *from NhanVien ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvnhanvien.DataSource = table;
            //abc
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string SqlEdit = "update NhanVien set LoaiTaiKhoan = @LoaiTaiKhoan ,TenNV = @TenNV, " +
                "SDT = @SDT,TenTaiKhoan = @TenTaiKhoan,@MatKhau = @MatKhau where MaNv = @MaNv  ";
                SqlCommand command = new SqlCommand(SqlEdit, connection);
                command.Parameters.AddWithValue("MaNv", txtManv.Text);
                command.Parameters.AddWithValue("TenNV", txttennv.Text);
                command.Parameters.AddWithValue("SDT", txtsdt.Text);
                command.Parameters.AddWithValue("TenTaiKhoan", txttentk.Text);
                command.Parameters.AddWithValue("MatKhau", txtmk.Text);
                command.Parameters.AddWithValue("LoaiTaiKhoan ", cbbloai.Text);
                command.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);
            }
            catch
            {
                //LÕi CHƯA CHẠy ĐƯỢc 
            }
            btnThoat.Enabled = false;
            btnthemm.Enabled = false;
            btnxoa.Enabled = false;
            btnHuy.Enabled = true;
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
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
            HienThi();
            MessageBox.Show("BẠN ĐÃ xoá THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);
            btnthemm.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select *from NhanVien where TenNv = @TenNv ";
            SqlCommand command = new SqlCommand(sqlTimKiem, connection);
            command.Parameters.AddWithValue("TenNV", txttimkiemten.Text);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            DataTable table = new DataTable(sqlTimKiem);
            table.Load(dr);
            dgvnhanvien.DataSource = table;
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
                string sqlSelect = "select * from NhanVien where TenNv LIKE N'%" + txttimkiemten.Text + "%' ";
                SqlCommand cmd = new SqlCommand(sqlSelect, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dgvnhanvien.DataSource = table;
            }
        }

        private void dgvnhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            txtManv.ReadOnly = true;
            i = dgvnhanvien.CurrentRow.Index;
            txtManv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
            txtsdt.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
            txttentk.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString();
            txtmk.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
            cbbloai.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            btnthemm.Enabled = true;
            btnSua.Enabled = true;
            btnxoa.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("BẠN CÓ MUỐN THOÁT HAY KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
            {
                this.Close();

            } else
                Focus();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
