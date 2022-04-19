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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            WindowState = FormWindowState.Maximized;
        }

        private void btnApart_Click(object sender, EventArgs e)
        {
            ShowInfoApart showInfoApart = new ShowInfoApart();
            showInfoApart.Show();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            ShowInfoTax showInfoTax = new ShowInfoTax();
            showInfoTax.Show();
        }

        private void btnNegotiation_Click(object sender, EventArgs e)
        {
            Negotiation negotiation = new Negotiation();
            negotiation.Show();
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

        private void btnCart_Click(object sender, EventArgs e)
        {
            ShowInfoApartCart showInfoApartCart = new ShowInfoApartCart();
            showInfoApartCart.Show();
        }
    }
}
