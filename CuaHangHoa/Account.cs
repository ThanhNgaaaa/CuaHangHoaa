using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangHoa
{
    public class Account
    {
        private string tenTaiKhoan;
        private string matKhau;
        private int loaiTaiKhoan;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public Account(string tenTaiKhoan, string matKhau, int loaiTaiKhoan)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
        }
        public Account(DataRow row)
        {
            this.tenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.matKhau = row["MatKhau"].ToString();
            this.loaiTaiKhoan = (int)row["LoaiTaiKhoan"];
        }

    }
}
