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
   
    public partial class FlowerManager : Form
    {
        SqlConnection connection;
        string loaiTK = fDangnhap.LOAITK_USER;
        string nv = "1";



        public FlowerManager()
        {
            InitializeComponent();
            
            
        }
        
        private void FlowerManager_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào : " + Variables.TenNV;

            String conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();


            if (loaiTK.Equals(nv))
            {
                adminToolStripMenuItem.Enabled = false;
                doanhthuToolStripMenuItem.Enabled = false;
            }
            LoadInfo_Account();
        }
        private void LoadInfo_Account()
        {
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtChucVu.ReadOnly = true;  
            txtMa.Text = fDangnhap.MA_USER;
            txtTen.Text = Variables.TenNV;
            txtSDT.Text = fDangnhap.SDT_USER;
            txtChucVu.Text = getChucVu();
        }
        private string getChucVu()
        {
            string chucVu = "";

            if (loaiTK.Equals(nv))
            {
                chucVu = "Nhân Viên";
            }
            else
            {
                chucVu = "Admin";
            }
            return chucVu;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát phiên đăng nhập ?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHangHoa d = new fHangHoa();
            d.ShowDialog  ();
        }
        private void tìmKiếmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTimkiemhanghoa d = new fTimkiemhanghoa();
            d.ShowDialog();
            
        }

        private void cậpNhậtGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCapnhatgia d = new fCapnhatgia();
            d.ShowDialog();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin d = new fAdmin();
            d.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fCapNhatMatKhau d = new fCapNhatMatKhau     ();
            d.ShowDialog();
        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang ();
            fKhachHang.ShowDialog();
        }


        private void doanhthuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoanhThu d = new fDoanhThu();
            d.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThanhToan d = new fThanhToan();
            d.ShowDialog();
        }

        
    }
}
