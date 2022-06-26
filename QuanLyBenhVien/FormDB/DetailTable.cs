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

    public partial class DetailTable : Form
    {
        private string _user;
        private string _pass;
        private string _name;
        public DetailTable(string user, string pass, string tableName)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            this._name = tableName;
            LoadDetail();
        }
        private void LoadDetail()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                //string query = "select * where owner = '" +
                //        this._user + "' and table_name = '" + this._name + "'";
                string query = "select table_name, column_name, data_type, data_length from all_tab_columns where owner = '" + this._user + "' and table_name = '" + this._name + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_detailtable.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
            }
        }

        private void btn_detailback_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.MainScreen(this._user, this._pass);
            newForm.ShowDialog();
        }
    }
}
