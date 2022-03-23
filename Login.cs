using QuanlyCanHoGiangTran.DAL;

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
        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}