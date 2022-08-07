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
            label1.Text = "XIN CHÀO : " + Variables.TenNV;
            String conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection= new SqlConnection(conn);
            connection.Open();
            if ( loaiTK.Equals(nv))
            {
                adminToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang ();
            fKhachHang.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThanhToan d = new fThanhToan();
            d.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
