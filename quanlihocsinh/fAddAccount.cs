using Login.DAO;
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
    public partial class fAddAccount : Form
    {
        public fAddAccount()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            string password = textBox1.Text;
            string reenter = textBox2.Text;
            int type = (int)numUpDown.Value;
            //if()
            if(!password.Equals(reenter))
            {
                MessageBox.Show("Mật khẩu không trùng khớp.");
            }
           
            if (AccountDAO.Instance.InsertAccount(username, password, type))
            {
                txbID.ResetText();
                textBox1.ResetText();
                textBox2.ResetText();
                numUpDown.ResetText();
                MessageBox.Show("Tạo tài khoản thành công.");
                
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
