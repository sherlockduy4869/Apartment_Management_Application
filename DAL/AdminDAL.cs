using QuanlyCanHoGiangTran.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int addApartment(string maCanHo, string duAn, string tenChuHo, string maSoThue, 
                                string hinhThucKT, string coQuanTT, string tinhTrang, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, int chuKy, 
                                string ngayStart, string ngayEnd, int soNgayNhac)
        {
            string query = "Insert into APARTMENT_INFO(MACANHO, DUAN, TENCHUHO, MASOTHUE, HINHTHUCKHAITHUE, COQUANTHUTHUE, TINHTRANG, " +
                            "THUE, PHIKEKHAITHUE, PHIQUANLY, TIENREFUNDKHACH, PHIDONVESINH, TIENTHU, NGAYBATDAU, NGAYKETTHUC, CHUKY, SONGAYNHACNHO) " +
                            "VALUES('" + maCanHo + "','" + duAn + "','"  + tenChuHo + "','" + maSoThue + "', '" + hinhThucKT 
                            + "', '" + coQuanTT + "',N'" + tinhTrang + "','" + thue + "','" + phiKeKhaiThue + "','" + phiQuanLy + "','" 
                            + tienReFundKhach + "','" + phiDonVeSinh + "','" + tienThu + "','" + ngayStart + "', '" + ngayEnd + "', '" + chuKy + "', '" + soNgayNhac + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int removeApartment(string maCanHo)
        {
            string query = "EXEC dbo.DELETING_APARTMENT @macanho";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
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

        public int expireApart(string maCanHo)
        {
            string query = "EXEC dbo.ADDING_EXPIRED_APARTMENT @macanho ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return i;
        }

        public int doneNegotiation(string maCanHo)
        {
            string query = "UPDATE APARTMENT_CONTRACT SET STATUS = 'DONE' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }
        public int reDoNegotiation(string maCanHo)
        {
            string query = "UPDATE APARTMENT_CONTRACT SET STATUS = 'NOT DONE' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }
        public int skipNegotiation(string maCanHo)
        {
            string query = "DELETE FROM APARTMENT_CONTRACT WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public Apartment getApartmentByMaCanHo(string maCanHo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TENCHUHO,MACANHO,DUAN,TINHTRANG,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE,PHIQUANLY,TIENREFUNDKHACH," +
                                                                "PHIDONVESINH,TIENTHU,NGAYBATDAU,NGAYKETTHUC,SONGAYNHACNHO,CHUKY FROM APARTMENT_INFO WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Apartment(row);
            }
            return null;
        }

        public ApartmentFinance getFinanceDetailByMaCanHo(string maCanHo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MACANHO, THUE,PHIKEKHAITHUE,PHIQUANLY,TIENREFUNDKHACH,PHIDONVESINH,TIENTHU, STATUS_THUE, STATUS_PHIKEKHAITHUE, STATUS_PHIQUANLY, " +
                                                                "STATUS_TIENREFUNDKHACH, STATUS_PHIDONVESINH, STATUS_TIENTHU FROM APARTMENT_FINANCE WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new ApartmentFinance(row);
            }
            return null;
        }

        public int markDoneFee(string typeOfStatus, string maCanHo)
        {
            string query = "UPDATE APARTMENT_FINANCE SET " + typeOfStatus + " = 'CHECKED' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int reDoFee(string typeOfStatus, string maCanHo)
        {
            string query = "UPDATE APARTMENT_FINANCE SET " + typeOfStatus + " = 'UNCHECKED' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }
    }
}
