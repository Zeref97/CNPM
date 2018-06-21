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
    public partial class Quydinh : Form
    {
        public Quydinh()
        {
            InitializeComponent();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bienToanCuc.tuoiToiThieu = Convert.ToInt32(numericUpDown1.Value);
            bienToanCuc.tuoiToiThieu = Convert.ToInt32(numericUpDown2.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

    public class bienToanCuc
    {
        public static int tuoiToiThieu = 15;
        public static int tuoiToiDa = 18;
        public static int siSoToiDa = 40;
        public static int soLuongToiDa10 = 4;
        public static int soLuongToiDa11 = 3;
        public static int soLuongToiDa12 = 2;
    }
}
