using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
{
    public class Account
    {
        public Account(string tenDangNhap, int loaiNguoiDung, string matKhau = null)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.loaiNguoiDung = loaiNguoiDung;
        }

        public Account(DataRow row)
        {
            this.tenDangNhap = row["TenDangNhap"].ToString();
            this.matKhau = row["MatKhau"].ToString();
            this.loaiNguoiDung = (int)row["LoaiNguoiDung"];
        }

        private int loaiNguoiDung;

        public int LoaiNguoiDung
        {
            get { return loaiNguoiDung; }
            set { loaiNguoiDung = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
    }
}
