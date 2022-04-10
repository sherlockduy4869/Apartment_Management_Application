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

        public ShowInformationDetail(string maCanHo, string duAn, string tenChuHo, string maSoThue, double thue, double phiKeKhaiThue,
                                    double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu)
        {
            InitializeComponent();
            txbMaCanHo.Text = maCanHo;
            txbDuAn.Text = duAn;
            txbTenChuHo.Text = tenChuHo;
            txbMaSoThue.Text = maSoThue;
            txbThue.Text = thue.ToString("N");
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N");
            txbTienRefund.Text = tienReFundKhach.ToString("N");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N");
            txbTienThu.Text = tienThu.ToString("N");
        }
    }
}
