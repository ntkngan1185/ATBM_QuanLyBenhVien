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
    public partial class ShowListView : Form
    {
        private string _user;
        private string _pass;

        public ShowListView(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadListView();
        }

        public void LoadListView()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                string query = "select owner, view_name from all_views where owner = '" + this._user + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_listview.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
            }
        }

        private void btn_detailview_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg_listview.CurrentRow;
            string viewname = row.Cells["VIEW_NAME"].Value.ToString();
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.DetailedView(this._user, this._pass, viewname);
            MessageBox.Show(this._user);
            newForm.ShowDialog();
        }
    }
}
