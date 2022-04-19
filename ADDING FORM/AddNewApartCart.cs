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

namespace QuanlyCanHoGiangTran.ADDING_FORM
{
    public partial class AddNewApartCart : Form
    {
        public AddNewApartCart()
        {
            InitializeComponent();
        }

        void clearInfo()
        {
            txbMaCanHo.Clear();
            txbTenChuHo.Clear();
            txbDaiLy.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maCanHo = txbMaCanHo.Text;
            string duan = cbDuAn.Text;
            string tenChuHo = txbTenChuHo.Text;
            string daiLy = txbDaiLy.Text;

            int i = AdminDAL.Instance.addApartmentCart(maCanHo, tenChuHo, duan, daiLy);

            try
            {
                if (i != 0)
                {
                    clearInfo();
                    MessageBox.Show("Added");

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
