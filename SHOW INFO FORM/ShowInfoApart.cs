using ClosedXML.Excel;
using QuanlyCanHoGiangTran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanlyCanHoGiangTran
{
    public partial class ShowInfoApart : Form
    {
        public ShowInfoApart()
        {
            InitializeComponent();
            showInforAllApart();
            designDatagridview();
        }

        void showInforAllApart()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,NGAYBATDAU,NGAYKETTHUC,EMAIL,PHONE,DUAN,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU FROM APARTMENT_INFO");
        }

        void designDatagridview()
        {
            //Formart data showing for datagridview
            //this.dtgvApartInfo.Sort(this.dtgvApartInfo.Columns["STT"], ListSortDirection.Ascending);
            dtgvApartInfo.Columns["THUE"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIKEKHAITHUE"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIQUANLY"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["TIENREFUNDKHACH"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["PHIDONVESINH"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["TIENTHU"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["NGAYBATDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvApartInfo.Columns["NGAYKETTHUC"].DefaultCellStyle.Format = "dd-MM-yyyy";

            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["EMAIL"].HeaderText = "EMAIL";
            dtgvApartInfo.Columns["PHONE"].HeaderText = "PHONE";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";
            dtgvApartInfo.Columns["MASOTHUE"].HeaderText = "TAX CODE";
            dtgvApartInfo.Columns["HINHTHUCKHAITHUE"].HeaderText = "TAX DECLARATION FORM";
            dtgvApartInfo.Columns["COQUANTHUTHUE"].HeaderText = "TAX DEPARTMENT";
            dtgvApartInfo.Columns["THUE"].HeaderText = "TAX AMOUNT";
            dtgvApartInfo.Columns["PHIKEKHAITHUE"].HeaderText = "TAX DECLARE FEES";
            dtgvApartInfo.Columns["PHIQUANLY"].HeaderText = "MANAGEMENT FEE";
            dtgvApartInfo.Columns["TIENREFUNDKHACH"].HeaderText = "REFUND FOR TENANT";
            dtgvApartInfo.Columns["PHIDONVESINH"].HeaderText = "CLEANING FEE";
            dtgvApartInfo.Columns["TIENTHU"].HeaderText = "TOTAL AMOUNT";
            dtgvApartInfo.Columns["NGAYBATDAU"].HeaderText = "FROM";
            dtgvApartInfo.Columns["NGAYKETTHUC"].HeaderText = "TO";

            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvApartInfo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //col.HeaderCell.Style.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,NGAYBATDAU,NGAYKETTHUC,EMAIL,PHONE,DUAN,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU FROM APARTMENT_INFO WHERE MACANHO LIKE '" + txbSearch.Text + "%'");
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,NGAYBATDAU,NGAYKETTHUC,EMAIL,PHONE,DUAN,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU FROM APARTMENT_INFO");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,NGAYBATDAU,NGAYKETTHUC,EMAIL,PHONE,DUAN,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE," +
                                                                         "PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU FROM APARTMENT_INFO");
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddNewApart addNewApart = new AddNewApart();
            addNewApart.Show();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            AddNewApart addNewApart = new AddNewApart();
            addNewApart.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApart removeApart = new RemoveApart();
            removeApart.Show();
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            RemoveApart removeApart = new RemoveApart();
            removeApart.Show();
        }
    }
}
