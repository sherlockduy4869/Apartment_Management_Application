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
    public partial class ShowInfoApartNotRented : Form
    {
        public ShowInfoApartNotRented()
        {
            InitializeComponent();
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
    }
}
