using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class ApartmentSelling
    {
        private string _macanho;
        private string _tenchuho;
        private string _duan;
        private string _sophongngu;
        private string _dientich;
        private string _ghichu;

        private string _email;
        private string _phone;
        private string _daily;

        private double _giatienvnd;
        private double _giatienusd;

        private DateTime _ngaynhapdata;

        public ApartmentSelling(DataRow row)
        {
            _macanho = (string)row["MACANHO"];
            _tenchuho = (string)row["TENCHUHO"];
            _duan = (string)row["DUAN"];
            _sophongngu = (string)row["SOPHONGNGU"];
            _dientich = (string)row["DIENTICH"];
            _ghichu = (string)row["GHICHU"];
            _email = (string)row["EMAIL"];
            _phone = (string)row["PHONE"];
            _daily = (string)row["DAILY"];

            _giatienvnd = (double)row["GIATIENVND"];
            _giatienusd = (double)row["GIATIENUSD"];
            
            _ngaynhapdata = (DateTime)row["NGAYNHAPDATA"];

        }
        public string Macanho
        {
            get { return _macanho; }
            set { _macanho = value; }
        }
        public string Tenchuho
        {
            get { return _tenchuho; }
            set { _tenchuho = value; }
        }
        
        public string Duan
        {
            get { return _duan; }
            set { _duan = value; }
        }

        public string Sophongngu
        {
            get { return _sophongngu;}
            set { _sophongngu = value;}
        }

        public string Dientich
        {
            get { return _dientich; }
            set { _dientich = value; }
        }

        public string Daily
        {
            get { return _daily; }
            set { _daily = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }

        public double Giatienvnd
        {
            get { return _giatienvnd;}
            set { _giatienvnd = value; }
        }

        public double Giatienusd
        {
            get { return _giatienusd; }
            set { _giatienusd = value;}
        }

        public DateTime Ngaynhapdata
        {
            get { return _ngaynhapdata; }
            set { _ngaynhapdata = value; }
        }
    }
    
}
