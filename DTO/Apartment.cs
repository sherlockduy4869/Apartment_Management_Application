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
        private float _tienthu;
        private string _chuky;
        private DateTime _ngaybatdau;
        private DateTime _ngayketthuc;

        public Apartment(DataRow row)
        {
            _macanho = (string)row["MACANHO"];
            _tenchuho = (string)row["TENCHUHO"];
            _masothue = (string)row["MASOTHUE"];
            _hinhthucthuthue = (string)row["HINHTHUCKHAITHUE"];
            _coquanthuthue = (string)row["COQUANTHUTHUE"];
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
        public float Tienthu
        {
            get { return _tienthu; }
            set { _tienthu = value; }
        }
        public string Chuky
        {
            get { return _chuky; }
            set { _chuky = value; }
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
    }
}
