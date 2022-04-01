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
        public ShowFinanceDetail()
        {
            InitializeComponent();
            listFinanceCategory();
        }

        public ShowFinanceDetail(string maCanHo, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, 
                                string statusThue, string statusPhiKeKhaiThue, string statusPhiQuanLy, string statusTienReFundKhach
                                , string statusPhiDonVeSinh, string statusTienThu)
        {
            InitializeComponent();
            listFinanceCategory();
            txbMaCanHo.Text = maCanHo;
            txbThue.Text = thue.ToString("N");
            txbPhiKeKhaiThue.Text = phiKeKhaiThue.ToString("N");
            txbPhiQuanLy.Text = phiQuanLy.ToString("N");
            txbTienRefundKhach.Text = tienReFundKhach.ToString("N");
            txbPhiDonVeSinh.Text = phiDonVeSinh.ToString("N");
            txbTienThu.Text = tienThu.ToString("N");
            
            //Thue
            if(statusThue == "UNCHECKED")
            {
                lbThue.Text = "unchecked";
            }
            else
            {
                lbThue.Text = "checked";
            }
            //PhiKeKhaiThue
            if (statusPhiKeKhaiThue == "UNCHECKED")
            {
                lbPhiKeKhaiThue.Text = "unchecked";
            }
            else
            {
                lbPhiKeKhaiThue.Text = "checked";
            }
            //Phiquanly
            if (statusPhiQuanLy == "UNCHECKED")
            {
                lbPhiQuanLy.Text = "unchecked";
            }
            else
            {
                lbPhiQuanLy.Text = "checked";
            }
            //Tienrefundkhach
            if (statusTienReFundKhach == "UNCHECKED")
            {
                lbTienReFundKhach.Text = "unchecked";
            }
            else
            {
                lbTienReFundKhach.Text = "checked";
            }
            //Phidonvesinh
            if (statusPhiDonVeSinh == "UNCHECKED")
            {
                lbPhidonvesinh.Text = "unchecked";
            }
            else
            {
                lbPhidonvesinh.Text = "checked";
            }
            //Tienthu
            if (statusTienThu == "UNCHECKED")
            {
                lbTienThu.Text = "unchecked";
            }
            else
            {
                lbTienThu.Text = "checked";
            }
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
                int i = AdminDAL.Instance.markDoneFee(typeOfStatus, txbMaCanHo.Text);

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
