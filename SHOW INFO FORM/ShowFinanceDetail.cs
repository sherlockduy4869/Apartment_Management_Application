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
        private string typeOfStatusThu = "";
        private int status = 0;
        private int statusThu = 0;
        private int final_status = 0;
        private int final_status_thu = 0;

        public ShowFinanceDetail()
        {
            InitializeComponent();
            listFinanceCategory();
        }

        public ShowFinanceDetail(string maCanHo, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh,
                                string statusThue, string statusPhiKeKhaiThue, string statusPhiQuanLy, string statusTienReFundKhach
                                , string statusPhiDonVeSinh
                                , double thueIncome, double phiKeKhaiThueIncome,
                                double phiQuanLyIncome, double tienReFundKhachIncome, double phiDonVeSinhIncome,
                                string statusThueIncome, string statusPhiKeKhaiThueIncome, string statusPhiQuanLyIncome, string statusTienReFundKhachIncome
                                , string statusPhiDonVeSinhIncome, int chuKy, DateTime ngayDau, DateTime ngayCuoi)
        {
            InitializeComponent();
            listFinanceCategory();

            txbMaCanHo.Text = maCanHo;

            txbThue.Text = thue.ToString("N0");
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N0");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N0");
            txbTienRefundKhach.Text = tienReFundKhach.ToString("N0");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N0");


            txbThueThu.Text = thueIncome.ToString("N0");
            txbPhiKeKhaiThueThu.Text = phiKeKhaiThueIncome.ToString("N0");
            txbPhiQuanLyThu.Text = phiQuanLyIncome.ToString("N0");
            txbTienReFundKhachThu.Text = tienReFundKhachIncome.ToString("N0");
            txbPhiDonVeSinhThu.Text = phiDonVeSinhIncome.ToString("N0");

            lbThue.Text = statusThue;
            lbPhiKeKhaiThue.Text = statusPhiKeKhaiThue;
            lbPhiQuanLy.Text = statusPhiQuanLy;
            lbTienReFundKhach.Text = statusTienReFundKhach;
            lbPhidonvesinh.Text = statusPhiDonVeSinh;

            lbThueThu.Text = statusThueIncome;
            lbPhiKeKhaiThueThu.Text = statusPhiKeKhaiThueIncome;
            lbPhiQuanLyThu.Text = statusPhiQuanLyIncome;
            lbTienRefundKhachThu.Text = statusTienReFundKhachIncome;
            lbPhiDonVeSinhThu.Text = statusPhiDonVeSinhIncome;


            txbChuKy.Text = chuKy.ToString("N0");
            dtpkNgayDau.Value = ngayDau;
            dtpkNgayCuoi.Value = ngayCuoi;

            txbTongChi.Text = ((thue * Int32.Parse(statusThue)) + (phiKeKhaiThue * Int32.Parse(statusPhiKeKhaiThue)) + (phiQuanLy * Int32.Parse(statusPhiQuanLy)) +
                              (tienReFundKhach * Int32.Parse(statusTienReFundKhach)) + (phiDonVeSinh * Int32.Parse(statusPhiDonVeSinh))).ToString("N0");

            txbTongThu.Text = ((thueIncome * Int32.Parse(statusThueIncome)) + (phiKeKhaiThueIncome * Int32.Parse(statusPhiKeKhaiThueIncome)) + (phiQuanLyIncome * Int32.Parse(statusPhiQuanLyIncome)) +
                              (tienReFundKhachIncome * Int32.Parse(statusTienReFundKhachIncome)) + (phiDonVeSinhIncome * Int32.Parse(statusPhiDonVeSinhIncome))).ToString("N0");
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

            List<string> listThu = new List<string>();
            string[] arrayListThu = { "THUE", "PHIKEKHAITHUE", "PHIQUANLY", "TIENREFUNDKHACH", "PHIDONVESINH", "TIENTHU" };
            foreach (string str in arrayListThu)
            {
                listThu.Add(str);
            }
            cbThu.DataSource = listThu;


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

        private void btnMarkDoneThu_Click(object sender, EventArgs e)
        {
            string typeOfFeeThu = cbThu.Text;

            if (typeOfFeeThu == "THUE")
            {
                int status_thu = Int32.Parse(lbThueThu.Text);
                final_status_thu = status_thu + 1;
                typeOfStatusThu = "STATUS_THUE";
            }

            if (typeOfFeeThu == "PHIKEKHAITHUE")
            {
                int status_thu = Int32.Parse(lbPhiKeKhaiThueThu.Text);
                final_status_thu = status_thu + 1;
                typeOfStatusThu = "STATUS_PHIKEKHAITHUE";
            }

            if (typeOfFeeThu == "PHIQUANLY")
            {
                int status_thu = Int32.Parse(lbPhiQuanLyThu.Text);
                final_status_thu = status_thu + 1;
                typeOfStatusThu = "STATUS_PHIQUANLY";
            }

            if (typeOfFeeThu == "TIENREFUNDKHACH")
            {
                int status_thu = Int32.Parse(lbTienRefundKhachThu.Text);
                final_status_thu = status_thu + 1;
                typeOfStatusThu = "STATUS_TIENREFUNDKHACH";
            }

            if (typeOfFeeThu == "PHIDONVESINH")
            {
                int status_thu = Int32.Parse(lbPhiDonVeSinhThu.Text);
                final_status_thu = status_thu + 1;
                typeOfStatusThu = "STATUS_PHIDONVESINH";
            }

            try
            {
                int i = AdminDAL.Instance.markDoneFeeThu(typeOfStatusThu, final_status_thu, txbMaCanHo.Text);

                if (i != 0)
                {
                    MessageBox.Show("Done");
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

        private void btnRedoThu_Click(object sender, EventArgs e)
        {
            string typeOfFeeThu = cbThu.Text;

            if (typeOfFeeThu == "THUE")
            {
                int status_thu = Int32.Parse(lbThueThu.Text);
                final_status_thu = status_thu - 1;
                typeOfStatusThu = "STATUS_THUE";
            }

            if (typeOfFeeThu == "PHIKEKHAITHUE")
            {
                int status_thu = Int32.Parse(lbPhiKeKhaiThueThu.Text);
                final_status_thu = status_thu - 1;
                typeOfStatusThu = "STATUS_PHIKEKHAITHUE";
            }

            if (typeOfFeeThu == "PHIQUANLY")
            {
                int status_thu = Int32.Parse(lbPhiQuanLyThu.Text);
                final_status_thu = status_thu - 1;
                typeOfStatusThu = "STATUS_PHIQUANLY";
            }

            if (typeOfFeeThu == "TIENREFUNDKHACH")
            {
                int status_thu = Int32.Parse(lbTienRefundKhachThu.Text);
                final_status_thu = status_thu - 1;
                typeOfStatusThu = "STATUS_TIENREFUNDKHACH";
            }

            if (typeOfFeeThu == "PHIDONVESINH")
            {
                int status_thu = Int32.Parse(lbPhiDonVeSinhThu.Text);
                final_status_thu = status_thu - 1;
                typeOfStatusThu = "STATUS_PHIDONVESINH";
            }

            try
            {
                if(final_status_thu < 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    int i = AdminDAL.Instance.reDoFeeThu(typeOfStatusThu, final_status_thu, txbMaCanHo.Text);

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
            ApartmentFinanceIncome apartmentFinanceIncome = AdminDAL.Instance.getFinanceDetailPayByMaCanHo(txbMaCanHo.Text);

            ShowFinanceDetail showFinanceDetail = new ShowFinanceDetail(txbMaCanHo.Text, apartmentFinance.Thue, apartmentFinance.Phikekhaithue
                                                                        , apartmentFinance.Phiquanly, apartmentFinance.Tienrefundkhach, apartmentFinance.Phidonvesinh
                                                                        , apartmentFinance.Statusthue, apartmentFinance.Statusphikekhaithue
                                                                        , apartmentFinance.Statusphiquanly, apartmentFinance.Statustienrefundkhach, apartmentFinance.Statusphidonvesinh
                                                                        , apartmentFinanceIncome.Thue, apartmentFinanceIncome.Phikekhaithue
                                                                        , apartmentFinanceIncome.Phiquanly, apartmentFinanceIncome.Tienrefundkhach, apartmentFinanceIncome.Phidonvesinh
                                                                        , apartmentFinanceIncome.Statusthue, apartmentFinanceIncome.Statusphikekhaithue
                                                                        , apartmentFinanceIncome.Statusphiquanly, apartmentFinanceIncome.Statustienrefundkhach, apartmentFinanceIncome.Statusphidonvesinh
                                                                        , apartment.Chuky, apartmentMoneyTax.Ngaydau, apartmentMoneyTax.Ngaycuoi);
            showFinanceDetail.Show();
            this.Close();
        }
    }
}
