using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace QuanLyBenhVien.FormDB.Admin
{
    public partial class Admin_FGA : Form
    {
        private string _user;
        private string _pass;
        public Admin_FGA(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass= pass;
            LoadFGA();
        }

        private void LoadFGA()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                string query = "SELECT DB_USER,OBJECT_NAME,SQL_TEXT,EXTENDED_TIMESTAMP FROM dba_fga_audit_trail order by extended_timestamp desc";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_listtable.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
            }
        }

        private void ad_addemp_btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainform;
            mainform = new MainScreen(_user, _pass);
            mainform.ShowDialog();
        }
    }
}
