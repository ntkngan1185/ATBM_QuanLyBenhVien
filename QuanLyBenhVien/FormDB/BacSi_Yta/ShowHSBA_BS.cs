using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.DAO;
using QuanLyBenhVien.DTO;
using Oracle.ManagedDataAccess.Client;
using Tutorial.SqlConn;

namespace QuanLyBenhVien.FormDB.BacSi_YTa
{
    public partial class ShowHSBA_BS : Form
    {
        private string _user;
        private string _pass;
        public ShowHSBA_BS(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            ShowHSBA_BacSi();
        }

        void ShowHSBA_BacSi()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT * FROM DBA_QLBV.BV_HSBA"; //TM_DA là username của DBA
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridShowHSBA_BS.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }
    }
}
