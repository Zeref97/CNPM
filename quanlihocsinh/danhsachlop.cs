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
  
    public partial class danhsachlop : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5BFQ4T;Initial Catalog=QuanLyHocSinh;Integrated Security=True");

        public danhsachlop()
        {
            InitializeComponent();
            connection.Open();
            this.loadDBComBox();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void buttonX7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Bạn chưa nhập sĩ số lớp");
            else
            {
                bool flag = true;
                char[] check = textBox1.Text.ToCharArray();
                for (int i = 0; i < textBox1.Text.Length; i++)
                    if ((int)check[i] < 48 || (int)check[i] > 57)
                    {
                        flag = false;
                        break;
                    }
                if (flag == false)
                    MessageBox.Show("Bạn nhập sai sĩ số lớp");
                else
                {
                    if (int.Parse(textBox1.Text) > bienToanCuc.siSoToiDa)
                        MessageBox.Show("Không hợp lệ");
                    else
                        MessageBox.Show("Hợp lệ");
                }
            }
        }*/

        private void danhsachlop_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'quanLyHocSinhDataSet.HOCSINH' table. You can move, or remove it, as needed.
this.hOCSINHTableAdapter.Fill(this.quanLyHocSinhDataSet.HOCSINH);
            // TODO: This line of code loads data into the 'quanLyHocSinhDataSet.DANHSACHHOCSINH' table. You can move, or remove it, as needed.
            this.dANHSACHHOCSINHTableAdapter.Fill(this.quanLyHocSinhDataSet.DANHSACHHOCSINH);

        }

        //Load combox from DB
        public void loadDBComBox()
        {
            try
            {
                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM NAMHOC", connection);
                DataSet dts3 = new DataSet();
                adapter3.Fill(dts3, "NAMHOC");
                comboBox3.DataSource = dts3.Tables[0];
                comboBox3.DisplayMember = "TenNamHoc";
                comboBox3.ValueMember = "MaNamHoc";

                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT MaKhoi, TenKhoi FROM KHOI", connection);
                DataSet dts1 = new DataSet();
                adapter1.Fill(dts1, "KHOI");
                comboBox1.DataSource = dts1.Tables[0];
                comboBox1.DisplayMember = "TenKhoi";
                comboBox1.ValueMember = "MaKhoi";

                String maKhoi = comboBox1.SelectedValue.ToString();
                String maNamHoc = comboBox3.SelectedValue.ToString();

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.loadDBComBox();
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

        //Load DataGirdView from DB
        private void buttonX7_Click(object sender, EventArgs e)
        {
            String maLop = comboBox2.SelectedValue.ToString();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaHocSinh, HoTen, GioiTinh, NgaySinh, DiaChi FROM HOCSINH WHERE MaHocSinh = (SELECT MaHocSinh FROM DANHSACHHOCSINH WHERE MaLop = '" +maLop +"')", connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewClass.DataSource = tb;

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
