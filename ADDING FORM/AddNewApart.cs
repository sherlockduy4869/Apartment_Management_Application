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
        private float tienThu;
        public AddNewApart()
        {
            InitializeComponent();
            listAllComboBox();
            calculateTienThu();
        }

        void listAllComboBox()
        {
            List<int> listChuKy = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                listChuKy.Add(i);
            }
            cbChuKy.DataSource = listChuKy;

            List<string> listTinhTrang = new List<string>();
            string[] arrayListTinhTrang = { "Mới bán", "Chưa nhận bàn giao nhà", "Đã nhận bàn giao nhà", "Đang cho thuê", "Đang available cho thuê" };
            foreach (string str in arrayListTinhTrang)
            {
                listTinhTrang.Add(str);
            }
            cbTinhTrang.DataSource = listTinhTrang;

            List<string> listDuAn = new List<string>();
            string[] arrayListDuAn = { "Vinhomes Golden River", "Vinhomes Central Park", "Estella Height", "Estella", "The Vista", "Celesta" };
            foreach (string str in arrayListDuAn)
            {
                listDuAn.Add(str);
            }
            cbDuAn.DataSource = listDuAn;

            List<int> listNhacNho = new List<int>();
            int[] arrayNhacNho = { 10, 15, 20, 25, 30, 45, 60, 75, 90 };
            foreach (int num in arrayNhacNho)
            {
                listNhacNho.Add(num);
            }
            cbSoNgayNhac.DataSource = listNhacNho;

        }

        void calculateTienThu()
        {
            tienThu = 0;
            txbTienThu.Text = tienThu.ToString("N");
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
            string tinhTrang = cbTinhTrang.Text;
            string tenChuHo = txbTenChuHo.Text;
            string maSoThue = txbMaSoThue.Text;
            string hinhThucKT = txbHTKhaiThue.Text;
            string coQuanTT = txbCQThuThue.Text;

            float thue = float.Parse(txbThue.Text, CultureInfo.InvariantCulture.NumberFormat);
            float phiKeKhaiThue = float.Parse(txbPhiKeKhaiThue.Text, CultureInfo.InvariantCulture.NumberFormat);
            float phiQuanly = float.Parse(txbPhiQuanLy.Text, CultureInfo.InvariantCulture.NumberFormat);
            float tienReFundKhach = float.Parse(txbTienRefund.Text, CultureInfo.InvariantCulture.NumberFormat);
            float phiDonVeSinh = float.Parse(txbPhiDonVeSinh.Text, CultureInfo.InvariantCulture.NumberFormat);
            float tienThu = float.Parse(txbTienThu.Text, CultureInfo.InvariantCulture.NumberFormat);

            string duAn = cbDuAn.Text;
            int chuKy = Int32.Parse(cbChuKy.Text);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string ngayStart = dtpkStart.Value.ToString();
            string ngayEnd = dtpkEnd.Value.ToString();

            int soNgayNhacNho = Int32.Parse(cbSoNgayNhac.Text);


            int i = AdminDAL.Instance.addApartment(maCanHo, duAn, tenChuHo, maSoThue, hinhThucKT, coQuanTT, tinhTrang,
                                                    thue, phiKeKhaiThue, phiQuanly, tienReFundKhach, phiDonVeSinh,
                                                    tienThu, chuKy, ngayStart, ngayEnd, soNgayNhacNho);

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
            tienThu = tienThu + float.Parse(txbThue.Text);
            txbTienThu.Text = tienThu.ToString("N");
        }

        private void txbThue_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbThue.Text);
            txbTienThu.Text = tienThu.ToString("N");
            txbThue.Clear();
        }

        private void txbPhiKeKhaiThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiKeKhaiThue_Leave(object sender, EventArgs e)
        {
            txbPhiKeKhaiThue.Text = string.Format("{0:n}", double.Parse(txbPhiKeKhaiThue.Text));
            tienThu = tienThu + float.Parse(txbPhiKeKhaiThue.Text);
            txbTienThu.Text = tienThu.ToString("N");
        }

        private void txbPhiKeKhaiThue_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiKeKhaiThue.Text);
            txbTienThu.Text = tienThu.ToString("N");
            txbPhiKeKhaiThue.Clear();
        }

        private void txbPhiQuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiQuanLy_Leave(object sender, EventArgs e)
        {
            txbPhiQuanLy.Text = string.Format("{0:n}", double.Parse(txbPhiQuanLy.Text));
            tienThu = tienThu + float.Parse(txbPhiQuanLy.Text);
            txbTienThu.Text = tienThu.ToString("N");
        }

        private void txbPhiQuanLy_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiQuanLy.Text);
            txbTienThu.Text = tienThu.ToString("N");
            txbPhiQuanLy.Clear();
        }

        private void txbTienRefund_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbTienRefund_Leave(object sender, EventArgs e)
        {
            txbTienRefund.Text = string.Format("{0:n}", double.Parse(txbTienRefund.Text));
            tienThu = tienThu + float.Parse(txbTienRefund.Text);
            txbTienThu.Text = tienThu.ToString("N");
        }

        private void txbTienRefund_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbTienRefund.Text);
            txbTienThu.Text = tienThu.ToString("N");
            txbTienRefund.Clear();
        }

        private void txbPhiDonVeSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiDonVeSinh_Leave(object sender, EventArgs e)
        {
            txbPhiDonVeSinh.Text = string.Format("{0:n}", double.Parse(txbPhiDonVeSinh.Text));
            tienThu = tienThu + float.Parse(txbPhiDonVeSinh.Text);
            txbTienThu.Text = tienThu.ToString("N");
        }

        private void txbPhiDonVeSinh_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiDonVeSinh.Text);
            txbTienThu.Text = tienThu.ToString("N");
            txbPhiDonVeSinh.Clear();
        }
    }

}