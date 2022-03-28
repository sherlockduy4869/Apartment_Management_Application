using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class Apartment
    {
        private string _macanho;
        private string _tenchuho;
        private string _masothue;
        private string _hinhthucthuthue;
        private string _coquanthuthue;
        private string _chuky;
        private string _tinhtrang;
        private string _duan;

        private float _thue;
        private float _phikekhaithue;
        private float _phiquanly;
        private float _tienrefundkhach;
        private float _phidonvesinh;
        private float _tienthu;

        private DateTime _ngaybatdau;
        private DateTime _ngayketthuc;

        public Apartment(DataRow row)
        {
            _tenchuho = (string)row["TENCHUHO"];
            _macanho = (string)row["MACANHO"];
            _duan = (string)row["DUAN"];
            _masothue = (string)row["MASOTHUE"];
            _hinhthucthuthue = (string)row["HINHTHUCKHAITHUE"];
            _coquanthuthue = (string)row["COQUANTHUTHUE"];
            _tinhtrang = (string)row["TINHTRANG"];
            _thue = (float)row["THUE"];
            _phikekhaithue = (float)row["PHIKEKHAITHUE"];
            _phiquanly = (float)row["PHIQUANLY"];
            _tienrefundkhach = (float)row["TIENREFUNDKHACH"];
            _phidonvesinh = (float)row["PHIDONVESINH"];
            _tienthu = (float)row["TIENTHU"];
            _chuky = (string)row["CHUKY"];
            _ngaybatdau = (DateTime)row["NGAYBATDAU"];
            _ngayketthuc = (DateTime)row["NGAYKETTHUC"];
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
        public string Masothue
        {
            get { return _masothue; }
            set { _masothue = value; }
        }
        public string Hinhthucthuthue
        {
            get { return _hinhthucthuthue; }
            set { _hinhthucthuthue = value; }
        }
        public string Coquanthuthue
        {
            get { return _coquanthuthue; }
            set { _coquanthuthue = value; }
        }
        public string Chuky
        {
            get { return _chuky; }
            set { _chuky = value; }
        }
        public string Duan
        {
            get { return _duan; }
            set { _duan = value; }
        }
        public string Tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value;}
        }
        public DateTime Ngaybatdau
        {
            get { return _ngaybatdau; }
            set { _ngaybatdau = value; }
        }
        public DateTime Ngayketthuc
        {
            get { return _ngayketthuc; }
            set { _ngayketthuc = value; }
        }

        public float Thue
        {
            get { return _thue; }
            set { _thue = value; }
        }

        public float Tienthu
        {
            get { return _tienthu; }
            set { _tienthu = value; }
        }

        public float Phikekhaithue
        {
            get { return _phikekhaithue; }
            set { _phikekhaithue = value;}
        }

        public float Phiquanly
        {
            get { return _phiquanly; }
            set { _phiquanly = value; }
        }

        public float Tienrefundkhach
        {
            get { return _tienrefundkhach;}
            set { _tienrefundkhach = value;}
        }

        public float Phidonvesinh
        {
            get { return _phidonvesinh; }
            set { _phidonvesinh = value;}
        }
    }
}
