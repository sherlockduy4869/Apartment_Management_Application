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
    public partial class InforDetailSellingApart : Form
    {
        public InforDetailSellingApart()
        {
            InitializeComponent();
        }

        private void btnDetailInformation_Click(object sender, EventArgs e)
        {

            ApartmentSelling apartmentSelling = AdminDAL.Instance.getApartmentSellingByMaCanHo(txbMaCanHo.Text);

            try
            {
                if (apartmentSelling != null)
                {
                    ShowInfoApartSellingDetail showInfoApartSellingDetail = new ShowInfoApartSellingDetail(apartmentSelling.Macanho, apartmentSelling.Tenchuho, apartmentSelling.Duan, apartmentSelling.Sophongngu
                                                                                                           , apartmentSelling.Dientich, apartmentSelling.Daily, apartmentSelling.Email, apartmentSelling.Phone, apartmentSelling.Ghichu
                                                                                                           , apartmentSelling.Giatienvnd, apartmentSelling.Giatienusd, apartmentSelling.Ngaynhapdata);
                    showInfoApartSellingDetail.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR 404");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
    }
}
