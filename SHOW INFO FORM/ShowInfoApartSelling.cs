using QuanlyCanHoGiangTran.ADDING_FORM;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartSelling addNewApartSelling = new AddNewApartSelling();
            addNewApartSelling.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartSelling removeApartSelling = new RemoveApartSelling();
            removeApartSelling.Show();
        }
    }
}
