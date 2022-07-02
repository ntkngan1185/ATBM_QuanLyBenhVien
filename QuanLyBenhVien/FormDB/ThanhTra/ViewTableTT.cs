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

namespace QuanLyBenhVien.FormDB.ThanhTra
{
    public partial class ViewTableTT : Form
    {
        private string _user;
        private string _pass;
        public ViewTableTT(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadComboBoxTable();
            cbTableNameTT.Text = "BV_CSYT";
            LoadTable("BV_CSYT");
        }

       

        private void ViewTableTT_Load(object sender, EventArgs e)
        {

        }

        private void gridInfTableTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoadComboBoxTable()
        {
            cbTableNameTT.Enabled = true;
            
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = 'DBA_QLBV'"; //TM_DA là tên DBA
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbTableNameTT.Items.Add(row["TABLE_NAME"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadTable(string tablename)
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT * FROM DBA_QLBV." + tablename; //TM_DA là username của DBA
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridInfTableTT.DataSource = table;
               
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

       
        private void cbTableNameTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable(cbTableNameTT.SelectedItem.ToString());
        }
    }
}
