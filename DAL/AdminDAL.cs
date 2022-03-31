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
                                string hinhThucKT, string coQuanTT, string tinhTrang, float thue, float phiKeKhaiThue, 
                                float phiQuanLy, float tienReFundKhach, float phiDonVeSinh, float tienThu, string chuKy, 
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
    }
}
