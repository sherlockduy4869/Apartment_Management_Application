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
                                string hinhThucKT, string coQuanTT, double thue, double phiKeKhaiThue,
                                double phiQuanLy, double tienReFundKhach, double phiDonVeSinh, double tienThu, double tienThue1Thang, int chuKy,
                                string ngayStart, string ngayEnd, int soNgayNhac, string daily, string email, string phone)
        {
            string query = "Insert into APARTMENT_INFO(MACANHO, DUAN, TENCHUHO, DAILY, EMAIL, PHONE, MASOTHUE, HINHTHUCKHAITHUE, COQUANTHUTHUE, " +
                            "THUE, PHIKEKHAITHUE, PHIQUANLY, TIENREFUNDKHACH, PHIDONVESINH, TIENTHU, TIENTHUEMOTTHANG, NGAYBATDAU, NGAYKETTHUC, CHUKY, SONGAYNHACNHO) " +
                            "VALUES('" + maCanHo + "','" + duAn + "','" + tenChuHo + "','" + daily + "','" + email + "','" + phone + "' ,'" + maSoThue + "', '" + hinhThucKT
                            + "', '" + coQuanTT + "','" + thue + "','" + phiKeKhaiThue + "','" + phiQuanLy + "','"
                            + tienReFundKhach + "','" + phiDonVeSinh + "','" + tienThu + "','" + tienThue1Thang + "','" + ngayStart + "', '" + ngayEnd + "', '" + chuKy + "', '" + soNgayNhac + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int addApartmentSelling(string maCanHo, string tenChuHo, string duAn, string daiLy, string email, string phone,
                                       string soPhongNgu, string dienTich, double vndPrice, double usdPrice, string ngayNhapData, string ghiChu)
        {
            string query = "Insert into APARTMENT_SELLING (MACANHO,TENCHUHO,DUAN,DAILY,EMAIL,PHONE,SOPHONGNGU,DIENTICH,GIATIENVND,GIATIENUSD,NGAYNHAPDATA,GHICHU) VALUES(" +
                            "'" + maCanHo + "','" + tenChuHo + "','" + duAn + "','" + daiLy + "','" + email + "','" + phone + "','" + soPhongNgu + "','" + dienTich + "','" + vndPrice + "','" + usdPrice + "'," +
                             "'" + ngayNhapData + "','" + ghiChu + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int addApartmentNotRented(string maCanHo, string tenChuHo, string duAn, string tinhTrang, string dienTich, string soPhongNgu, string daiLy)
        {
            string query = "Insert into APARTMENT_NOT_RENTED (MACANHO,TENCHUHO,DUAN,SOPHONGNGU,DIENTICH,TINHTRANG,DAILY) VALUES(" +
                            "'" + maCanHo + "','" + tenChuHo + "','" + duAn + "','" + soPhongNgu + "','" + dienTich + "',N'" + tinhTrang + "','" + daiLy + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int addApartmentCart(string maCanHo, string tenChuHo, string duAn, string daiLy)
        {
            string query = "Insert into APARTMENT_CART (MACANHO,TENCHUHO,DUAN,DAILY) VALUES(" +
                            "'" + maCanHo + "','" + tenChuHo + "','" + duAn + "','" + daiLy + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int removeApartment(string maCanHo)
        {
            string query = "EXEC dbo.DELETING_APARTMENT @macanho";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return i;
        }

        public int removeApartSelling(string maCanHo)
        {
            string query = "DELETE FROM APARTMENT_SELLING WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return i;
        }

        public int removeApartNotRented(string maCanHo)
        {
            string query = "DELETE FROM APARTMENT_NOT_RENTED WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return i;
        }

        public int removeApartmentCart(string maCanHo)
        {
            string query = "DELETE FROM APARTMENT_CART WHERE MACANHO = '" + maCanHo + "'";
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

        public int reDoFee(string typeOfStatus, int final_status, string maCanHo)
        {
            string query = "UPDATE APARTMENT_FINANCE SET " + typeOfStatus + " = '" + final_status + "' WHERE MACANHO = '" + maCanHo + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i;
        }

        public int markDoneFee(string typeOfStatus, int final_status, string maCanHo)
        {
            string query = "UPDATE APARTMENT_FINANCE SET " + typeOfStatus + " = '" + final_status + "' WHERE MACANHO = '" + maCanHo + "'";
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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TENCHUHO,DAILY,EMAIL,PHONE,MACANHO,DUAN,MASOTHUE,HINHTHUCKHAITHUE,COQUANTHUTHUE,THUE,PHIKEKHAITHUE,PHIQUANLY,TIENREFUNDKHACH," +
                                                                "PHIDONVESINH,TIENTHU,TIENTHUEMOTTHANG,NGAYBATDAU,NGAYKETTHUC,SONGAYNHACNHO,CHUKY FROM APARTMENT_INFO WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Apartment(row);
            }
            return null;
        }

        public ApartmentSelling getApartmentSellingByMaCanHo(string maCanHo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DUAN,SOPHONGNGU,DIENTICH,GIATIENUSD,GIATIENVND,EMAIL," +
                                                                "PHONE,DAILY,NGAYNHAPDATA,GHICHU FROM APARTMENT_SELLING WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new ApartmentSelling(row);
            }
            return null;
        }

        public ApartmentNotRented getApartmentNotRentedByMaCanHo(string maCanHo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MACANHO,TENCHUHO,DUAN,SOPHONGNGU,DIENTICH,TINHTRANG,DAILY FROM APARTMENT_NOT_RENTED WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new ApartmentNotRented(row);
            }
            return null;
        }

        public ApartmentMoneyTax getApartmentMoneyByMaCanHo(string maCanHo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TENCHUHO,MACANHO,DUAN, CHUKY, NGAYDAU, NGAYCUOI, TIENCANTHU, TRANGTHAI FROM APARTMENT_MONEY WHERE MACANHO = '" + maCanHo + "'");
            foreach (DataRow row in data.Rows)
            {
                return new ApartmentMoneyTax(row);
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

    }
}