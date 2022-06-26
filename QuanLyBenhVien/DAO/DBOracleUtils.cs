using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Tutorial.SqlConn
{
    class DBOracleUtils
    {

        public static OracleConnection
        GetDBConnection(string host, int port, string sid, string user, string password)
        {

            Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));User ID=" + user + ";Password=" + password;


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }

    }
}
