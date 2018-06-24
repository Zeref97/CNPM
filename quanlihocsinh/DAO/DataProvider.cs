using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihocsinh.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string con = @"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        /*
         * định dạng của Query
         * string query = "EXEC Login @TenDangNhap , @MatKhau"
         * có dấu cách và dấu phải giữa 2 parameter
         * 
         */
        
        /// <summary>
        /// Trả về dữ liệu trong bảng của database
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null) //select * from gido
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //try
                //{
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);
                //}
                //catch (Exception ex)
                //{

                //}

                connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Trả về số dòng thực thi thành công (dùng trong insert này nọ)
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Trả về ô đầu tiên của cột đầu tiên (dùng trong select count *)
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
