using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class PublicParms
    {
        private static String userName;
        public static String Uname
        {
            set { userName = value; }
            get { return userName; }
        }

        private static String connString = "Database=testassessment;Data Source=localhost;User Id=LK;Password=123456;CharSet=utf8;port=3306";

        public static String ConnStr
        {
            get { return connString; }
        }
    }
}
