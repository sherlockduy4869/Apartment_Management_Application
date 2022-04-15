using QuanlyCanHoGiangTran.DAL;
using QuanlyCanHoGiangTran.DTO;
using QuanlyCanHoGiangTran.SHOW_INFO_FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM
{
    public partial class InformationDetail : Form
    {
        public InformationDetail()
        {
            InitializeComponent();
        }

        private void btnDetailInformation_Click(object sender, EventArgs e)
        {
            Apartment apartment = AdminDAL.Instance.getApartmentByMaCanHo(txbMaCanHo.Text);
            ApartmentMoneyTax apartmentMoney = AdminDAL.Instance.getApartmentMoneyByMaCanHo(txbMaCanHo.Text);

            ShowInformationDetail showInformationDetail = new ShowInformationDetail(apartment.Macanho, apartment.Duan, apartment.Tenchuho,apartment.Masothue, apartment.Thue, apartment.Phikekhaithue, apartment.Phiquanly
                                                                                    , apartment.Tienrefundkhach, apartment.Phidonvesinh, apartment.Tienthu, apartment.Chuky, apartmentMoney.Ngaydau, apartmentMoney.Ngaycuoi);
            showInformationDetail.Show();
            this.Close();
        }
    }
}
