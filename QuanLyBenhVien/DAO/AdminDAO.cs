using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;

namespace QuanLyBenhVien.DAO
{
    public class AdminDAO
    {
        private static AdminDAO instance;

        public static AdminDAO Instance { get { if (instance == null) AdminDAO.instance = new AdminDAO(); return AdminDAO.instance; } private set => instance = value; }
        private AdminDAO()
        {
        }
        public int CreateRole(string username, string pass, string rolename)
        {
            string role = rolename.ToUpper(); //viet hoa tat ca ky tu
            string query = "select*from all_users";
            int rs = 0;
            OracleConnection conn = DBUtils.GetDBConnection(username, pass);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query,conn);
               // cmd.Parameters.Add(new OracleParameter("role", role));
                //OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                rs = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR : " + ex.Message);
            }
            return rs;
        }
    }
}
