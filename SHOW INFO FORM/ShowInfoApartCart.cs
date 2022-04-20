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
            designDatagridview();
        }

        void listApartTax()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_CART WHERE STATUS = 'AVAILABLE'");
        }

        void designDatagridview()
        {
            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";

            foreach (DataGridViewColumn col in dtgvApartInfo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 28F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_CART WHERE STATUS = 'AVAILABLE'");
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_CART WHERE STATUS = 'AVAILABLE' AND MACANHO LIKE '" + txbSearch.Text + "%'");
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

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
