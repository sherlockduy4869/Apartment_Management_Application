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

namespace QuanlyCanHoGiangTran.ADDING_FORM
{
    public partial class AddNewApartSelling : Form
    {
        private float usdPrice = 0;
        private float vndPrice = 0;
        public AddNewApartSelling()
        {
            InitializeComponent();
            listAllComboBox();
        }
        void listAllComboBox()
        {

            List<string> listDuAn = new List<string>();
            string[] arrayListDuAn = { "Vinhomes Golden River", "Vinhomes Central Park", "Estella Height", "Estella", "The Vista", "Celesta" };
            foreach (string str in arrayListDuAn)
            {
                listDuAn.Add(str);
            }
            cbDuAn.DataSource = listDuAn;

            List<string> listTinhTrang = new List<string>();
            string[] arrayListTinhTrang = { "Đang bán", "Đã bán" };
            foreach (string str in arrayListTinhTrang)
            {
                listTinhTrang.Add(str);
            }
            cbTinhTrang.DataSource = listTinhTrang;

            List<string> listPhongNgu = new List<string>();
            string[] arrayListPhongNgu = { "1 PN", "2 PN", "2 PN + 1", "3 PN", "3 PN + 1", "4 PN", "4 PN + 1" };
            foreach (string str in arrayListPhongNgu)
            {
                listPhongNgu.Add(str);
            }
            cbSoPhongNgu.DataSource = listPhongNgu;

        }

        void clearInfo()
        {
            txbMaCanHo.Clear();
            txbTenChuHo.Clear();
            txbEmail.Clear();
            txbPhone.Clear();
            txbDaiLy.Clear();
            txbDienTich.Clear();
            txbGiaTienUSD.Clear();
            txbGiaTienVND.Clear();
            txbGhiChu.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            string maCanHo = txbMaCanHo.Text;
            string duan = cbDuAn.Text;
            string tinhTrang = cbTinhTrang.Text;
            string tenChuHo = txbTenChuHo.Text;
            string daiLy = txbDaiLy.Text;
            string email = txbEmail.Text;
            string phone = txbPhone.Text;
            string soPhongNgu = cbSoPhongNgu.Text;
            string dienTich = txbDienTich.Text;
            usdPrice = float.Parse(txbGiaTienUSD.Text, CultureInfo.InvariantCulture.NumberFormat);
            vndPrice = float.Parse(txbGiaTienVND.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ngayNhapData = dtpkNgayNhapData.Value.ToString();
            string ghiChu = txbGhiChu.Text;

            int i = AdminDAL.Instance.addApartmentSelling(maCanHo, tenChuHo, duan, tinhTrang, daiLy, email, phone,
                                                    soPhongNgu, dienTich, vndPrice, usdPrice, ngayNhapData, ghiChu);

            try
            {
                if (i != 0)
                {
                    clearInfo();
                    MessageBox.Show("Added");
                    
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

        private void txbGiaTienVND_Click(object sender, EventArgs e)
        {
            txbGiaTienVND.Clear();
        }

        private void txbGiaTienUSD_Click(object sender, EventArgs e)
        {
            txbGiaTienUSD.Clear();
        }

        private void txbGiaTienVND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbGiaTienUSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbGiaTienVND_Leave(object sender, EventArgs e)
        {
            txbGiaTienVND.Text = double.Parse(txbGiaTienVND.Text).ToString("N0");
        }

        private void txbGiaTienUSD_Leave(object sender, EventArgs e)
        {
            txbGiaTienUSD.Text = double.Parse(txbGiaTienUSD.Text).ToString("N0");
        }
    }
}
