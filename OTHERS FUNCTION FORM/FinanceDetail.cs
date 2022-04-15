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
    public partial class FinanceDetail : Form
    {
        public FinanceDetail()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
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
        }
    }
}
