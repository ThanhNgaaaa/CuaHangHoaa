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


        private DataTable tblCTHD;

        SqlConnection connection;
        string loaiTK = fDangnhap.LOAITK_USER;
        string nv = "1";

        private string maNV = fDangnhap.MA_USER;


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


        //public void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        //{
        //    SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
        //    DataTable table = new DataTable();
        //    dap.Fill(table);
        //    cbo.BindingContext = this.BindingContext;
        //    cbo.DataSource = table;
        //    cbo.ValueMember = ma; //Trường giá trị
        //    cbo.DisplayMember = ten; //Trường hiển thị
        //}

        //private void btnThemHD_Click(object sender, EventArgs e)
        //{
        //    btnThem.Enabled = true;
        //    btnLuu.Enabled = true;
        //    btnHuyHD.Enabled = true;
        //    if (KiemTraThongTin())
        //    {
        //        themHoaDon();
        //    }
        //    LoadDataGridView();
        //}
        //private bool KiemTraThongTin()
        //{
        //    if (txtMaHD.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtMaHD.Focus();
        //        return false;
        //    }
        //    if (txtMaNv.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtMaNv.Focus();
        //        return false;
        //    }
        //    if (cmbMaKh.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cmbMaKh.Focus();
        //        return false;
        //    }
        //    if (cmbMaHoa.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mã hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cmbMaHoa.Focus();
        //        return false;
        //    }
        //    if (nmSoLuong.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        nmSoLuong.Focus();
        //        return false;
        //    }
        //    return true;
        //}


        //private void themHoaDon()
        //{
        //    if (KiemTraPrimaryBill())
        //    {
        //        btnThemHD.Enabled = true;
        //        string sqlThemHD = "insert into HoaDon(MaHoaDon,MaNv,MaKh,NgayLap) values(@MaHoaDon,@MaNv, @MaKh, @NgayLap)";
        //        SqlCommand command = new SqlCommand(sqlThemHD, connection);
        //        command.Parameters.AddWithValue("MaHoaDon", txtMaHD.Text);
        //        command.Parameters.AddWithValue("MaNv", txtMaNv.Text);
        //        command.Parameters.AddWithValue("MaKh", cmbMaKh.SelectedValue);
        //        command.Parameters.AddWithValue("NgayLap", dtpNgayLap.Value);
        //        command.ExecuteNonQuery();
        //    }

        //}


        //private bool KiemTraPrimaryBill()
        //{
        //    string sql = "SELECT MaHoaDon FROM HoaDon where MaHoaDon ='" + txtMaHD.Text + "'";
        //    if (CheckKey(sql))
        //    {
        //        MessageBox.Show("Mã hóa đơn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtMaHD.Text = "";
        //        txtMaHD.Focus();
        //        return false;
        //    }
        //    return true;
        //}



        //public bool CheckKey(string sql)
        //{
        //    SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
        //    DataTable table = new DataTable();
        //    dap.Fill(table);
        //    if (table.Rows.Count > 0)
        //        return true;
        //    else return false;
        //}


        //private void LoadDataGridView()
        //{
        //    string sql;
        //    sql = "select C.MaHoaDon, L.TenLoai, H.MaHoa as [Mã hoa], H.TenHoa, C.SoLuong as[Số lượng], H.GiaBan, C.SoLuong*H.GiaBan as [Tổng tiền] from ChiTietHoaDon C, Hoa H, LoaiHoa L where L.MaLoai = H.MaLoai and  C.MaHoa = H.MaHoa and C.MaHoaDon = '" + txtMaHD.Text + "'";
        //    tblCTHD = GetDataToTable(sql);
        //    dtgv_HoaDon.DataSource = tblCTHD;
        //    dtgv_HoaDon.Columns[0].HeaderText = "Mã hóa đơn";
        //    dtgv_HoaDon.Columns[1].HeaderText = "Loại hoa";
        //    dtgv_HoaDon.Columns[2].HeaderText = "Mã hoa";
        //    dtgv_HoaDon.Columns[3].HeaderText = "Tên hoa";
        //    dtgv_HoaDon.Columns[4].HeaderText = "Số lượng";
        //    dtgv_HoaDon.Columns[5].HeaderText = "Giá bán";
        //    dtgv_HoaDon.Columns[6].HeaderText = "Tổng tiền";
        //    dtgv_HoaDon.Columns[0].Width = 120;
        //    dtgv_HoaDon.Columns[1].Width = 120;
        //    dtgv_HoaDon.Columns[2].Width = 80;
        //    dtgv_HoaDon.Columns[3].Width = 180;
        //    dtgv_HoaDon.Columns[4].Width = 90;
        //    dtgv_HoaDon.Columns[5].Width = 90;
        //    dtgv_HoaDon.Columns[6].Width = 90;
        //    dtgv_HoaDon.AllowUserToAddRows = false;
        //    dtgv_HoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        //}

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    string sql;
        //    double sl, SLcon;
        //    sl = Convert.ToDouble(GetFieldValues("SELECT SoLuongTon FROM Hoa WHERE MaHoa = N'" + cmbMaHoa.SelectedValue + "'"));
        //    if (Convert.ToDouble(nmSoLuong.Text) > sl)
        //    {
        //        MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        nmSoLuong.Text = "";
        //        nmSoLuong.Focus();
        //        return;
        //    }
        //    // Cập nhật lại số lượng của mặt hàng vào bảng Hoa
        //    SLcon = sl - Convert.ToDouble(nmSoLuong.Text);
        //    sql = "UPDATE Hoa SET SoLuongTon =" + SLcon + " WHERE MaHoa= N'" + cmbMaHoa.SelectedValue + "'";
        //    RunSQL(sql);
        //    // Cập nhật lại tổng tiền cho hóa đơn bán
        //    //capNhatTongTien();
        //    btnHuyHD.Enabled = true;
        //    btnThem.Enabled = true;
        //    MessageBox.Show("Lưu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    ResetValues();
        //    LoadDataGridView();
        //}

        //private void capNhatTongTien()
        //{
        //    int sc = dtgv_HoaDon.Rows.Count;
        //    string sqlUpdatePrice;
        //    for (int i = 0; i < sc; i++)
        //    {
        //        string maHoa = dtgv_HoaDon.Rows[i].Cells["Mã hoa"].Value.ToString();
        //        float donGia = float.Parse(dtgv_HoaDon.Rows[i].Cells["Tổng tiền"].Value.ToString());
        //        sqlUpdatePrice = "Update ChiTietHoaDon SET DonGia ='" + donGia + "' WHERE MaHoaDon ='" + txtMaHD.Text + "' and MaHoa='" + maHoa +"'";
        //        RunSQL(sqlUpdatePrice);
        //    }
        //}

        //private void ResetValues()
        //{
        //    txtMaHD.Text = "";
        //    dtpNgayLap.Value = DateTime.Now;
        //    cmbMaKh.Text = "";
        //    txtTongTien.Text = "0";
        //    cmbMaHoa.Text = "";
        //    nmSoLuong.Text = "";
        //}

        //public string GetFieldValues(string sql)
        //{
        //    string ma = "";
        //    SqlCommand cmd = new SqlCommand(sql, connection);
        //    SqlDataReader reader;
        //    reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //        ma = reader.GetValue(0).ToString();
        //    reader.Close();
        //    return ma;
        //}

        //private void btnHuyHD_Click(object sender, EventArgs e)
        //{
        //    double sl, slcon, slxoa;
        //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        string sql = "SELECT MaHoa,SoLuong FROM ChiTietHoaDon WHERE MaHoaDon = '" + txtMaHD.Text + "'";
        //        DataTable tblHang = GetDataToTable(sql);
        //        for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
        //        {
        //            // Cập nhật lại số lượng cho các mặt hàng
        //            sl = Convert.ToDouble(GetFieldValues("SELECT SoLuongTon FROM Hoa WHERE MaHoa = '" + tblHang.Rows[hang][0].ToString() + "'"));
        //            slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
        //            slcon = sl + slxoa;
        //            sql = "UPDATE Hoa SET SoLuongTon =" + slcon + " WHERE MaHoa= N'" + tblHang.Rows[hang][0].ToString() + "'";
        //            RunSQL(sql);
        //        }

        //        //Xóa chi tiết hóa đơn
        //        sql = "DELETE ChiTietHoaDon WHERE MaHoaDon='" + txtMaHD.Text + "'";
        //        RunSQL(sql);

        //        //Xóa hóa đơn
        //        sql = "DELETE HoaDon WHERE MaHoaDon=N'" + txtMaHD.Text + "'";
        //        RunSQL(sql);
        //        ResetValues();
        //        LoadDataGridView();
        //        btnHuyHD.Enabled = false;
        //        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }

        //}



        //public DataTable GetDataToTable(string sql)
        //{
        //    DataTable table = new DataTable();
        //    SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
        //    dap.Fill(table);
        //    return table;
        //}

        //public void RunSQL(string sql)
        //{
        //    SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
        //    cmd = new SqlCommand();
        //    cmd.Connection = connection; //Gán kết nối
        //    cmd.CommandText = sql; //Gán lệnh SQL
        //    try
        //    {
        //        cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    cmd.Dispose();//Giải phóng bộ nhớ
        //    cmd = null;
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    btnThemHD.Enabled = true;
        //    if (KiemTraPrimaryFlower())
        //    {
        //        string sqlThemCTHD = "insert into ChiTietHoaDon(MaHoa,MaHoaDon,SoLuong) values(@MaHoa,@MaHoaDon, @SL)";
        //        SqlCommand command = new SqlCommand(sqlThemCTHD, connection);
        //        command.Parameters.AddWithValue("MaHoa", cmbMaHoa.SelectedValue);
        //        command.Parameters.AddWithValue("MaHoaDon", txtMaHD.Text);
        //        command.Parameters.AddWithValue("SL", nmSoLuong.Text);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Thêm hoa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadDataGridView();
        //        capNhatTongTien();

        //    }
        //    thanhTien();
        //}


        //private bool KiemTraPrimaryFlower()
        //{
        //    string sql = "SELECT MaHoa FROM ChiTietHoaDon where MaHoaDon ='" + txtMaHD.Text + "' and MaHoa='" + cmbMaHoa.SelectedValue + "'";
        //    if (CheckKey(sql))
        //    {
        //        MessageBox.Show("Mã hoa này đã có trong hóa đơn này, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cmbMaHoa.Text = "";
        //        cmbMaHoa.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        //private void thanhTien()
        //{
        //    int sc = dtgv_HoaDon.Rows.Count;
        //    float thanhtien = 0;
        //    for (int i = 0; i < sc; i++)
        //        thanhtien += float.Parse(dtgv_HoaDon.Rows[i].Cells["Tổng tiền"].Value.ToString());
        //    txtTongTien.Text = thanhtien.ToString();
        //}

        //private void dtgv_HoaDon_DoubleClick(object sender, EventArgs e)
        //{
        //    string MaHoaxoa, sql;
        //    Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
        //    if (tblCTHD.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        //    {
        //        //Xóa hàng và cập nhật lại số lượng hàng 
        //        MaHoaxoa = dtgv_HoaDon.CurrentRow.Cells["Mã hoa"].Value.ToString();
        //        SoLuongxoa = Convert.ToDouble(dtgv_HoaDon.CurrentRow.Cells["Số lượng"].Value.ToString());
        //        ThanhTienxoa = Convert.ToDouble(dtgv_HoaDon.CurrentRow.Cells["Tổng tiền"].Value.ToString());
        //        sql = "DELETE ChiTietHoaDon WHERE MaHoaDon='" + txtMaHD.Text + "' AND MaHoa = N'" + MaHoaxoa + "'";
        //        RunSQL(sql);
        //        // Cập nhật lại số lượng cho các mặt hàng
        //        sl = Convert.ToDouble(GetFieldValues("SELECT SoLuongTon FROM Hoa WHERE MaHoa = '" + MaHoaxoa + "'"));
        //        slcon = sl + SoLuongxoa;
        //        sql = "UPDATE Hoa SET SoLuongTon =" + slcon + " WHERE MaHoa= '" + MaHoaxoa + "'";
        //        RunSQL(sql);
        //        // Cập nhật lại tổng tiền cho hóa đơn bán
        //        tong = Double.Parse(txtTongTien.Text);
        //        tongmoi = tong - ThanhTienxoa;
        //        RunSQL(sql);
        //        txtTongTien.Text = tongmoi.ToString();
        //        LoadDataGridView();
        //    }
        //}

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

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
