using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class PublicParms
    {
        private static string userName;
        public static string Uname
        {
            set { userName = value; }
            get { return userName; }
        }

        private static string connString = "Database=testassessment;Data Source=localhost;User Id=LK;Password=123456;CharSet=utf8;port=3306";

        public static string ConnStr
        {
            get { return connString; }
        }

    }
}
