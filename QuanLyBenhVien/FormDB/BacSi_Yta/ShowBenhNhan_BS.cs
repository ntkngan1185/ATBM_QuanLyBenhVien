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
    public partial class ShowBenhNhan_BS : Form
    {
        private string _user;
        private string _pass;
        public ShowBenhNhan_BS(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadComboBoxMaBN();
            LoadComboBoxCMND();
        }

        void LoadComboBoxMaBN()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT MABN FROM DBA_QLBV.BV_BENHNHAN";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbMaBenhNhan_BS.Items.Add(row["MABN"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadComboBoxCMND()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT CMND FROM DBA_QLBV.BV_BENHNHAN";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbCMND_BS.Items.Add(row["CMND"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadBenhNhan(string input)
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT * FROM DBA_QLBV.BV_BENHNHAN WHERE MABN = '" + input + "' OR CMND = '" + input + "'";
                //TM_DA là username của DBA
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridShowBNhan_BS.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        private void cbMaBenhNhan_BS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCMND_BS.ResetText();
            LoadBenhNhan(cbMaBenhNhan_BS.SelectedItem.ToString());
        }

        private void cbCMND_BS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaBenhNhan_BS.ResetText();
            LoadBenhNhan(cbCMND_BS.SelectedItem.ToString());
        }
    }
}

