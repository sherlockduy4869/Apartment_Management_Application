using PagedList;
using QuanlyCanHoGiangTran.ADDING_FORM;
using QuanlyCanHoGiangTran.DAL;
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
        private int start = 1;
        private int end = 2;

        public ShowInfoApartSelling()
        {
            InitializeComponent();
            listApartTax();
            designDatagridview();
        }
        void listApartTax()
        {
            //dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY STT) AS row FROM APARTMENT_SELLING) temp WHERE row >= '" + start + "'  AND row <= '" + end + "'");
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_SELLING");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_SELLING WHERE MACANHO LIKE '" + txbSearch.Text + "%'");
        }

        void designDatagridview()
        {
            //Formart data showing for datagridview
            dtgvApartInfo.Columns["GIATIENUSD"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["GIATIENVND"].DefaultCellStyle.Format = "N0";
            dtgvApartInfo.Columns["NGAYNHAPDATA"].DefaultCellStyle.Format = "dd-MM-yyyy";

            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["EMAIL"].HeaderText = "EMAIL";
            dtgvApartInfo.Columns["PHONE"].HeaderText = "PHONE";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";
            dtgvApartInfo.Columns["TINHTRANG"].HeaderText = "STATUS";
            dtgvApartInfo.Columns["SOPHONGNGU"].HeaderText = "BEDROOM";
            dtgvApartInfo.Columns["DIENTICH"].HeaderText = "SQM";
            dtgvApartInfo.Columns["GIATIENUSD"].HeaderText = "USD PRICE ";
            dtgvApartInfo.Columns["GIATIENVND"].HeaderText = "VND PRICE ";
            dtgvApartInfo.Columns["NGAYNHAPDATA"].HeaderText = "DATE";
            dtgvApartInfo.Columns["GHICHU"].HeaderText = "NOTE";

            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvApartInfo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartSelling addNewApartSelling = new AddNewApartSelling();
            this.Hide();
            addNewApartSelling.ShowDialog();
            this.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartSelling removeApartSelling = new RemoveApartSelling();
            removeApartSelling.Show();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowInfoApartSelling showInfoApartSelling = new ShowInfoApartSelling();
            showInfoApartSelling.Show();
            this.Close();
        }

        private void ShowInfoApartSelling_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            dtgvApartInfo.Size = new Size(w,h/2);

            
        }
        Bitmap bitmap;
        //private void btnPrint_Click(object sender, EventArgs e)
        //{
            //Panel panel = new Panel();
            //this.Controls.Add(panel);

            //Graphics g = panel.CreateGraphics();
            //Size size = this.ClientSize;
            //bitmap = new Bitmap(size.Width, size.Height, g);
            //g = Graphics.FromImage(bitmap);

            //Point point = PointToScreen(panel.Location);
            //g.CopyFromScreen(point.X, point.Y, 0, 0, size);

            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        //}

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
            //e.Graphics.DrawImage(bitmap, 0, 0);
        //}

        
    }
}
