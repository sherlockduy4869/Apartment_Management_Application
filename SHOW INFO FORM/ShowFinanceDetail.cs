using QuanlyCanHoGiangTran.DAL;
using QuanlyCanHoGiangTran.DTO;
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
    public partial class ShowFinanceDetail : Form
    {
        private string typeOfStatus = "";
        private int status = 0;
        private int final_status = 0;
        private double tongThu = 0;

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        public ShowFinanceDetail()
        {
            InitializeComponent();
            listFinanceCategory();
        }

        public ShowFinanceDetail(string maCanHo, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh,
                                string statusThue, string statusPhiKeKhaiThue, string statusPhiQuanLy, string statusTienReFundKhach
                                , string statusPhiDonVeSinh
                                , int chuKy, DateTime ngayDau, DateTime ngayCuoi, string trangThai)
        {
            InitializeComponent();
            listFinanceCategory();

            txbMaCanHo.Text = maCanHo;

            txbThue.Text = thue.ToString("N0");
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N0");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N0");
            txbTienRefundKhach.Text = tienReFundKhach.ToString("N0");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N0");


            lbThue.Text = statusThue;
            lbPhiKeKhaiThue.Text = statusPhiKeKhaiThue;
            lbPhiQuanLy.Text = statusPhiQuanLy;
            lbTienReFundKhach.Text = statusTienReFundKhach;
            lbPhidonvesinh.Text = statusPhiDonVeSinh;


            txbChuKy.Text = chuKy.ToString("N0");
            dtpkNgayDau.Value = ngayDau;
            dtpkNgayCuoi.Value = ngayCuoi;

            txbTongChi.Text = ((thue * Int32.Parse(statusThue)) + (phiKeKhaiThue * Int32.Parse(statusPhiKeKhaiThue)) + (phiQuanLy * Int32.Parse(statusPhiQuanLy)) +
                              (tienReFundKhach * Int32.Parse(statusTienReFundKhach)) + (phiDonVeSinh * Int32.Parse(statusPhiDonVeSinh))).ToString("N0");
            
            if(trangThai != "Chua thu tien")
            {
                tongThu = (thue + phiQuanLy + tienReFundKhach + phiDonVeSinh) * chuKy + phiKeKhaiThue;
            }
            
            txbTongThu.Text = tongThu.ToString("N0");

            txbBalance.Text = (double.Parse(txbTongThu.Text) - double.Parse(txbTongChi.Text)).ToString("N0");

        }

        void listFinanceCategory()
        {
            List<string> listFinanceCategory = new List<string>();
            string[] arrayListFinanceCategory = { "THUE", "PHIKEKHAITHUE", "PHIQUANLY", "TIENREFUNDKHACH", "PHIDONVESINH", "TIENTHU" };
            foreach (string str in arrayListFinanceCategory)
            {
                listFinanceCategory.Add(str);
            }
            cbFinanceCategory.DataSource = listFinanceCategory;


        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            string typeOfFee = cbFinanceCategory.Text;

            if (typeOfFee == "THUE")
            {
                int status = Int32.Parse(lbThue.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_THUE";
            }

            if (typeOfFee == "PHIKEKHAITHUE")
            {
                int status = Int32.Parse(lbPhiKeKhaiThue.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_PHIKEKHAITHUE";
            }

            if (typeOfFee == "PHIQUANLY")
            {
                int status = Int32.Parse(lbPhiQuanLy.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_PHIQUANLY";
            }

            if (typeOfFee == "TIENREFUNDKHACH")
            {
                int status = Int32.Parse(lbTienReFundKhach.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_TIENREFUNDKHACH";
            }

            if (typeOfFee == "PHIDONVESINH")
            {
                int status = Int32.Parse(lbPhidonvesinh.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_PHIDONVESINH";
            }

            try
            {
                int i = AdminDAL.Instance.markDoneFee(typeOfStatus, final_status, txbMaCanHo.Text);

                if (i != 0)
                {

                    MessageBox.Show("MarkDone");
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

        private void btnRedo_Click(object sender, EventArgs e)
        {

            string typeOfFee = cbFinanceCategory.Text;

            if (typeOfFee == "THUE")
            {
                int status = Int32.Parse(lbThue.Text);
                final_status = status - 1;
                typeOfStatus = "STATUS_THUE";
            }

            if (typeOfFee == "PHIKEKHAITHUE")
            {
                int status = Int32.Parse(lbPhiKeKhaiThue.Text);
                final_status = status - 1;
                typeOfStatus = "STATUS_PHIKEKHAITHUE";
            }

            if (typeOfFee == "PHIQUANLY")
            {
                int status = Int32.Parse(lbPhiQuanLy.Text);
                final_status = status - 1;
                typeOfStatus = "STATUS_PHIQUANLY";
            }

            if (typeOfFee == "TIENREFUNDKHACH")
            {
                int status = Int32.Parse(lbTienReFundKhach.Text);
                final_status = status - 1;
                typeOfStatus = "STATUS_TIENREFUNDKHACH";
            }

            if (typeOfFee == "PHIDONVESINH")
            {
                int status = Int32.Parse(lbPhidonvesinh.Text);
                final_status = status - 1;
                typeOfStatus = "STATUS_PHIDONVESINH";
            }

            try
            {
                if(final_status < 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    int i = AdminDAL.Instance.reDoFee(typeOfStatus, final_status, txbMaCanHo.Text);

                    if (i != 0)
                    {

                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            ApartmentFinance apartmentFinance = AdminDAL.Instance.getFinanceDetailByMaCanHo(txbMaCanHo.Text);
            Apartment apartment = AdminDAL.Instance.getApartmentByMaCanHo(txbMaCanHo.Text);
            ApartmentMoneyTax apartmentMoneyTax = AdminDAL.Instance.getApartmentMoneyByMaCanHo(txbMaCanHo.Text);


            ShowFinanceDetail showFinanceDetail = new ShowFinanceDetail(txbMaCanHo.Text, apartmentFinance.Thue, apartmentFinance.Phikekhaithue
                                                                        , apartmentFinance.Phiquanly, apartmentFinance.Tienrefundkhach, apartmentFinance.Phidonvesinh
                                                                        , apartmentFinance.Statusthue, apartmentFinance.Statusphikekhaithue
                                                                        , apartmentFinance.Statusphiquanly, apartmentFinance.Statustienrefundkhach, apartmentFinance.Statusphidonvesinh
                                                                        , apartment.Chuky, apartmentMoneyTax.Ngaydau, apartmentMoneyTax.Ngaycuoi, apartmentMoneyTax.Trangthai);
            showFinanceDetail.Show();
            this.Close();
        }

        private void ShowFinanceDetail_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void ShowFinanceDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void ShowFinanceDetail_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
