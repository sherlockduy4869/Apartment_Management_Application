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
    public partial class ExpireApart : Form
    {
        public ExpireApart()
        {
            InitializeComponent();
        }

        private void btnExpireApart_Click(object sender, EventArgs e)
        {
            string maCanHo = txbMaCanHo.Text;

            try
            {

                int i = AdminDAL.Instance.expireApart(maCanHo);

                if (i != 0)
                {
                    txbMaCanHo.Text = String.Empty;
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
    }
}
