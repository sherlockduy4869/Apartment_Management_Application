using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class Account
    {
        private string _username;
        private string _password;

        public Account(DataRow row)
        {
            _username = (string)row["USERNAME"];
            _password = (string)row["PASSWORD"];
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
