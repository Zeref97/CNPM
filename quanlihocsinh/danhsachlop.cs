using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlihocsinh
{
    public partial class danhsachlop : Form
    {
        public danhsachlop()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX7_Click(object sender, EventArgs e)
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
        }
    }
}
