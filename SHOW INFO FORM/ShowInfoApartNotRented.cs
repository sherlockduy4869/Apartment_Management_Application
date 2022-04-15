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
    public partial class ShowInfoApartNotRented : Form
    {
        public ShowInfoApartNotRented()
        {
            InitializeComponent();
            listApartTax();
        }

        void listApartTax()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED WHERE MACANHO LIKE '" + txbSearch.Text + "%' ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartNotRented addNewApartNotRented = new AddNewApartNotRented();
            addNewApartNotRented.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartNotRented removeApartNotRented = new RemoveApartNotRented();
            removeApartNotRented.Show();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }
    }
}
