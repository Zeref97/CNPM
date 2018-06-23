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
    public partial class tiepnhanhocsinh : Form
    {
        //Kết nối Database
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
        public tiepnhanhocsinh()
        {
            InitializeComponent();
            connection.Open();      //Mở Database
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sex;             //Lưu giới tính
                int minOld =0, maxOld = 0;          //Lưu độ tuổi tối thiểu và tối đa

                //Kiểm tra checkbox xem chọn Nam hay Nữ, biến sex để lưu giá trị đã chọn của checkbox, nếu k chọ là NULL
                if (checkBoxNam.Checked == true){
                    sex = "Nam";
                    checkBoxNam.Checked = false;
                }
                else if (checkBoxNu.Checked == true){
                    sex = "Nữ";
                    checkBoxNu.Checked = false;
                }
                else
                    sex = "NULL";

                //Tính tuổi đã nhập để so sánh tuổi max/min
                DateTime date1 = Convert.ToDateTime(dateTimeInputBirth.Text);
                DateTime date2 = DateTime.Now;
                TimeSpan time = date2.Subtract(date1);
                double year = time.Days / 365.24;

                //Truy xuất Database lấy dữ liệu tuổi max/min
                SqlCommand cmd = new SqlCommand("SELECT TuoiToiThieu, TuoiToiDa FROM THAMSO", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    minOld = Convert.ToInt32(reader[0]);
                    maxOld = Convert.ToInt32(reader[1]);
                }
                reader.Close();

                /*Kiểm tra điều kiện
                 * 1. Đã điền đủ các thông tin hay chưa?
                 * 2. Checkbox giới tính có rỗng hay không?
                 * 3. Độ tuổi có phù hợp hay chưa (max/min)?
                 * Nếu thỏa các điều kiện trên thì kết nối với database và insert dữ liệu vào.
                 */

                if (textBoxTenhs.Text.Length == 0 || textBoxdiachi.Text.Length == 0 || textBoxemail.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
                else if (String.Compare(sex, "NULL") == 0)
                    MessageBox.Show("Bạn chưa chọn giới tính.");
                else if (year < minOld || year > maxOld)
                    MessageBox.Show("Độ tuổi không phù hợp với quy định.");
                else
                {
                    cmd = new SqlCommand("INSERT INTO HOCSINH(HoTen, GioiTinh, NgaySinh, DiaChi, Email)" +
                    "values (N'" + textBoxTenhs.Text.ToString() + "',N'" + sex + "','" + dateTimeInputBirth.Value.ToString("yyyy/MM/dd") + "','" + textBoxdiachi.Text.ToString() + "','" + textBoxemail.Text.ToString() + "')", connection);

                    cmd.ExecuteNonQuery();

                    textBoxTenhs.Text = "";
                    textBoxdiachi.Text = "";
                    textBoxemail.Text = "";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }
    }

}
