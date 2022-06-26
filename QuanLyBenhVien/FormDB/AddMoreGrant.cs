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
    public partial class AddMoreGrant : Form
    {
        private string _user;
        private string _pass;
        private string _rolename;
        public AddMoreGrant(string user, string pass,string rolename)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            this._rolename = rolename;
            lbl_selectedRolefomore.Text = this._rolename;
            LoadActionComboBox();
            LoadTableComboBox();
        }

        
        public void LoadActionComboBox()
        {
            cb_addAction.Items.Add("SELECT");
            cb_addAction.Items.Add("UPDATE");
            cb_addAction.Items.Add("INSERT");
            cb_addAction.Items.Add("DELETE");
            cb_addAction.SelectedIndex = 0;
        }
        public void LoadTableComboBox()
        {
            DataTable table = new DataTable();
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "select table_name from user_tables";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string value = row["TABLE_NAME"].ToString();
                    cb_AddTable.Items.Add(value);
                }

                cb_AddTable.SelectedIndex = 0;
                //cbTableRole.DataSource = table;
                //cbTableRole.DisplayMember = "TABLE_NAME";

                cb_AddTable.AutoCompleteMode = AutoCompleteMode.Append;
                cb_AddTable.AutoCompleteSource = AutoCompleteSource.ListItems;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
            //LoadColumnComboBox(cbTableRole.SelectedText.ToString());
        }
        public void LoadColumnComboBox(string tableName)
        {
            // get current selected item of table
            //delete older values
            cb_AddColumn.Items.Clear();
            DataTable table = new DataTable();
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "select column_name from user_tab_columns where table_name = '" + tableName + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string value = row["COLUMN_NAME"].ToString();
                    cb_AddColumn.Items.Add(value);
                }
                cb_AddColumn.SelectedIndex = 0;
                cb_AddColumn.Items.Add("ALL");
                //cbColumnRole.DataSource = table;
                //cbColumnRole.DisplayMember = "COLUMN_NAME";
                cb_AddColumn.AutoCompleteMode = AutoCompleteMode.Append;
                cb_AddColumn.AutoCompleteSource = AutoCompleteSource.ListItems;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
            //cbColumnRole.Items.Add("ALL");
        }

        private void cb_AddTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_AddTable.SelectedIndex;
            string selectedTable = cb_AddTable.Items[index].ToString();
            LoadColumnComboBox(selectedTable);
        }

        private void cb_addAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_addAction.SelectedIndex;
            string action = cb_addAction.Items[index].ToString();
            if (action == "DELETE" || action == "INSERT")
            {
                cb_AddColumn.Enabled = false;
               // MessageBox.Show(cbSelectActionRole.SelectedText.ToString());
            }
            else
            {
                cb_AddColumn.Enabled = true;
            }
        }

        private void btn_AddmorePriv_Click(object sender, EventArgs e)
        {
            string role = lbl_selectedRolefomore.Text;
            object selectedtable = cb_AddTable.SelectedItem as object;
            object column = cb_AddColumn.SelectedItem as object;
            object action = cb_addAction.SelectedItem as object;
            if (action.ToString() == "INSERT" || action.ToString() == "DELETE" ||
                    (action.ToString() == "SELECT" && column.ToString() == "ALL"))
            {
                try
                {
                    OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                    conn.Open();
                    string query = "sp_grantPriv"; // for insert and delete

                    DataTable table = new DataTable();
                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = role.ToString();
                    cmd.Parameters.Add("@action", OracleDbType.NVarchar2).Value = action.ToString();
                    cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = selectedtable.ToString();


                    cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@action"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;

                    int rs = cmd.ExecuteNonQuery();
                    if (rs != 0)
                    {
                        MessageBox.Show("GRANT " + action.ToString() + " on " + selectedtable.ToString()
                                + " to " + role.ToString() + " Successfully");
                    }
                    else
                    {
                        MessageBox.Show("GRANT " + action.ToString() + " on " + selectedtable.ToString()
                                 + " to " + role.ToString() + " Failed");

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("#### ERROR: " + ex.Message);
                }

            }
        }

        private void btn_AddBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form backForm;
            backForm = new FormDB.PrivRoleForm(this._user, this._pass, this._rolename);
            backForm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
