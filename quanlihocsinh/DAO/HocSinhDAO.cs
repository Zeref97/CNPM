using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihocsinh.DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        public static HocSinhDAO Instance
        {
            get {if (instance == null) instance = new HocSinhDAO(); return HocSinhDAO.instance; }
            private set { HocSinhDAO.instance = value; }
        }

        public bool insertHocSinh(string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email)
        {
            string query = string.Format("INSERT INTO HOCSINH(HoTen, GioiTinh, NgaySinh, DiaChi, Email) VALUES (N'{0}', N'{1}','{2}',N'{3}',N'{4}')",hoTen,gioiTinh,ngaySinh.ToShortDateString(),diaChi,email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }

        private HocSinhDAO() { }
    }
}
