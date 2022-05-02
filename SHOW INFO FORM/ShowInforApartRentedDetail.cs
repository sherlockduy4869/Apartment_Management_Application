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
    public partial class ShowInforApartRentedDetail : Form
    {
        public ShowInforApartRentedDetail()
        {
            InitializeComponent();
        }

        public ShowInforApartRentedDetail(string maCanHo, string duAn, string daiLy,string tenChuHo, string email, string phone,string maSoThue, string hinhThucKhaiThue
                                          , string coQuanThuThue, int chuKy, double tienThueMotThang, double thue, double phiKeKhaiThue,
                                          double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu,  DateTime ngayBatDau, DateTime ngayKetThuc, int soNgayNhacNho )
        {
            InitializeComponent();

            txbMaCanHo.Text = maCanHo;
            txbDuAn.Text = duAn;
            txbDaiLy.Text = daiLy;  
            txbTenChuHo.Text = tenChuHo;

            txbEmail.Text = email;
            txbPhone.Text = phone;
            txbMaSoThue.Text = maSoThue;
            txbHTKhaiThue.Text = hinhThucKhaiThue;

            txbCQThuThue.Text = coQuanThuThue;
            txbChuKy.Text = chuKy.ToString("N0");
            txbTienthue1thang.Text = tienThueMotThang.ToString("N0");
            txbThue.Text = thue.ToString("N0");

            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N0");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N0");
            txbTienRefund.Text = tienReFundKhach.ToString("N0");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N0");

            txbTienThu.Text = tienThu.ToString("N0");
            dtpkStart.Value = ngayBatDau;
            dtpkEnd.Value = ngayKetThuc;
            txbSoNgayNhacNho.Text = soNgayNhacNho.ToString("N0");

        }
    }
}
