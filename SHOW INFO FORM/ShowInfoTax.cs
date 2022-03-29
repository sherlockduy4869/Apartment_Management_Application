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
            //string toDay = DateTime.UtcNow.Date.ToString();
            string toDay = "2022-05-15";

            dtgvApartTax.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_MONEY WHERE (NGAYDAU <= '" + toDay + "' AND '" + toDay + "' <= NGAYCUOI) OR ('" + toDay + "' >= NGAYCUOI AND TRANGTHAI = 'Chua thu tien' )");
            dtgvApartTax.Columns["TIENCANTHU"].DefaultCellStyle.Format = "N2";
            dtgvApartTax.Columns["NGAYDAU"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtgvApartTax.Columns["NGAYCUOI"].DefaultCellStyle.Format = "dd-MM-yyyy";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowInfoTax showInfoTax = new ShowInfoTax();
            showInfoTax.Show();
            
        }
    }
}
