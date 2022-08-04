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
   
    public partial class fFlowerManager : Form
    {
        SqlConnection connection;
        public fFlowerManager()
        {
            InitializeComponent();
        }
 

        private void FlowerManager_Load(object sender, EventArgs e)
        {
            String conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection= new SqlConnection(conn);
            connection.Open();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
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
            Cập_nhật_giá d = new Cập_nhật_giá();
            d.ShowDialog();
        }

        private void tìmKiếmHàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fTimkiemhanghoa d = new fTimkiemhanghoa();
            d.ShowDialog();
        }

        private void cậpNhậtGiáToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cập_nhật_giá d = new Cập_nhật_giá();
            d.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thống_kê d = new Thống_kê();
            d.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin d = new fAdmin();
            d.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Thông_tin_tài_khoản d = new Thông_tin_tài_khoản     ();
            d.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang ();
            fKhachHang.ShowDialog();
        }
        private void changeAccount(int type)
        {
            fDangnhap d = new fDangnhap();
            type = d.loaiTK();
            adminToolStripMenuItem.Enabled = type == 0;

        }
    }
}
