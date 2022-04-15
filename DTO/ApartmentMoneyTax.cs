using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class ApartmentMoneyTax
    {
        private string _tenchuho;
        private string _macanho;
        private string _duan;
        private DateTime _ngaydau;
        private DateTime _ngaycuoi;
        private int _chuky;
        private double _tiencanthu;


        public ApartmentMoneyTax(DataRow row)
        {
            _tenchuho = (string)row["TENCHUHO"];
            _macanho = (string)row["MACANHO"];
            _duan = (string)row["DUAN"];
            _chuky = (int)row["CHUKY"];
            _tiencanthu = (double)row["TIENCANTHU"];
            _ngaydau = (DateTime)row["NGAYDAU"];
            _ngaycuoi = (DateTime)row["NGAYCUOI"];
        }

        public string Tenchuho
        {
            get { return _tenchuho; }
            set { _tenchuho = value; }  
        }

        public string Macanho
        {
            get { return _macanho; }
            set { _macanho = value; }
        }

        public string Duan
        {
            get { return _duan; }
            set { _duan = value; }
        }

        public DateTime Ngaydau
        {
            get { return _ngaydau; }
            set { _ngaydau = value; }
        }

        public DateTime Ngaycuoi
        {
            get { return _ngaycuoi; }
            set { _ngaycuoi = value;}
        }

        public int ChuKy
        {
            get { return _chuky; }
            set { _chuky = value;}
        }

        public double Tiencanthu
        {
            get { return _tiencanthu; }
            set { _tiencanthu = value;}
        }

    }
}
