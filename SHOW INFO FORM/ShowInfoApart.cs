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
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,EMAIL,PHONE,DUAN,TINHTRANG,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU,NGAYBATDAU,NGAYKETTHUC FROM APARTMENT_INFO");
            //this.dtgvApartInfo.Sort(this.dtgvApartInfo.Columns["STT"], ListSortDirection.Ascending);
            dtgvApartInfo.Columns["THUE"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIKEKHAITHUE"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIQUANLY"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["TIENREFUNDKHACH"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIDONVESINH"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["TIENTHU"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["NGAYBATDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvApartInfo.Columns["NGAYKETTHUC"].DefaultCellStyle.Format = "dd-MM-yyyy";
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

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DUAN,TINHTRANG,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,TIENTHU,PHIDONVESINH,NGAYBATDAU,NGAYKETTHUC FROM APARTMENT_INFO WHERE MACANHO LIKE '" + txbSearch.Text + "%'");
            //this.dtgvApartInfo.Sort(this.dtgvApartInfo.Columns["STT"], ListSortDirection.Ascending);
            dtgvApartInfo.Columns["THUE"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["PHIKEKHAITHUE"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["PHIQUANLY"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["TIENREFUNDKHACH"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["PHIDONVESINH"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["TIENTHU"].DefaultCellStyle.Format = "N2";
            dtgvApartInfo.Columns["NGAYBATDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvApartInfo.Columns["NGAYKETTHUC"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
    }
}
