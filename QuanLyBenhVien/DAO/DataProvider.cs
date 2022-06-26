using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyBenhVien.DAO
{
    public class DataProvider
    {
        private String _username;
        private String _password;
        private string _conStr = @"Data Source = (DESCRIPTION =" +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP - L93DHEQ)(PORT = 1521))" +
        "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = xe)" +
        ")" +
        ");User ID=DBA_QLBV; Password=pass123;";
        private static DataProvider instance;
        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set => Instance = value; }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
     
        private DataProvider() { }
        public DataProvider(string username, string pass)
        {
            this._username = username;
            this._password = pass;
            /*this._conStr = "Data Source = (DESCRIPTION ="+
        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP - L93DHEQ)(PORT = 1521))"+
        "(CONNECT_DATA ="+
        "(SERVER = DEDICATED)"+
        "(SERVICE_NAME = orcl)"+
        ")"+
        "); User Id ="";password=" + this._password + ";";*/
        }
        
        public DataTable ExcecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (OracleConnection con = new OracleConnection(_conStr))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split();
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains(":"))
                        {
                            //command.Parameters.Add(item, SqlDbType.NVarChar | SqlDbType.Money | SqlDbType.Int).Value = parameter[i];
                            cmd.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }
    }
}
