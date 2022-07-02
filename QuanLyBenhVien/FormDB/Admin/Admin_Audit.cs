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
    public partial class Admin_Audit : Form
    {
        private string _user;
        private string _pass;
        public Admin_Audit(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
            LoadAudit();
        }

        private void dg_listtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAudit()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                string query = "SELECT USERNAME, SQL_TEXT, TIMESTAMP, OBJ_NAME, ACTION_NAME FROM DBA_AUDIT_TRAIL";
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

        private void Admin_Audit_Load(object sender, EventArgs e)
        {

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
