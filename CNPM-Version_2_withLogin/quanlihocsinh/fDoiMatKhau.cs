using Login.DAO;
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
    public partial class fDoiMatKhau : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fDoiMatKhau(Account acc)
        {
            InitializeComponent();
            LoadFDoiMatKhau(acc.TenDangNhap);
        }
        void LoadFDoiMatKhau(string user)
        {
            txbID.Text = user;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            string oldpass = txbOldPass.Text;
            string newpass = txbNewPass.Text;
            string reenter = txbReEnter.Text;

            if (!reenter.Equals(newpass))
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không trùng nhau!");
            }

            if (AccountDAO.Instance.ChangePassByUsername(username, oldpass, newpass))
            {
                MessageBox.Show("Đối mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đối mật khẩu thất bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
