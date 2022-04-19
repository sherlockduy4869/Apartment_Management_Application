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
        private float tienThu = 0;

        private float thue = 0;
        private float phiKeKhaiThue = 0;
        private float phiQuanly = 0;
        private float tienReFundKhach = 0;
        private float phiDonVeSinh = 0;
        private float tienThue1Thang = 0;

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

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string maCanHo = txbMaCanHo.Text;
            string tenChuHo = txbTenChuHo.Text;
            string daiLy = txbDaiLy.Text;
            string email = txbEmail.Text;
            string phone = txbPhone.Text;
            string maSoThue = txbMaSoThue.Text;
            string hinhThucKT = txbHTKhaiThue.Text;
            string coQuanTT = txbCQThuThue.Text;

            

            thue = float.Parse(txbThue.Text, CultureInfo.InvariantCulture.NumberFormat);
            phiKeKhaiThue = float.Parse(txbPhiKeKhaiThue.Text, CultureInfo.InvariantCulture.NumberFormat);
            phiQuanly = float.Parse(txbPhiQuanLy.Text, CultureInfo.InvariantCulture.NumberFormat);
            tienReFundKhach = float.Parse(txbTienRefund.Text, CultureInfo.InvariantCulture.NumberFormat);
            phiDonVeSinh = float.Parse(txbPhiDonVeSinh.Text, CultureInfo.InvariantCulture.NumberFormat);
            tienThu = float.Parse(txbTienThu.Text, CultureInfo.InvariantCulture.NumberFormat);
            tienThue1Thang = float.Parse(txbTienthue1thang.Text, CultureInfo.InvariantCulture.NumberFormat);

            string duAn = cbDuAn.Text;
            int chuKy = Int32.Parse(cbChuKy.Text);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string ngayStart = dtpkStart.Value.ToString();
            string ngayEnd = dtpkEnd.Value.ToString();

            int soNgayNhacNho = Int32.Parse(cbSoNgayNhac.Text);



            int i = AdminDAL.Instance.addApartment(maCanHo, duAn, tenChuHo, maSoThue, hinhThucKT, coQuanTT, 
                                                    thue, phiKeKhaiThue, phiQuanly, tienReFundKhach, phiDonVeSinh,
                                                    tienThu, tienThue1Thang, chuKy, ngayStart, ngayEnd, soNgayNhacNho, daiLy, email, phone);

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

        private void txbThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;

        }

        private void txbThue_Leave(object sender, EventArgs e)
        {
            txbThue.Text = double.Parse(txbThue.Text).ToString("N0");
            tienThu = tienThu + float.Parse(txbThue.Text);
            txbTienThu.Text = tienThu.ToString("N0");
        }

        private void txbThue_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbThue.Text);
            txbTienThu.Text = tienThu.ToString("N0");
            txbThue.Clear();
        }

        private void txbPhiKeKhaiThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiKeKhaiThue_Leave(object sender, EventArgs e)
        {
            txbPhiKeKhaiThue.Text = double.Parse(txbPhiKeKhaiThue.Text).ToString("N0");
            tienThu = tienThu + float.Parse(txbPhiKeKhaiThue.Text);
            txbTienThu.Text = tienThu.ToString("N0");
        }

        private void txbPhiKeKhaiThue_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiKeKhaiThue.Text);
            txbTienThu.Text = tienThu.ToString("N0");
            txbPhiKeKhaiThue.Clear();
        }

        private void txbPhiQuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiQuanLy_Leave(object sender, EventArgs e)
        {
            txbPhiQuanLy.Text = double.Parse(txbPhiQuanLy.Text).ToString("N0");
            tienThu = tienThu + float.Parse(txbPhiQuanLy.Text);
            txbTienThu.Text = tienThu.ToString("N0");
        }

        private void txbPhiQuanLy_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiQuanLy.Text);
            txbTienThu.Text = tienThu.ToString("N0");
            txbPhiQuanLy.Clear();
        }

        private void txbTienRefund_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbTienRefund_Leave(object sender, EventArgs e)
        {
            txbTienRefund.Text = double.Parse(txbTienRefund.Text).ToString("N0");
            tienThu = tienThu + float.Parse(txbTienRefund.Text);
            txbTienThu.Text = tienThu.ToString("N0");
        }

        private void txbTienRefund_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbTienRefund.Text);
            txbTienThu.Text = tienThu.ToString("N0");
            txbTienRefund.Clear();
        }

        private void txbPhiDonVeSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbPhiDonVeSinh_Leave(object sender, EventArgs e)
        {
            txbPhiDonVeSinh.Text = double.Parse(txbPhiDonVeSinh.Text).ToString("N0");
            tienThu = tienThu + float.Parse(txbPhiDonVeSinh.Text);
            txbTienThu.Text = tienThu.ToString("N0");
        }

        private void txbPhiDonVeSinh_Click(object sender, EventArgs e)
        {
            tienThu = tienThu - float.Parse(txbPhiDonVeSinh.Text);
            txbTienThu.Text = tienThu.ToString("N0");
            txbPhiDonVeSinh.Clear();
        }

        private void txbTienthue1thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txbTienthue1thang_Leave(object sender, EventArgs e)
        {
            
            
            txbTienthue1thang.Text = double.Parse(txbTienthue1thang.Text).ToString("N0");
            
            
        }

        private void txbTienthue1thang_Click(object sender, EventArgs e)
        {
            txbTienthue1thang.Clear();
        }
    }

}