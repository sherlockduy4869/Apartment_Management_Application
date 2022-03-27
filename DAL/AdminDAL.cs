using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DAL
{
    public class AdminDAL
    {
        private static AdminDAL instance;

        public static AdminDAL Instance
        {
            get { if (instance == null) instance = new AdminDAL(); return instance; }
            private set { instance = value; }
        }

        private AdminDAL() { }

        public int addApartment(string maCanHo, string tenChuHo, string maSoThue, string hinhThucKT, string coQuanTT, float tienThu, string chuKy, string ngayStart, string ngayEnd)
        {
            string query = "Insert into APARTMENT_INFO(MACANHO, TENCHUHO, MASOTHUE, HINHTHUCKHAITHUE, COQUANTHUTHUE, TIENTHU, NGAYBATDAU, NGAYKETTHUC, CHUKY) VALUES('" + maCanHo + "','" + tenChuHo + "','" + maSoThue + "', '" + hinhThucKT + "', '" + coQuanTT + "', '" + tienThu + "', '" + ngayStart + "', '" + ngayEnd + "', '" + chuKy + "') ";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int removeApartment(string maCanHo)
        {
            string query = " DELETE FROM APARTMENT_INFO WHERE MACANHO = '" + maCanHo + "' ";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int markDone(string maCanHo)
        {
            string query = "UPDATE APARTMENT_MONEY SET TRANGTHAI = 'Da thu tien' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int reDo(string maCanHo)
        {
            string query = "UPDATE APARTMENT_MONEY SET TRANGTHAI = 'Chua thu tien' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int nextCyle(string maCanHo)
        {
            string query = "EXEC dbo.Next_Ngaycanthu @macanho ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return i;
        }
    }
}
