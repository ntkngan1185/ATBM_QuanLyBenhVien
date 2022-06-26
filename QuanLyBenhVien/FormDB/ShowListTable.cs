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

namespace QuanLyBenhVien.FormDB
{

    public partial class ShowListTable : Form
    {
        private string _user;
        private string _pass;
        public ShowListTable(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadListTable();
        }

        private void LoadListTable()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                string query = "select table_name from user_tables";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_listtable.DataSource = table;
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
            }
        }

        private void btn_detailtable_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg_listtable.CurrentRow;
            string tablename = row.Cells["TABLE_NAME"].Value.ToString();
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.DetailTable(this._user, this._pass, tablename) ;
            MessageBox.Show(this._user);
            newForm.ShowDialog();
        }

        private void dg_listtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
