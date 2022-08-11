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
    public partial class fDoanhThu : Form
    {
        SqlConnection connection;
        public static SqlConnection Connection { get; private set; }

        public fDoanhThu()
        {
            InitializeComponent();
        }

        private void fDoanhThu_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            TDT_dgvStatistics.Columns["MaNv"].Width = 100;
          

        }

        private void TDT_btShow_Click(object sender, EventArgs e)
        {



            string sql = @"
SELECT	NhanVien.MaNv  ,
		NhanVien.TenNv ,
		SUM(ChiTietHoaDon.DonGia) AS TongTien
FROM NhanVien INNER JOIN HoaDon ON NhanVien.MaNv = HoaDon.MaNv
			  INNER JOIN ChiTietHoaDon ON HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon
WHERE DATEDIFF(DAY, HoaDon.NgayLap, @TuNgay) <= 0 AND DATEDIFF(DAY, HoaDon.NgayLap, @DenNgay) >= 0
GROUP BY NhanVien.MaNv, NhanVien.TenNv";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("TuNgay", TDT_dtpFrom.Value);
            command.Parameters.AddWithValue("DenNgay", TDT_dtpTo.Value);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            TDT_dgvStatistics.AutoGenerateColumns = false;
            TDT_dgvStatistics.DataSource = table;
        }
    }
}
