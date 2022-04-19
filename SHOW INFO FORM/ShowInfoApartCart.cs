using QuanlyCanHoGiangTran.ADDING_FORM;
using QuanlyCanHoGiangTran.DAL;
using QuanlyCanHoGiangTran.REMOVING_FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.SHOW_INFO_FORM
{
    public partial class ShowInfoApartCart : Form
    {
        public ShowInfoApartCart()
        {
            InitializeComponent();
            listApartTax();
        }

        void listApartTax()
        {

            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_CART");

            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_CART WHERE MACANHO LIKE '" + txbSearch.Text + "%'");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartCart addNewApartCart = new AddNewApartCart();
            addNewApartCart.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartCart removeApartCart  = new RemoveApartCart();
            removeApartCart.Show();
        }

        
    }
}
