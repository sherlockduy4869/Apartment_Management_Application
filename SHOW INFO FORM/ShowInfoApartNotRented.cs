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
            //listApartTax();
            //designDatagridview();
        }

        void listApartTax()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED WHERE MACANHO LIKE '" + txbSearch.Text + "%' ");
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }
        void designDatagridview()
        {
            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";
            dtgvApartInfo.Columns["TINHTRANG"].HeaderText = "STATUS";
            
            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvApartInfo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
