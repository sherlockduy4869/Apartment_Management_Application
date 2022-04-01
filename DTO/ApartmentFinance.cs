using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class ApartmentFinance
    {
        private string _macanho;
        private string _statusthue;
        private string _statusphikekhaithue;
        private string _statusphiquanly;
        private string _statustienrefundkhach;
        private string _statusphidonvesinh;
        private string _statustienthu;

        private double _thue;
        private double _phikekhaithue;
        private double _phiquanly;
        private double _tienrefundkhach;
        private double _phidonvesinh;
        private double _tienthu;

        public ApartmentFinance(DataRow row)
        {
            _macanho = (string)row["MACANHO"];
            _statusthue = (string)row["STATUS_THUE"];
            _statusphikekhaithue = (string)row["STATUS_PHIKEKHAITHUE"];
            _statusphiquanly = (string)row["STATUS_PHIQUANLY"];
            _statustienrefundkhach = (string)row["STATUS_TIENREFUNDKHACH"];
            _statusphidonvesinh = (string)row["STATUS_PHIDONVESINH"];
            _statustienthu = (string)row["STATUS_TIENTHU"];
            _thue = (double)row["THUE"];
            _phikekhaithue = (double)row["PHIKEKHAITHUE"];
            _phiquanly = (double)row["PHIQUANLY"];
            _tienrefundkhach = (double)row["TIENREFUNDKHACH"];
            _phidonvesinh = (double)row["PHIDONVESINH"];
            _tienthu = (double)row["TIENTHU"];
        }
        public string Macanho
        {
            get { return _macanho; }
            set { _macanho = value; }
        }
        public string Statusthue
        {
            get { return _statusthue; }
            set { _statusthue = value; }
        }
        public string Statusphikekhaithue
        {
            get { return _statusphikekhaithue;}
            set { _statusphikekhaithue=value; }
        }
        public string Statusphiquanly
        {
            get { return _statusphiquanly;}
            set { _statusphiquanly = value;}
        }
        public string Statustienrefundkhach
        {
            get { return _statustienrefundkhach;}
            set { _statustienrefundkhach=value;}
        }
        public string Statusphidonvesinh
        {
            get { return _statusphidonvesinh;}
            set { _statusphidonvesinh=value;}
        }
        public string Statustienthu
        {
            get { return _statustienthu;}
            set { _statustienthu=value;}
        }
        public double Thue
        {
            get { return _thue; }
            set { _thue = value; }
        }

        public double Tienthu
        {
            get { return _tienthu; }
            set { _tienthu = value; }
        }

        public double Phikekhaithue
        {
            get { return _phikekhaithue; }
            set { _phikekhaithue = value; }
        }

        public double Phiquanly
        {
            get { return _phiquanly; }
            set { _phiquanly = value; }
        }

        public double Tienrefundkhach
        {
            get { return _tienrefundkhach; }
            set { _tienrefundkhach = value; }
        }

        public double Phidonvesinh
        {
            get { return _phidonvesinh; }
            set { _phidonvesinh = value; }
        }
    }
}

