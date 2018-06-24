using Login.DTO;
using quanlihocsinh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get {if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }


        private AccountDAO() { }

        public bool Login(string username,string password)
        {
            string query = "EXEC DangNhap @username , @password";
            //string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = 'admin' AND MatKhau = 'admin'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{username, password });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username)
        {
            string query = "Select * from NGUOIDUNG where TenDangNhap = '" + username +"'";
            //string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = 'admin' AND MatKhau = 'admin'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item); 
            }
            return null;
        }



        public bool ChangeTypeByUsername(string username, int type)
        {

            string query = string.Format("UPDATE NGUOIDUNG SET LoaiNguoiDung = '{0}' Where TenDangNhap = '{1}' ", type,username);
            //string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = 'admin' AND MatKhau = 'admin'";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;

        }


        public bool ChangePassByUsername(string username, string oldPass, string newPass)
        {
        
                string query = string.Format("EXEC DoiMatKhau {0} , {1} , {2}", username, oldPass, newPass);
                //string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = 'admin' AND MatKhau = 'admin'";
                int data = DataProvider.Instance.ExecuteNonQuery(query);
                return data > 0;
            
        }

        public bool InsertAccount(string username, string password,int type)
        {
            string query = string.Format("INSERT NGUOIDUNG ( TenDangNhap, MatKhau, LoaiNguoiDung ) VALUES ( '{0}', '{1}', '{2}')", username, password,type);
            //string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = 'admin' AND MatKhau = 'admin'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = string.Format("Delete NGUOIDUNG where TenDangNhap = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result >0);
        }
   
    }

}
