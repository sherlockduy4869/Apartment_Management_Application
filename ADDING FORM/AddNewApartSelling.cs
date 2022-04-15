using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.ADDING_FORM
{
    public partial class AddNewApartSelling : Form
    {
        public AddNewApartSelling()
        {
            InitializeComponent();
            listAllComboBox();
        }
        void listAllComboBox()
        {

            List<string> listDuAn = new List<string>();
            string[] arrayListDuAn = { "Vinhomes Golden River", "Vinhomes Central Park", "Estella Height", "Estella", "The Vista", "Celesta" };
            foreach (string str in arrayListDuAn)
            {
                listDuAn.Add(str);
            }
            cbDuAn.DataSource = listDuAn;

            List<string> listTinhTrang = new List<string>();
            string[] arrayListTinhTrang = { "Đang bán", "Đã bán" };
            foreach (string str in arrayListTinhTrang)
            {
                listTinhTrang.Add(str);
            }
            cbTinhTrang.DataSource = listTinhTrang;

            List<string> listPhongNgu = new List<string>();
            string[] arrayListPhongNgu = { "1 PN", "2 PN", "2 PN + 1", "3 PN", "3 PN + 1", "4 PN", "4 PN + 1" };
            foreach (string str in arrayListPhongNgu)
            {
                listPhongNgu.Add(str);
            }
            cbSoPhongNgu.DataSource = listPhongNgu;

        }
    }
}
