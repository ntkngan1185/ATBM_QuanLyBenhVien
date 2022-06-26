﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection(string username, string pass)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            string user = username;
            string password = pass;

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }

}