using QuanlyCanHoGiangTran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool Loginn(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (Loginn(userName, passWord) == true)
            {
                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong UserName or PassWord, please re-enter again");
            }
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
