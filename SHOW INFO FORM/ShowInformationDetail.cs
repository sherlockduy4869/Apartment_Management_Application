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
    public partial class ShowInformationDetail : Form
    {
        private double tienCanThu = 0;
        public ShowInformationDetail()
        {
            InitializeComponent();
        }

        public ShowInformationDetail(string maCanHo, string duAn, string tenChuHo, string maSoThue, double thue, double phiKeKhaiThue,
                                    double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, int chuKy, DateTime ngayDau, DateTime ngayCuoi)
        {
            InitializeComponent();
            txbMaCanHo.Text = maCanHo;
            txbDuAn.Text = duAn;
            txbTenChuHo.Text = tenChuHo;
            txbMaSoThue.Text = maSoThue;
            txbThue.Text = (thue*chuKy).ToString("N0");
            txbPhiKeKhaiThue.Text = (phiKeKhaiThue).ToString("N0");
            txbPhiQuanLy.Text = (phiQuanLy*chuKy).ToString("N0");
            txbTienRefund.Text = (tienReFundKhach*chuKy).ToString("N0");
            txbPhiDonVeSinh.Text = (phiDonVeSinh*chuKy).ToString("N0");
            tienCanThu = (tienThu - phiKeKhaiThue) * chuKy + phiKeKhaiThue;
            txbTienThu.Text = tienCanThu.ToString("N0");
            dtpkNgaydau.Value = ngayDau;
            dtpkNgaycuoi.Value = ngayCuoi;
        }

    }
}
