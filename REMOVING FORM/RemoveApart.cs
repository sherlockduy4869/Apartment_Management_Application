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
    public partial class RemoveApart : Form
    {
        public RemoveApart()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string maCanHo = txbMaCanHo.Text;

            try
            {

                int i = AdminDAL.Instance.removeApartment(maCanHo);

                if (i != 0)
                {
                    txbMaCanHo.Text = String.Empty;
                    MessageBox.Show("Removed");
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
