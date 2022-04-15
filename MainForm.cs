using QuanlyCanHoGiangTran.SHOW_INFO_FORM;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnApart_Click(object sender, EventArgs e)
        {
            ShowInfoApart showInfoApart = new ShowInfoApart();
            showInfoApart.Show();
;
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            ShowInfoTax showInfoTax = new ShowInfoTax();
            showInfoTax.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void btnNegotiation_Click(object sender, EventArgs e)
        {
            Negotiation negotiation = new Negotiation();
            negotiation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnApartSelling_Click(object sender, EventArgs e)
        {
            ShowInfoApartSelling showInfoApartSelling = new ShowInfoApartSelling();
            showInfoApartSelling.Show();
        }

        private void btnApartNotRented_Click(object sender, EventArgs e)
        {
            ShowInfoApartNotRented showInfoApartNotRented = new ShowInfoApartNotRented();
            showInfoApartNotRented.Show();
        }
    }
}
