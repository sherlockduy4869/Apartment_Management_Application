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
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            ShowInfoTax showInfoTax = new ShowInfoTax();
            showInfoTax.Show();
        }
    }
}
