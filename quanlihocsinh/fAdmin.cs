using Login.DAO;
using Login.DTO;
using quanlihocsinh.DAO;
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
    public partial class fAdmin : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fAdmin(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            //LoadAccountList();
        }

        void LoadAccountList()
        {
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery("SELECT TenDangNhap as [Tên Đăng Nhập],MatKhau as [Mật Khẩu], LoaiNguoiDung as [Loại Người Dùng] FROM NGUOIDUNG");
            //txbID.Text = dtgvAccount.Rows.Cells[0];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            fAddAccount f = new fAddAccount();
            this.Hide();
            f.ShowDialog();
            LoadAccountList();
            this.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            //string a = loginAccount.TenDangNhap.ToString();
            if (txbID.Text.Equals(loginAccount.TenDangNhap))
            {
                MessageBox.Show("Bạn không được phép xóa chính mình.");
            }
            else
            {
                if (AccountDAO.Instance.DeleteAccount(txbID.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
            }
            LoadAccountList();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.ChangeTypeByUsername(txbID.Text,(int)numUpDown.Value))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            LoadAccountList();
        }
        /*
        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvAccount.Rows[e.RowIndex];
           
                txbID.Text = row.Cells["Tên Đăng Nhập"].Value.ToString();
                
                numUpDown.Value = (int)row.Cells["Loại Người Dùng"].Value;
            }
        }
        */
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvAccount.Rows[e.RowIndex];

                txbID.Text = row.Cells["Tên Đăng Nhập"].Value.ToString();

                numUpDown.Value = (int)row.Cells["Loại Người Dùng"].Value;
            }
        }
    }
}
