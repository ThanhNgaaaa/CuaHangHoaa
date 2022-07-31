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
    public partial class Tìm_kiếm_hàng_hóa : Form
    {
        SqlConnection connection;
        
        void HienThi()
        {
            string sqlSelect = "select *from Hoa ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvTimKiem.DataSource = table;
        }
        public Tìm_kiếm_hàng_hóa()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select *from Hoa where MaHoa = @MaHoa ";
            SqlCommand command = new SqlCommand(sqlTimKiem, connection);
            command.Parameters.AddWithValue("MaHoa",txtMaHoa.Text);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            DataTable table = new DataTable(sqlTimKiem);
            table.Load(dr);
            dgvTimKiem.DataSource = table;
            
        }
        private void Tìm_kiếm_hàng_hóa_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
        }
    }
}
