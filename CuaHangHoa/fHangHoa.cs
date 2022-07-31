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
            int i;
            i = dgvHangHoa.CurrentRow.Index;
            txtMaHoa.Text = dgvHangHoa.Rows[i].Cells[0].Value.ToString();
            txtTenHoa.Text = dgvHangHoa.Rows[i].Cells[1].Value.ToString();
            txtGiaGoc.Text = dgvHangHoa.Rows[i].Cells[2].Value.ToString();
            txtGiaBan.Text=dgvHangHoa.Rows[i].Cells[3].Value.ToString();
            txtSoLuongTon.Text = dgvHangHoa.Rows[i].Cells[4].Value.ToString();
            cbMaLoai.Text = dgvHangHoa.Rows[i].Cells[5].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult =  MessageBox.Show("BẠN CÓ MUỐN THÊM HAY KHÔNG !", "THÔNG BÁO ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                MessageBox.Show("XIN MỜI BẠN THÊM CÁC THÔNG TIN CẦN THIẾT", "THÔNG BÁO", MessageBoxButtons.OK);
            }if(DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("XIN MỜI BẠN CHỌN CHỨC NĂNG KHÁC !","THÔNG BÁO",MessageBoxButtons.OK);
            }
            MessageBox.Show("BẠN ĐÃ THÊM THÀNH CÔNG !", "THÔNG BÁO", MessageBoxButtons.OK);

            String sqlThem = "INSERT INTO Hoa VALUES (@MaHoa,@TenHoa ,@GiaGoc,@GiaBan,@SoLuongTon,@MaLoai)";
            SqlCommand command = new SqlCommand(sqlThem, connection);
            command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
            command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
            command.Parameters.AddWithValue("GiaGoc",txtGiaGoc.Text);
            command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
            command.Parameters.AddWithValue("SoLuongTon",txtSoLuongTon.Text);
            command.Parameters.AddWithValue("MaLoai ",cbMaLoai.Text);
            command.ExecuteNonQuery();
            HienThi();
            DialogResult = MessageBox.Show("BẠN ĐÃ THÊM THÀNH CÔNG ", "THÔNG BÁO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN SỬA HAY KHÔNG", "THÔNG BÁO ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("XIN MỜI BẠN NHẬP THÔNG TIN Ở BÊN DƯỚI", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            if (DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("XIN MỜI BẠN CHỌN CHỨC NĂNG KHÁC", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            MessageBox.Show("BẠN ĐÃ SỬA THÀNH CÔNG ! ", "THÔNG BÁO ", MessageBoxButtons.OK);

            string SqlEdit = "update Hoa set TenHoa = @TenHoa ,GiaGoc = @GiaGoc, " +
                "GiaBan = @GiaBan,SoLuongTon = @SoLuongTon,@MaLoai = @MaLoai where MaHoa = @MaHoa  ";
           SqlCommand command = new SqlCommand(SqlEdit,connection);
            command.Parameters.AddWithValue("MaHoa",txtMaHoa.Text);
            command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
            command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
            command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
            command.Parameters.AddWithValue("SoLuongTon", txtSoLuongTon.Text);
            command.Parameters.AddWithValue("MaLoai",cbMaLoai.Text);
            command.ExecuteNonQuery();
            HienThi();
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           DialogResult= MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA SẢN PHẨM NÀY KHÔNG ?", "THÔNG BÁO ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                MessageBox.Show("BẠN ĐÃ XÓA THÀNH CÔNG SẢN PHẨM !", "THÔNG BÁO", MessageBoxButtons.OK);
            } if(DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("XIN MỜI BẠN CHỌN CHỨC NĂNG KHÁC", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            string SqlXoa = "DELETE FROM Hoa where MaHoa = @MaHoa";
            SqlCommand command = new SqlCommand(SqlXoa,connection);
            command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
            command.Parameters.AddWithValue("TenHoa", txtTenHoa.Text);
            command.Parameters.AddWithValue("GiaGoc", txtGiaGoc.Text);
            command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
            command.Parameters.AddWithValue("SoLuongTon",txtSoLuongTon.Text);
            command.Parameters.AddWithValue("MaLoai", cbMaLoai.Text);
            command.ExecuteNonQuery();
            HienThi();
            
        }
    }
}
