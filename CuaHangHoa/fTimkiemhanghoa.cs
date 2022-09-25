using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CuaHangHoa
{
    public partial class fTimkiemhanghoa : Form
    {
        SqlConnection connection;
        private bool isThem = false;
        public fTimkiemhanghoa()
        {
            InitializeComponent();
        }
        
        private void Tìm_kiếm_hàng_hóa_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();

            HienThi();
            ckTimkiemhoa_CheckedChanged(sender, e);

        }
        public void HienThi()
        {
            string sqlSelect = "select MaHoa as [Mã hoa],TenHoa as [Tên hoa],GiaGoc as [Giá gốc],GiaBan as [Giá bán],SoLuongTon as [Số lượng tồn],TenLoai as [Tên loại] from Hoa, LoaiHoa where Hoa.MaLoai = LoaiHoa.MaLoai ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvTimKiem.DataSource = table;
            if(table.Rows.Count > 0)
            {
                dgvTimKiem.Rows[0].Selected = true;
            }
            isThem = false;
            dgvTimKiem.Columns["Mã hoa"].Width = 80;
            dgvTimKiem.Columns["Tên hoa"].Width = 150;
            dgvTimKiem.Columns["Số lượng tồn"].Width = 100;
            dgvTimKiem.Columns["Giá gốc"].Width = 75;
            dgvTimKiem.Columns["Giá bán"].Width = 75;
            dgvTimKiem.Columns["Tên loại"].Width = 105;

        }
        private void loadcombo()
        {
            string sqlSelect = "select * from LoaiHoa";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cbLoai.DataSource = table;
            cbLoai.DisplayMember = table.Columns["TenLoai"].ToString();
            cbLoai.ValueMember = table.Columns["MaLoai"].ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTimtheoloai.Checked == true)
            {
                loadcombo();
            }
            else
            {
                cbLoai.DataSource = null;
                HienThi();
            }
        }

        private void ckTimkiemhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTimkiem.Checked == true)
            {
                ckTimtheoloai.Visible = true;
                ckTimtheoten.Visible = true;
                cbLoai.Visible = true;
                txtTentim.Visible = true;
            }
            else
            {
                ckTimtheoloai.Visible = false;
                ckTimtheoten.Visible = false;
                cbLoai.Visible = false;
                txtTentim.Visible = false;

            }
        }
        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlSelect = "select MaHoa as [Mã hoa],TenHoa as [Tên hoa],GiaGoc as [Giá gốc],GiaBan as [Giá bán],SoLuongTon as [Số lượng tồn],TenLoai as [Tên loại] from Hoa, LoaiHoa where Hoa.MaLoai = LoaiHoa.MaLoai and LoaiHoa.TenLoai = N'" + cbLoai.Text + "'  ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvTimKiem.DataSource = table;
        }
        private void ckTimtheoten_CheckedChanged(object sender, EventArgs e)
        {
            
                if(ckTimtheoten.Checked == true)
                {
                    txtTentim.Visible = true;
                    txtTentim.Text = "";
                    txtTentim.Focus();
                }
            else
            
                txtTentim.Visible = false;
        }

        private void txtTentim_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string sqlSelect = "select MaHoa as [Mã hoa],TenHoa as [Tên hoa],GiaGoc as [Giá gốc],GiaBan as [Giá bán],SoLuongTon as [Số lượng tồn],TenLoai as [Tên loại] from Hoa, LoaiHoa where Hoa.MaLoai = LoaiHoa.MaLoai and TenHoa LIKE N'%" + txtTentim.Text + "%' ";
                SqlCommand cmd = new SqlCommand(sqlSelect, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dgvTimKiem.DataSource = table;
                if (table.Rows.Count > 0)
                {
                    dgvTimKiem.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("KHÔNG TỒN TẠI !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                isThem = false;
            }
           
        }
    }
}
