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
            listAllComboBox();
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
            string[] arrayListTinhTrang = { "Mới bán", "Chưa nhận bàn giao nhà", "Đã nhận bàn giao nhà", "Đang cho thuê", "Đang available cho thuê"};
            foreach(string str in arrayListTinhTrang)
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
            string chuKy = cbChuKy.Text;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string ngayStart = dtpkStart.Value.ToString();
            string ngayEnd = dtpkEnd.Value.ToString();


            int i = AdminDAL.Instance.addApartment(maCanHo, duAn, tenChuHo, maSoThue, hinhThucKT, coQuanTT, tinhTrang, 
                                                    thue, phiKeKhaiThue, phiQuanly, tienReFundKhach, phiDonVeSinh,
                                                    tienThu, chuKy, ngayStart, ngayEnd);

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
