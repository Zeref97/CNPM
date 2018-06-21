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
            DateTime date1 = Convert.ToDateTime(dateTimeInput1.Text);
            DateTime date2 = DateTime.Now;
            TimeSpan time = date2.Subtract(date1);
            double year = time.Days/ 365.24 ;
            if (year >= bienToanCuc.tuoiToiThieu && year <= bienToanCuc.tuoiToiDa)
            {
                MessageBox.Show("Hợp lệ");
                this.Close();
            }
            else
                MessageBox.Show("Không hợp lệ");
        }
    }

}
