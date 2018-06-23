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

namespace quanlihocsinh
{
    public partial class tracuuhocsinh : Form
    {
        public tracuuhocsinh()
        {
            InitializeComponent();
        }

        //Nút chức năng search
        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                //kết nối database
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
                connection.Open(); //Mở kết nối database

                //Truy vấn lấy thông tin trong database load lên grid, dùng 'N' đặt trước LIKE để search tên tiếng việt
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT hs.MaHocSinh as STT, TenLop as 'Lớp', HoTen as 'Họ Tên', DTBHK1 as 'TB Học Kỳ I', DTBHK2 as 'TB Học Kỳ II' FROM HOCSINH hs, DANHSACHHOCSINH ds, LOP l WHERE hs.MaHocSinh = ds.MaHocSinh AND ds.MaLop = l.MaLop AND HoTen LIKE N'%" + textBoxName.Text + "%'", connection);
                DataTable tb = new DataTable();         //Tạo dataTable
                adapter.Fill(tb);                       //Điền dữ liệu truy vấn vào dataTable
                dataGridViewSearchName.DataSource = tb;                 //Đưa data vào grid

                //Đánh số thứ tự ở cột đầu tiên (STT trong grid)
                for (int i = 0; i < dataGridViewSearchName.Rows.Count -1; i++)
                {
                    dataGridViewSearchName.Rows[i].Cells[0].Value = i + 1;
                }  

                connection.Close(); //Đóng kết nối database
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
