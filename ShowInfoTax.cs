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
    public partial class ShowInfoTax : Form
    {
        public ShowInfoTax()
        {
            InitializeComponent();
            listApartTax();
        }

        void listApartTax()
        {
            string mon = DateTime.Now.Month.ToString();

            dtgvApartTax.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_MONEY WHERE MONTH(NGAYCANTHU) = '" + mon + "'");
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            MarkDone markDone = new MarkDone();
            markDone.Show();
        }

        private void btnReDo_Click(object sender, EventArgs e)
        {
            Redo redo = new Redo();
            redo.Show();
        }
    }
}