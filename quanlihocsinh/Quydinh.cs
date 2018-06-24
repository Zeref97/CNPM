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
    public partial class Quydinh : Form
    {
        //kết nối database
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
                
        public Quydinh()
        {
            InitializeComponent();
            connection.Open(); //Mở kết nối database
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }


        //Event thay đổi tuổi tối thiểu và tuổi tối đa
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Truy vấn lấy thông tin trong database load lên grid, dùng 'N' đặt trước LIKE để search tên tiếng việt
                SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET TuoiToiThieu = '" + numericUpDownMinOld.Value + "', TuoiToiDa = '" + numericUpDownMaxOld.Value + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Event thoát form của tuổi
        private void button9_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        //Event thoát form của lớp
        private void button10_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        //Event thoát form của Môn học
        private void button11_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        //Event thoát form của Điểm
        private void button12_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        //Event thay đổi điểm đạt môn
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //Truy vấn lấy thông tin trong database load lên grid, dùng 'N' đặt trước LIKE để search tên tiếng việt
                SqlCommand cmd = new SqlCommand("UPDATE THAMSO SET DiemDatMon = '" + numericUpDownDiem.Value + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
