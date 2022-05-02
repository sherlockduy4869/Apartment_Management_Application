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
            ShowInfoApartSellingDetail showInfoApartSellingDetail = new ShowInfoApartSellingDetail();
            showInfoApartSellingDetail.Show();
            this.Close();   
        }
    }
}
