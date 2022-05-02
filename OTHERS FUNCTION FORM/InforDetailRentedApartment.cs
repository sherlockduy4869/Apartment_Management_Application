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
    public partial class InforDetailRentedApartment : Form
    {
        public InforDetailRentedApartment()
        {
            InitializeComponent();
        }

        private void btnDetailInformation_Click(object sender, EventArgs e)
        {
            Apartment apartment = AdminDAL.Instance.getApartmentByMaCanHo(txbMaCanHo.Text);


            

            try
            {
                if (apartment != null)
                {
                    ShowInforApartRentedDetail showInforApartRentedDetail = new ShowInforApartRentedDetail(apartment.Macanho, apartment.Duan, apartment.Daily, apartment.Tenchuho, apartment.Email, apartment.Phone, apartment.Masothue, apartment.Hinhthucthuthue
                                                                                                     , apartment.Coquanthuthue, apartment.Chuky, apartment.Tienthuemotthang, apartment.Thue, apartment.Phikekhaithue, apartment.Phiquanly
                                                                                                     , apartment.Tienrefundkhach, apartment.Phidonvesinh, apartment.Tienthu, apartment.Ngaybatdau, apartment.Ngayketthuc, apartment.SoNgayNhacNho);
                    showInforApartRentedDetail.Show();
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
