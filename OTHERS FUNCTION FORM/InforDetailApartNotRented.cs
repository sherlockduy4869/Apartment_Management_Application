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
    public partial class InforDetailApartNotRented : Form
    {
        public InforDetailApartNotRented()
        {
            InitializeComponent();
        }

        private void btnDetailInformation_Click(object sender, EventArgs e)
        {

            ApartmentNotRented apartmentNotRented = AdminDAL.Instance.getApartmentNotRentedByMaCanHo(txbMaCanHo.Text);

            try
            {
                if (apartmentNotRented != null)
                {
                    ShowInfoApartNotRentedDetail showInfoApartNotRentedDetail = new ShowInfoApartNotRentedDetail(apartmentNotRented.Macanho, apartmentNotRented.Tenchuho, apartmentNotRented.Duan, apartmentNotRented.Sophongngu
                                                                                                           , apartmentNotRented.Dientich, apartmentNotRented.Daily, apartmentNotRented.Tinhtrang);
                    showInfoApartNotRentedDetail.Show();
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
