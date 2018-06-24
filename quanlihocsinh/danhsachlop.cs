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

/***********************THUẬT TOÁN**********************
 * 1. Khi mở form, dữ liệu được load lên combobox thông qua hàm loadDBComBox();
 * 2. Sau đó nếu thay đổi combobox năm học, thì lớp sẽ được cập nhật lại (số khối không
 * đổi). Tương tự khi thay đổi combobox khối, thì lớp cũng sẽ được cập nhật lại.
 * 3. Nếu bấm hiển thị danh sách, hàm loadGrid() sẽ được gọi để hiển thị danh sách
 * của lớp đã chọn lên gridview.
 * 4. Nếu bấm button thêm, đầu tiên sẽ kiểm tra sĩ số đạt tối đa hay chưa, nếu chưa thì
 * giá trị mã năm học và mã lớp sẽ được lưu lại dựa vào biến toàn
 * cục trong class bientoancuc(). Mục đích là để khi thêm học sinh mới vào lớp đã chọn
 * ở form trước sẽ biết mã lớp và mã năm học đúng để insert vào database.
 ******************************************************/

namespace quanlihocsinh
{
  
    public partial class danhsachlop : Form
    {
        //Kết nối database
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True");

        public danhsachlop()
        {
            InitializeComponent();
            connection.Open();      //Mở database
            this.loadDBComBox();        //Load combobox from Database khi form vừa mới được mở 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void danhsachlop_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'quanLyHocSinhDataSet.HOCSINH' table. You can move, or remove it, as needed.
this.hOCSINHTableAdapter.Fill(this.quanLyHocSinhDataSet.HOCSINH);
            // TODO: This line of code loads data into the 'quanLyHocSinhDataSet.DANHSACHHOCSINH' table. You can move, or remove it, as needed.
            this.dANHSACHHOCSINHTableAdapter.Fill(this.quanLyHocSinhDataSet.DANHSACHHOCSINH);

        }

        //Load combobox from Database
        public void loadDBComBox()
        {
            try
            {
                //Load tên của các năm học lên
                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM NAMHOC", connection);
                DataSet dts3 = new DataSet();
                adapter3.Fill(dts3, "NAMHOC");
                comboBox3.DataSource = dts3.Tables[0];
                comboBox3.DisplayMember = "TenNamHoc";
                comboBox3.ValueMember = "MaNamHoc";

                //Load tên của các học kỳ lên
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT MaKhoi, TenKhoi FROM KHOI", connection);
                DataSet dts1 = new DataSet();
                adapter1.Fill(dts1, "KHOI");
                comboBox1.DataSource = dts1.Tables[0];
                comboBox1.DisplayMember = "TenKhoi";
                comboBox1.ValueMember = "MaKhoi";

                //maKhoi và maNamHoc lưu giá trị của combobox khối và năm học
                String maKhoi = comboBox1.SelectedValue.ToString();
                String maNamHoc = comboBox3.SelectedValue.ToString();

                //Load tên các lớp lên
                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM LOP WHERE MaKhoi = '" +maKhoi +"' AND MaNamHoc = '" +maNamHoc +"'", connection);
                DataSet dts2 = new DataSet();
                adapter2.Fill(dts2, "LOP");
                comboBox2.DataSource = dts2.Tables[0];
                comboBox2.DisplayMember = "TenLop";
                comboBox2.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //Event chọn khối
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do mỗi năm học có số lớp khác nhau nên phải cập nhật lại combobox lớp
            try{
                String maKhoi = comboBox1.SelectedValue.ToString();
                String maNamHoc = comboBox3.SelectedValue.ToString();

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM LOP WHERE MaKhoi = '" + maKhoi + "' AND MaNamHoc = '" + maNamHoc + "'", connection);
                DataSet dts2 = new DataSet();
                adapter2.Fill(dts2, "LOP");
                comboBox2.DataSource = dts2.Tables[0];
                comboBox2.DisplayMember = "TenLop";
                comboBox2.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Event nút lập danh sách
        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy sĩ số tối đa ra database và lưu vào biến maxSiSo
                int maxSiSo = 0;
                SqlCommand cmd = new SqlCommand("SELECT SiSoToiDa FROM THAMSO", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxSiSo = Convert.ToInt32(reader[0]);
                }
                reader.Close();

                //Lấy giá trị sĩ số hiện tại của lớp từ database và lưu vào biến siSoLop
                int siSoLop = 0;
                cmd = new SqlCommand("SELECT SiSo FROM LOP WHERE MaLop = '" + comboBox2.SelectedValue.ToString() + "'", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    siSoLop = Convert.ToInt32(reader[0]);
                }
                reader.Close();

                //Kiểm tra sĩ số lớp có vượt qua quy định hay không?
                if(siSoLop >= maxSiSo)
                    MessageBox.Show("Lớp đã đạt sĩ số tối đa.");
                else
                {
                    //Lưu giá trị mã lớp với mã năm học trước khi vào form lập danh sách
                    bienToanCuc.chonMaLop = comboBox2.SelectedValue.ToString();
                    bienToanCuc.chonMaNamHoc = comboBox3.SelectedValue.ToString();
                    lapdanhsach f = new lapdanhsach();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    loadGrid();     //Cập nhật lại gridview sau khi thoát khỏi form lập danh sách
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Event chọn combobox năm học
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do mỗi năm học có số lớp khác nhau nên phải cập nhật lại combobox lớp
            try
            {
                String maKhoi = comboBox1.SelectedValue.ToString();
                String maNamHoc = comboBox3.SelectedValue.ToString();

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM LOP WHERE MaKhoi = '" + maKhoi + "' AND MaNamHoc = '" + maNamHoc + "'", connection);
                DataSet dts2 = new DataSet();
                adapter2.Fill(dts2, "LOP");
                comboBox2.DataSource = dts2.Tables[0];
                comboBox2.DisplayMember = "TenLop";
                comboBox2.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        //Event nút hiển thị danh sách
        private void button2_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        //Load danh sách học sinh của lớp lên gridview
        private void loadGrid()
        {
            //Lưu giá trị đặt điều kiện cho select dữ liệu lên gridview
            string maLop = comboBox2.SelectedValue.ToString();
            try
            {
                //Load lên gridview
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT hs.MaHocSinh as STT, HoTen as 'Họ Tên', GioiTinh as 'Giới Tính', NgaySinh as 'Năm Sinh', DiaChi as 'Địa Chỉ' FROM HOCSINH hs, DANHSACHHOCSINH ds WHERE hs.MaHocSinh = ds.MaHocSinh AND MaLop = '" + maLop + "'", connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewClass.DataSource = tb;

                //Đánh số thứ tự ở cột đầu tiên
                for (int i = 0; i < dataGridViewClass.Rows.Count - 1; i++)
                {
                    dataGridViewClass.Rows[i].Cells[0].Value = i + 1;
                }

                //Load dữ liệu sĩ số và tên lớp lên textbox
                SqlCommand cmd = new SqlCommand("SELECT TenLop, SiSo FROM LOP WHERE MaLop = '" + maLop + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader.GetString(0).ToString();
                    textBox2.Text = reader[1].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Event nút thoát
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //Biến toàn cục để sử dụng cho form sau, mục đích lưu vào database
    public class bienToanCuc
    {
        public static string chonMaLop;
        public static string chonMaNamHoc;
    }

}
