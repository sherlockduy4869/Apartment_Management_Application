﻿using QuanlyCanHoGiangTran.DAL;
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
    public partial class ShowInfoApart : Form
    {
        public ShowInfoApart()
        {
            InitializeComponent();
            showInforAllApart();
        }

        void showInforAllApart()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_INFO");
            this.dtgvApartInfo.Sort(this.dtgvApartInfo.Columns["STT"], ListSortDirection.Ascending);
            dtgvApartInfo.Columns["TIENTHU"].DefaultCellStyle.Format = "N2";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApart addNewApart = new AddNewApart();
            this.Hide();
            addNewApart.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApart removeApart = new RemoveApart();
            removeApart.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowInfoApart showInfoApart = new ShowInfoApart();
            showInfoApart.Show();
        }
    }
}
