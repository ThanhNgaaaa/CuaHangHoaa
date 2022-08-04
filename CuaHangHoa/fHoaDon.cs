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
    public partial class fHoaDon : Form
    {
        SqlConnection connection;
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
        }
        void HienThi()
        {
            string sqlSelect = " select C.MaHoaDon,L.MaLoai, H.MaHoa,H.TenHoa,C.SoLuong, C.SoLuong* H.GiaBan as[Tong tien] from LoaiHoa L, Hoa H, ChiTietHoaDon C where L.MaLoai = H.MaLoai and H.MaHoa = C.MaHoa and C.MaHoaDon = '"+txtMaHD.Text+"'group by C.MaHoaDon,H.GiaBan,C.SoLuong,H.MaHoa,L.MaLoai, H.TenHoa ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dtgv_Hoa.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                string sqlThemCTHD = "insert into ChiTietHoaDon(MaHoa,MaHoaDon,SoLuong) values(@MaHoa,@MaHoaDon, @SL)";
                SqlCommand command = new SqlCommand(sqlThemCTHD, connection);
                command.Parameters.AddWithValue("MaHoa", txtMaHoa.Text);
                command.Parameters.AddWithValue("MaHoaDon", txtMaHD.Text);
                command.Parameters.AddWithValue("SL",nmSoluong.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
                thanhTien();

        }
        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {

        }
        private bool KiemTraThongTin()
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return false;
            }
            if (txtMaNv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNv.Focus();
                return false;
            }
            if (txtMaKh.Text =="")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKh.Focus();
                return false;
            }
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoai.Focus();
                return false;
            }
            if (txtMaHoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHoa.Focus();
                return false;
            }
            if (nmSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmSoluong.Focus();
                return false;
            }
            return true;
        }
        private void themHoaDon()
        {
            string sqlThemHD = "insert into HoaDon(MaHoaDon,MaNv,MaKh,NgayLap) values(@MaHoaDon,@MaNv, @MaKh, @NgayLap)";
            SqlCommand command = new SqlCommand(sqlThemHD, connection);
            command.Parameters.AddWithValue("MaHoaDon", txtMaHD.Text);
            command.Parameters.AddWithValue("MaNv", txtMaNv.Text);
            command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
            command.Parameters.AddWithValue("NgayLap",dateTimePicker1.Value);
            command.ExecuteNonQuery();
            thanhTien();

        }
        private void thanhTien()
        {
            int sc = dtgv_Hoa.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dtgv_Hoa.Rows[i].Cells["Tong tien"].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            themHoaDon();
        }
    }
}
