using QuanlyCanHoGiangTran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran
{
    public partial class AddNewApart : Form
    {
        public AddNewApart()
        {
            InitializeComponent();
            listChuKy();
        }

        void listChuKy()
        {
            List<int> listChuKy = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                listChuKy.Add(i);
            }
            cbChuKy.DataSource = listChuKy;

            
        }


        void clearInfo()
        {
            txbMaCanHo.Text = string.Empty;
            txbTenChuHo.Text = string.Empty;
            txbMaSoThue.Text = string.Empty;
            txbHTKhaiThue.Text = string.Empty;
            txbCQThuThue.Text = string.Empty;
            txbThue.Text = string.Empty;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string maCanHo = txbMaCanHo.Text;
            string tenChuHo = txbTenChuHo.Text;
            string maSoThue = txbMaSoThue.Text;
            string hinhThucKT = txbHTKhaiThue.Text;
            string coQuanTT = txbCQThuThue.Text;
            float tienThu = float.Parse(txbThue.Text, CultureInfo.InvariantCulture.NumberFormat);
            string chuKy = cbChuKy.Text;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string ngayStart = dtpkStart.Value.ToString();
            string ngayEnd = dtpkEnd.Value.ToString();


            int i = AdminDAL.Instance.addApartment(maCanHo, tenChuHo, maSoThue, hinhThucKT, coQuanTT, tienThu, chuKy, ngayStart, ngayEnd);

            try
            {
                if (i != 0)
                {
                    clearInfo();
                    MessageBox.Show("Added");
                    ShowInfoApart showInfoApart = new ShowInfoApart();
                    showInfoApart.Show();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }

        }

        private void txbThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;

        }

        private void txbThue_Leave(object sender, EventArgs e)
        {
            txbThue.Text = string.Format("{0:n}", double.Parse(txbThue.Text));
        }
    }
    
}
