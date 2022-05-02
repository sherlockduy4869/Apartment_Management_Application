using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class ApartmentNotRented
    {
        private string _macanho;
        private string _tenchuho;
        private string _duan;
        private string _sophongngu;
        private string _dientich;
        private string _tinhtrang;
        private string _daily;

        public ApartmentNotRented(DataRow row)
        {
            _macanho = (string)row["MACANHO"];
            _tenchuho = (string)row["TENCHUHO"];
            _duan = (string)row["DUAN"];
            _sophongngu = (string)row["SOPHONGNGU"];
            _dientich = (string)row["DIENTICH"];
            _tinhtrang = (string)row["TINHTRANG"];
            _daily = (string)row["DAILY"];

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
            get { return _sophongngu; }
            set { _sophongngu = value; }
        }

        public string Dientich
        {
            get { return _dientich; }
            set { _dientich = value; }
        }

        public string Tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        public string Daily
        {
            get { return _daily; }
            set { _daily = value; }
        }

    }

}
