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

/**********************THUẬT TOÁN***************************
 * 1. Mở kết nối database và hiện danh sách những học sinh chưa được xếp
 * lớp lên girdview.
 * 2. Chọn học sinh muốn thêm vào danh sách lớp bằng cách nhấn chuột trên
 * gridview, mã học sinh sẽ hiện ở textbox bên dưới để dễ quan sát.
 * 3. Thêm học sinh đã chọn vào database.
 *  *Lưu ý: bienToanCuc.chonMaNamHoc và bienToanCuc.chonMaLop là biến toàn cục
 *  lưu ở form trước để form này add vào đúng lớp, đúng năm học đó.
 *  *Khuyết điểm: gridview khi chọn phải bấm vào ký tự (ở bất kỳ cột nào)
 *  mới chọn được, còn bấm ở khoảng trắng (phía sau ký tự thì không hiện)
 *  => Cần fix.
 *************************************************************/

namespace quanlihocsinh
{
    public partial class lapdanhsach : Form
    {
        //Connect Database
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
        //Biến id dùng để lưu mã sinh viên đã chọn trong gridview, mục đích để khi insert vào table DANHSACHHOCSINH có được mã học sinh
        string id = "NULL";

        public lapdanhsach()
        {
            InitializeComponent();
            connection.Open();          //Mở kết nối database
            this.loadGrid();            //Load dữ liệu học sinh chưa được xếp lớp lên gridview
        }

        //Hàm load dữ liệu học sinh chưa được xếp lớp lên gridview
        private void loadGrid() {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Email as STT, MaHocSinh as 'Mã học sinh', HoTen as 'Họ Tên', GioiTinh as 'Giới Tính', NgaySinh as 'Năm Sinh', DiaChi as 'Địa Chỉ' FROM HOCSINH WHERE MaHocSinh NOT IN (SELECT MaHocSinh FROM DANHSACHHOCSINH)", connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridViewStudent.DataSource = tb;

            //Đánh số thứ tự ở cột đầu tiên
            for (int i = 0; i < dataGridViewStudent.Rows.Count - 1; i++)
            {
                dataGridViewStudent.Rows[i].Cells[0].Value = i + 1;
            }
        }

        //Event thoát khỏi form
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        //Event chọn học sinh trên gridview và sau đó sẽ lấy được mã học sinh đã chọn để thêm vào danh sách lớp
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStudent.Rows[e.RowIndex];

                id = row.Cells["Mã học sinh"].Value.ToString();
                textBoxID.Text = id;        //Hiện lên textbox để biết mã học sinh đang chọn
            }
        }


        //Event thêm học sinh
        private void button1_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem id có rỗng hay không? nếu rỗng sẽ không cho xử lý event thêm
            if (String.Compare(id, "NULL") == 0)
                    MessageBox.Show("Bạn chưa chọn học sinh để thêm vào.");
            else
            {
                //Thêm học sinh vào danh sách lớp
                try
                {
                    //bienToanCuc.chonMaNamHoc và bienToanCuc.chonMaLop là biến toàn cục để lưu giá trị ở form trước.
                    SqlCommand cmd = new SqlCommand("INSERT INTO DANHSACHHOCSINH(MaNamHoc, MaLop, MaHocSinh, DTBHK1, DTBHK2)" +
                   "values ('" + bienToanCuc.chonMaNamHoc + "','" + bienToanCuc.chonMaLop + "','" + id + "','" + 0 + "','" + 0 + "')", connection);

                    cmd.ExecuteNonQuery();
                    loadGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
