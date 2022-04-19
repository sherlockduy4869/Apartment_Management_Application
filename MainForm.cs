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

        private Form activeForm = null; //UI design
        private void openChildForm(Form childForm) //UI design
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            WindowState = FormWindowState.Maximized;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnHome.Height;
            pnCick.Top = btnHome.Top;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnApart_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnApart.Height; //UI design
            pnCick.Top = btnApart.Top; //UI design
            ShowInfoApart showInfoApart = new ShowInfoApart();
            openChildForm(showInfoApart);
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnTax.Height; //UI design
            pnCick.Top = btnTax.Top; //UI design
            ShowInfoTax showInfoTax = new ShowInfoTax();
            openChildForm(showInfoTax);
        }

        private void btnNegotiation_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnNegotiation.Height; //UI design
            pnCick.Top = btnNegotiation.Top; //UI design
            Negotiation negotiation = new Negotiation();
            openChildForm(negotiation);
        }

        private void btnApartSelling_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnApartSelling.Height; //UI design
            pnCick.Top = btnApartSelling.Top; //UI design
            ShowInfoApartSelling showInfoApartSelling = new ShowInfoApartSelling();
            openChildForm(showInfoApartSelling);
        }

        private void btnApartNotRented_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnApartNotRented.Height; //UI design
            pnCick.Top = btnApartNotRented.Top; //UI design
            ShowInfoApartNotRented showInfoApartNotRented = new ShowInfoApartNotRented();
            openChildForm(showInfoApartNotRented);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnCart.Height; //UI design
            pnCick.Top = btnCart.Top; //UI design
            ShowInfoApartCart showInfoApartCart = new ShowInfoApartCart();
            openChildForm(showInfoApartCart);
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            pnCick.Height = btnAdmin.Height; //UI design
            pnCick.Top = btnAdmin.Top; //UI design
            Admin admin = new Admin();
            openChildForm(admin);
        }

    }
}
