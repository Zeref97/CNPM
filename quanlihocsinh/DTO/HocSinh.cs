using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihocsinh.DTO
{
    public class HocSinh
    {
        /*
    MaHocSinh		int		identity			PRIMARY KEY,
	HoTen			NVARCHAR (30)	NOT NULL,
	GioiTinh		NVARCHAR (3),
	NgaySinh		DATE	NOT NULL,
	DiaChi			NVARCHAR (50),
	Email			VARCHAR (30)
         */
        public HocSinh(int maHocSinh, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email)
        {
            this.maHocSinh = maHocSinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.email = email;
        }
        
        public HocSinh(DataRow row)
        {
            this.maHocSinh = (int)row["MaHocSinh"];
            this.hoTen = row["HoTen"].ToString();
            this.gioiTinh = row["GioiTinh"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.diaChi = row["DiaChi"].ToString();
            this.email = row["Email"].ToString();
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private int maHocSinh;

        public int MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }


    }
}
