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
        
        public ShowFinanceDetail()
        {
            InitializeComponent();
            listFinanceCategory();
        }

        public ShowFinanceDetail(string maCanHo, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, 
                                string statusThue, string statusPhiKeKhaiThue, string statusPhiQuanLy, string statusTienReFundKhach
                                , string statusPhiDonVeSinh, string statusTienThu, int chuKy, DateTime ngayDau, DateTime ngayCuoi)
        {
            InitializeComponent();
            listFinanceCategory();
            txbMaCanHo.Text = maCanHo;
            txbThue.Text = thue.ToString("N0");
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N0");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N0");
            txbTienRefundKhach.Text = tienReFundKhach.ToString("N0");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N0");
            txbTienThu.Text = tienThu.ToString("N0");
            

            lbThue.Text = statusThue;
            lbPhiKeKhaiThue.Text = statusPhiKeKhaiThue;
            lbPhiQuanLy.Text = statusPhiQuanLy;
            lbTienReFundKhach.Text = statusTienReFundKhach;
            lbPhidonvesinh.Text = statusPhiDonVeSinh;
            lbTienThu.Text = statusTienThu;

            txbChuKy.Text = chuKy.ToString("N0");
            dtpkNgayDau.Value = ngayDau;
            dtpkNgayCuoi.Value = ngayCuoi;
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

            if (typeOfFee == "TIENTHU")
            {
                int status = Int32.Parse(lbTienThu.Text);
                final_status = status + 1;
                typeOfStatus = "STATUS_TIENTHU";
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

            if(typeOfFee == "THUE")
            {
                typeOfStatus = "STATUS_THUE";
            }

            if (typeOfFee == "PHIKEKHAITHUE")
            {
                typeOfStatus = "STATUS_PHIKEKHAITHUE";
            }

            if (typeOfFee == "PHIQUANLY")
            {
                typeOfStatus = "STATUS_PHIQUANLY";
            }

            if (typeOfFee == "TIENREFUNDKHACH")
            {
                typeOfStatus = "STATUS_TIENREFUNDKHACH";
            }

            if (typeOfFee == "PHIDONVESINH")
            {
                typeOfStatus = "STATUS_PHIDONVESINH";
            }

            if (typeOfFee == "TIENTHU")
            {
                typeOfStatus = "STATUS_TIENTHU";
            }
            try
            {
                int i = AdminDAL.Instance.reDoFee(typeOfStatus, txbMaCanHo.Text);

                if (i != 0)
                {

                    MessageBox.Show("Redo");
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

    }
}
