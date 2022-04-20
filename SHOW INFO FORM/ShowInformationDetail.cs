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

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInformationDetail_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void ShowInformationDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void ShowInformationDetail_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
