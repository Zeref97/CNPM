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
using quanlihocsinh.DAO;
using quanlihocsinh.DTO;

namespace quanlihocsinh
{
    public partial class tiepnhanhocsinh : Form
    {
        public tiepnhanhocsinh()
        {
            InitializeComponent();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            
                //Kết nối Database
                //SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
                //connection.Open();      //Mở Database
               
                string sex;             //Lưu giới tính
                int minOld =0, maxOld = 0;          //Lưu độ tuổi tối thiểu và tối đa

                //Kiểm tra checkbox xem chọn Nam hay Nữ, biến sex để lưu giá trị đã chọn của checkbox, nếu k chọ là NULL
                if (checkBoxNam.Checked == true)
                    sex = "Nam";
                else if (checkBoxNu.Checked == true)
                    sex = "Nữ";
                else
                    sex = "NULL";
                string hoten =textBoxTenhs.Text.ToString();
                //sex 
                DateTime ngaysinh = dateTimeInputBirth.Value;
                string diachi=textBoxdiachi.Text.ToString();  
                string email = textBoxemail.Text.ToString();
                //HocSinh hs = new HocSinh();
                //Tính tuổi đã nhập để so sánh tuổi max/min
                if (textBoxTenhs.Text.Length == 0 || textBoxdiachi.Text.Length == 0 || textBoxemail.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
                else if (String.Compare(sex, "NULL") == 0)
                    MessageBox.Show("Bạn chưa chọn giới tính.");
                int thisyear = DateTime.Now.Year;
                int studentyear = ngaysinh.Year;
                //Truy xuất Database lấy dữ liệu tuổi max/min
                /*
                SqlCommand cmd = new SqlCommand("SELECT TuoiToiThieu, TuoiToiDa FROM THAMSO", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    minOld = Convert.ToInt32(reader[0]);
                    maxOld = Convert.ToInt32(reader[1]);
                }
                
                reader.Close();
                */
                minOld = ThamsoDAO.Instance.getThamSo("TuoiToiThieu");
                maxOld = ThamsoDAO.Instance.getThamSo("TuoiToiDa");
                /*Kiểm tra điều kiện
                 * 1. Đã điền đủ các thông tin hay chưa?
                 * 2. Checkbox giới tính có rỗng hay không?
                 * 3. Độ tuổi có phù hợp hay chưa (max/min)?
                 * Nếu thỏa các điều kiện trên thì kết nối với database và insert dữ liệu vào.
                 */

                
                if (thisyear - studentyear < minOld || thisyear - studentyear > maxOld)
                    MessageBox.Show("Độ tuổi không phù hợp với quy định.");
            
                    /*
                    cmd = new SqlCommand("INSERT INTO HOCSINH(HoTen, GioiTinh, NgaySinh, DiaChi, Email)" +
                    "values (N'" + textBoxTenhs.Text.ToString() + "',N'" + sex + "','" + dateTimeInputBirth.Value.ToString("yyyy/MM/dd") + "','" + textBoxdiachi.Text.ToString() + "','" + textBoxemail.Text.ToString() + "')", connection);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                     */
                if(HocSinhDAO.Instance.insertHocSinh(hoten, sex, ngaysinh, diachi, email))
                {
                    MessageBox.Show("Thêm học sinh thành công");
                    textBoxTenhs.ResetText();
                    checkBoxNam.ResetText();
                    textBoxdiachi.ResetText();
                    textBoxemail.ResetText();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm học sinh thất bại");
                }

            
           
        }
    }

}
