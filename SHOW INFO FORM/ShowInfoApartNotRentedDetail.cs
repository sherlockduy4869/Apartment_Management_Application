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
    public partial class ShowInfoApartNotRentedDetail : Form
    {
        public ShowInfoApartNotRentedDetail()
        {
            InitializeComponent();
        }

        public ShowInfoApartNotRentedDetail(string maCanHo, string tenChuHo, string duAn, string soPhongNgu, string dienTich, string daiLy, string tinhTrang)
        {
            InitializeComponent();

            txbMaCanHo.Text = maCanHo;
            txbTenChuHo.Text = tenChuHo;
            txbDuAn.Text = duAn;
            txbSoPhongNgu.Text = soPhongNgu;
            txbSQM.Text = dienTich;
            txbDaiLy.Text = daiLy;
            txbTinhTrang.Text = tinhTrang;
        }
    }
}
