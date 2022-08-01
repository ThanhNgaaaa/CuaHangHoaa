﻿using System;
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
    public partial class fKhachHang : Form
    {
        SqlConnection connection;
        public fKhachHang()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            string sqlSelect = "select * from KhachHang ";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dtgv_KhachHang.DataSource = table;
        }
        private void fKhachHang_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["QLHOA"].ConnectionString.ToString();
            connection = new SqlConnection(conn);
            connection.Open();
            HienThi();
        }
        private bool KiemTraThongTin()
        {
            if(txtMaKh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKh.Focus();
                return false;
            }
            if(txtTenKh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKh.Focus();
                return false;
            }
            if(txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return false;
            }
            return true;    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                string sqlThem = "insert into KhachHang values(@MaKH, @TenKH, @SDT)";
                SqlCommand command = new SqlCommand(sqlThem, connection);
                command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                command.Parameters.AddWithValue("SDT", txtSdt.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                string sqlSua = "Update KhachHang set MaKh = @MaKh, TenKh= @TenKh, SDT = @SDT where MaKh = @MaKh";
                SqlCommand command = new SqlCommand(sqlSua, connection);
                command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                command.Parameters.AddWithValue("SDT", txtSdt.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                string sqlXoa = "Delete from KhachHang where @MaKh = MaKh";
                SqlCommand command = new SqlCommand(sqlXoa, connection);
                command.Parameters.AddWithValue("MaKh", txtMaKh.Text);
                command.Parameters.AddWithValue("TenKh", txtTenKh.Text);
                command.Parameters.AddWithValue("SDT", txtSdt.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
            }
        }

        private void dtgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_KhachHang.Rows[e.RowIndex];
            txtMaKh.Text = Convert.ToString(row.Cells["MaKh"].Value);
            txtTenKh.Text = Convert.ToString(row.Cells["TenKh"].Value);
            txtSdt.Text = Convert.ToString(row.Cells["SDT"].Value);
        }
        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }
}