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
            this.Hide();
            showInfoApart.ShowDialog();
            this.Show();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            ShowInfoTax showInfoTax = new ShowInfoTax();
            this.Hide();
            showInfoTax.ShowDialog();
            this.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.ShowDialog();
            this.Show();
        }
    }
}
