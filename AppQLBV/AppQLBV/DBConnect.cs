using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQLBV
{
    public static class DBConnect
    {
        static OracleConnection conString = new OracleConnection();
        public static void setConn(string user, string pass) {
            conString = new OracleConnection();
            conString.ConnectionString = "USER ID=" + user + ";PASSWORD=" + pass + ";DATA SOURCE=localhost:1521/XE";
        }
        public static OracleConnection getConn() {
            return conString;
        }
    }
}
