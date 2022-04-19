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

namespace QuanlyCanHoGiangTran.SHOW_INFO_FORM
{
    public partial class Negotiation : Form
    {
        public Negotiation()
        {
            InitializeComponent();
            listApartNegotiate();
            designDatagridview();
        }

        void listApartNegotiate()
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-12-15";

            dtgvNegotiateApart.DataSource = DataProvider.Instance.ExecuteQuery("SELECT TENCHUHO,DAILY,EMAIL,PHONE,MACANHO,DUAN,TIENTHUEMOTTHANG,NGAYBATDAU,NGAYKETTHUC,STATUS FROM APARTMENT_CONTRACT " +
                                                                                "WHERE NGAYNHAC <= '" + toDay + "' AND '" + toDay + "' <= NGAYKETTHUC");
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-12-15";

            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvNegotiateApart.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DAILY,EMAIL,PHONE,DUAN,TIENTHUEMOTTHANG,NGAYBATDAU,NGAYKETTHUC,STATUS FROM APARTMENT_CONTRACT " +
                                                                                "WHERE NGAYNHAC <= '" + toDay + "' AND '" + toDay + "' <= NGAYKETTHUC AND MACANHO LIKE '" + txbSearch.Text + "%'");
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-12-15";

            dtgvNegotiateApart.DataSource = DataProvider.Instance.ExecuteQuery("SELECT TENCHUHO,DAILY,EMAIL,PHONE,MACANHO,DUAN,TIENTHUEMOTTHANG,NGAYBATDAU,NGAYKETTHUC,STATUS FROM APARTMENT_CONTRACT " +
                                                                                "WHERE NGAYNHAC <= '" + toDay + "' AND '" + toDay + "' <= NGAYKETTHUC");
        }
        void designDatagridview()
        {
            //Formart data showing for datagridview
            dtgvNegotiateApart.Columns["NGAYBATDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvNegotiateApart.Columns["NGAYKETTHUC"].DefaultCellStyle.Format = "dd-MM-yyyy";

            //Change column's name for datagridview
            dtgvNegotiateApart.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvNegotiateApart.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvNegotiateApart.Columns["EMAIL"].HeaderText = "EMAIL";
            dtgvNegotiateApart.Columns["PHONE"].HeaderText = "PHONE";
            dtgvNegotiateApart.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvNegotiateApart.Columns["DUAN"].HeaderText = "AREA";
            dtgvNegotiateApart.Columns["TIENTHUEMOTTHANG"].HeaderText = "RENTING FEE PER MONTH";
            dtgvNegotiateApart.Columns["NGAYBATDAU"].HeaderText = "FROM";
            dtgvNegotiateApart.Columns["NGAYKETTHUC"].HeaderText = "TO";

            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvNegotiateApart.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DoneNegotiation doneNegotiation = new DoneNegotiation();
            doneNegotiation.Show();
        }

        private void btnRedoNegotiation_Click(object sender, EventArgs e)
        {
            ReDoNegotiation reDoNegotiation = new ReDoNegotiation();    
            reDoNegotiation.Show();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SkipNegotiation skipNegotiation = new SkipNegotiation();
            skipNegotiation.Show();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }
    }
}
