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
        public ShowInformationDetail()
        {
            InitializeComponent();
        }

        public ShowInformationDetail(string maCanHo, string duAn, string tenChuHo, string maSoThue,
                                string hinhThucKT, string coQuanTT, string tinhTrang, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, int chuKy, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            InitializeComponent();
            txbMaCanHo.Text = maCanHo;
            txbDuAn.Text = duAn;
            txbTenChuHo.Text = tenChuHo;
            txbMaSoThue.Text = maSoThue;
            txbHTKhaiThue.Text = hinhThucKT;
            txbCQThuThue.Text = coQuanTT;
            txbTinhTrang.Text = tinhTrang;
            txbThue.Text = thue.ToString();
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString();
            txbPhiQuanLy.Text = phiQuanLy.ToString();
            txbTienRefund.Text = tienReFundKhach.ToString();
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString();
            txbTienThu.Text = tienThu.ToString();
            txbChuKy.Text = chuKy.ToString();
            dtpkStart.Value = ngayBatDau;
            dtpkEnd.Value = ngayKetThuc;
        }

    }
}
