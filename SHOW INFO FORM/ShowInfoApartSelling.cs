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
    public partial class ShowInfoApartSelling : Form
    {
        public ShowInfoApartSelling()
        {
            InitializeComponent();
            listApartTax();
        }

        void listApartTax()
        {

            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_SELLING");
            dtgvApartInfo.Columns["GIATIENUSD"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["GIATIENVND"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["NGAYNHAPDATA"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_SELLING WHERE MACANHO LIKE '" + txbSearch.Text + "%'");
            dtgvApartInfo.Columns["GIATIENUSD"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["GIATIENVND"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["NGAYNHAPDATA"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartSelling addNewApartSelling = new AddNewApartSelling();
            this.Hide();
            addNewApartSelling.ShowDialog();
            this.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartSelling removeApartSelling = new RemoveApartSelling();
            removeApartSelling.Show();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowInfoApartSelling showInfoApartSelling = new ShowInfoApartSelling();
            showInfoApartSelling.Show();
            this.Close();
        }

        private void ShowInfoApartSelling_Load(object sender, EventArgs e)
        {

        }
    }
}
