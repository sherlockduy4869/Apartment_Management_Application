using QuanlyCanHoGiangTran.DAL;
using QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM;
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
            //listApartTax();
            //designDatagridview();
        }

        void listApartTax()
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-06-10";

            dtgvApartTax.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_MONEY WHERE (NGAYDAU <= '" + toDay + "' AND '" + toDay + "' <= NGAYCUOI) " +
                                                                         "OR ('" + toDay + "' >= NGAYCUOI)");
        }

        void designDatagridview()
        {
            //Formart data showing for datagridview
            dtgvApartTax.Columns["TIENCANTHU"].DefaultCellStyle.Format = "N0";
            dtgvApartTax.Columns["NGAYDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvApartTax.Columns["NGAYCUOI"].DefaultCellStyle.Format = "dd-MM-yyyy";

            //Change column's name for datagridview
            dtgvApartTax.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartTax.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartTax.Columns["EMAIL"].HeaderText = "EMAIL";
            dtgvApartTax.Columns["PHONE"].HeaderText = "PHONE";
            dtgvApartTax.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartTax.Columns["DUAN"].HeaderText = "AREA";
            dtgvApartTax.Columns["NGAYDAU"].HeaderText = "FROM";
            dtgvApartTax.Columns["NGAYCUOI"].HeaderText = "TO";
            dtgvApartTax.Columns["CHUKY"].HeaderText = "PAYMENT TERM";
            dtgvApartTax.Columns["TIENCANTHU"].HeaderText = "TOTAL AMOUNT";
            dtgvApartTax.Columns["TRANGTHAI"].HeaderText = "STATUS";

            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvApartTax.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-06-10";

            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartTax.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_MONEY WHERE ((NGAYDAU <= '" + toDay + "' AND '" + toDay + "' <= NGAYCUOI) " +
                                                                         "OR ('" + toDay + "' >= NGAYCUOI)) AND MACANHO LIKE '" + txbSearch.Text + "%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-06-10";

            dtgvApartTax.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_MONEY WHERE (NGAYDAU <= '" + toDay + "' AND '" + toDay + "' <= NGAYCUOI) " +
                                                                         "OR ('" + toDay + "' >= NGAYCUOI)");
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

        private void btnNextCycle_Click(object sender, EventArgs e)
        {
            NextCycle nextCycle = new NextCycle();
            nextCycle.Show();
        }

        private void dtgvApartTax_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvApartTax.Rows)
            {
                string trangThai = Convert.ToString(row.Cells["TRANGTHAI"].Value);

                if (trangThai == "Da thu tien")
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 174, 114);
                }

            }
        }

        private void btnFinanceDetail_Click(object sender, EventArgs e)
        {
            FinanceDetail detailFinance = new FinanceDetail();
            detailFinance.Show();
        }

        private void btnInformationDetail_Click(object sender, EventArgs e)
        {
            InformationDetail informationDetail = new InformationDetail();
            informationDetail.Show();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
