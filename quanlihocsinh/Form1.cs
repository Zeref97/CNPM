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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ???", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void msQuanli_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoCuốiKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocaotongketmon f = new Baocaotongketmon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsTiepNhan_Click(object sender, EventArgs e)
        {
            tiepnhanhocsinh f = new tiepnhanhocsinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachlop f = new danhsachlop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangdiem f = new bangdiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void báoCáoTổngKếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocaotongkethocki f = new Baocaotongkethocki();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void msTracuu_Click(object sender, EventArgs e)
        {
            tracuuhocsinh f = new tracuuhocsinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void msQuyDinh_Click(object sender, EventArgs e)
        {
            Quydinh f = new Quydinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
