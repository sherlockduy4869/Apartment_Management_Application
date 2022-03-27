using QuanlyCanHoGiangTran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            showInforExpiredApart();
        }

        void showInforExpiredApart()
        {
            dtgvHistory.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM EXPIRED_APARTMENT");
            this.dtgvHistory.Sort(this.dtgvHistory.Columns["STT"], ListSortDirection.Ascending);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
