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
        }

        void listApartNegotiate()
        {
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-08-15";

            dtgvNegotiateApart.DataSource = DataProvider.Instance.ExecuteQuery("SELECT STT,TENCHUHO,MACANHO,NGAYBATDAU,NGAYKETTHUC,CHUKY, STATUS FROM APARTMENT_CONTRACT " +
                                                                                "WHERE NGAYNHAC <= '" + toDay + "' AND '" + toDay + "' <= NGAYKETTHUC");
            dtgvNegotiateApart.Columns["NGAYBATDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvNegotiateApart.Columns["NGAYKETTHUC"].DefaultCellStyle.Format = "dd-MM-yyyy";
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
    }
}
