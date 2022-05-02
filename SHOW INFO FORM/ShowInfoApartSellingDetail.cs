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
    public partial class ShowInfoApartSellingDetail : Form
    {
        public ShowInfoApartSellingDetail()
        {
            InitializeComponent();
        }
        public ShowInfoApartSellingDetail(string maCanHo, string tenChuHo, string duAn, string soPhongNgu, string dienTich, string daiLy, string email, 
                                          string phone, string ghiChu, double giaTienVND, double giaTienUSD, DateTime ngayNhapData)
        {
            InitializeComponent();

            txbMaCanHo.Text = maCanHo;
            txbTenChuHo.Text = tenChuHo;
            txbDuAn.Text = duAn;
            txbSoPhongNgu.Text = soPhongNgu;
            txbDienTich.Text = dienTich;    
            txbDaiLy.Text = daiLy;  
            txbEmail.Text = email;
            txbPhone.Text = phone;
            txbGhiChu.Text = ghiChu;    
            txbGiaTienVND.Text = giaTienVND.ToString("N0");
            txbGiaTienUSD.Text = giaTienUSD.ToString("N0");
            dtpkNgayNhapData.Value = ngayNhapData;
        }
    }
}
