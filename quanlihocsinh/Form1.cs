using Login.DTO;
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

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public Form1(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            DisplayByUsername(acc.LoaiNguoiDung);


        }

        void DisplayByUsername(int type)  // tat ca nguoi dung duoc thay doi thong tin
        {
            if (type == 1) // giao vu duoc them hoc sinh, xep lop
            {
                adminToolStripMenuItem1.Enabled = false;
                msQuanli.Enabled = true;
                danhSáchToolStripMenuItem.Enabled = true;
                msBaoCao.Enabled = false;
                msQuyDinh.Enabled = false;
            }
            else if (type == 2) // giao vien duoc them diem va lap bao cao
            {
                adminToolStripMenuItem1.Enabled = false;
                msQuanli.Enabled = false;
                danhSáchToolStripMenuItem.Enabled = true;
                msBaoCao.Enabled = true;
                msQuyDinh.Enabled = false;
            }
            else if (type == 3) // admin va ban giam hieu
            {
                adminToolStripMenuItem1.Enabled = true;
                msQuanli.Enabled = true;
                danhSáchToolStripMenuItem.Enabled = true;
                msBaoCao.Enabled = true;
                msQuyDinh.Enabled = true;
            }
            else // hoc sinh va phu huynh chi duoc tra cuu 
            {
                adminToolStripMenuItem1.Enabled = false;
                msQuanli.Enabled = false;
                danhSáchToolStripMenuItem.Enabled = false;
                msBaoCao.Enabled = false;
                msQuyDinh.Enabled = false;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(loginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
            
        //}

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

        private void adminToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(loginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
