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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            string password = txbPassword.Text;
            
            if (Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                
                
                txbPassword.ResetText();
                Form1 f = new Form1(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu.");
            }
        }

        private DataRow DataRow(DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
