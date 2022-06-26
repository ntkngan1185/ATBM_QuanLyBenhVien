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
    public partial class GrantRoleForm : Form
    {
        private string _user;
        private string _pass;
        public GrantRoleForm(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadRoleComboBox();
            LoadActionComboBox();
            LoadTableComboBox();
            //LoadColumnComboBox();
        }
        public void LoadRoleComboBox()
        {
            DataTable table = new DataTable();
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "select granted_role from user_role_privs where granted_role!= 'DBA'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string value = row["GRANTED_ROLE"].ToString();
                    cbSelectRole.Items.Add(value);
                }
                cbSelectRole.SelectedIndex = 0;
                //cbSelectRole.DataSource = table;
                //cbSelectRole.DisplayMember = "GRANTED_ROLE";
                cbSelectRole.AutoCompleteMode = AutoCompleteMode.Append;
                cbSelectRole.AutoCompleteSource = AutoCompleteSource.ListItems;
                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
        }
        public void LoadActionComboBox()
        {
            cbSelectActionRole.Items.Add("SELECT");
            cbSelectActionRole.Items.Add("DELETE");
            cbSelectActionRole.Items.Add("UPDATE");
            cbSelectActionRole.Items.Add("INSERT");
            cbSelectActionRole.SelectedIndex = 0;
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
                    cbTableRole.Items.Add(value);
                }
                
                cbTableRole.SelectedIndex = 0;
                //cbTableRole.DataSource = table;
                //cbTableRole.DisplayMember = "TABLE_NAME";

                cbTableRole.AutoCompleteMode = AutoCompleteMode.Append;
                cbTableRole.AutoCompleteSource = AutoCompleteSource.ListItems;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
            //LoadColumnComboBox(cbTableRole.SelectedText.ToString());
        }
        //public void LoadColumnComboBox(string tableName)
        //{
        //    // get current selected item of table
        //    cbColumnRole.Items.Clear();
        //    DataTable table = new DataTable();
        //    try
        //    {
        //        OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
        //        conn.Open();
        //        string query = "select column_name from user_tab_columns where table_name = '" + tableName + "'";
        //        OracleCommand cmd = new OracleCommand(query, conn);
        //        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
        //        adapter.Fill(table);
        //        foreach (DataRow row in table.Rows)
        //        {
        //            string value = row["COLUMN_NAME"].ToString();
        //            cbColumnRole.Items.Add(value);
        //        }
        //        cbColumnRole.SelectedIndex = 0;
        //        cbColumnRole.Items.Add("ALL");
        //        //cbColumnRole.DataSource = table;
        //        //cbColumnRole.DisplayMember = "COLUMN_NAME";
        //        cbColumnRole.AutoCompleteMode = AutoCompleteMode.Append;
        //        cbColumnRole.AutoCompleteSource = AutoCompleteSource.ListItems;
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("#### ERROR: " + ex.Message);
        //    }
        //    //cbColumnRole.Items.Add("ALL");
        //}
        private void btn_grantRole_Click(object sender, EventArgs e)
        {
            string action = cbSelectActionRole.Items[cbSelectActionRole.SelectedIndex].ToString();
            string tableName = cbTableRole.Items[cbTableRole.SelectedIndex].ToString();
            string rolename = cbSelectRole.Items[cbSelectRole.SelectedIndex].ToString();
            if (action == "DELETE" || action == "INSERT" || action == "SELECT")
            {
                bool isAll = cb_All.Checked;
                if (isAll)
                {
                    try
                    {
                        OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                        conn.Open();
                        string query = "sp_grantPriv"; // for insert and delete

                        DataTable table = new DataTable();
                        OracleCommand cmd = new OracleCommand(query, conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = rolename;
                        cmd.Parameters.Add("@action", OracleDbType.NVarchar2).Value = action;
                        cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = tableName;


                        cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@action"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;

                        int rs = cmd.ExecuteNonQuery();
                        if (rs != 0)
                        {
                            MessageBox.Show("GRANT " + action.ToString() + " on " + tableName
                                    + " to " + rolename + " Successfully");
                        }
                        else
                        {
                            MessageBox.Show("GRANT " + action.ToString() + " on " + tableName
                                     + " to " + rolename + " Failed");

                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("#### ERROR: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please check Grant All checkbox below !!!");
                }
            }
            if (action == "UPDATE")
            {
                int count = dg_grantcol.RowCount - 1;

                
                int i = 0;
                int n = 0;
                bool isOK = false;
                foreach (DataGridViewRow row in dg_grantcol.Rows)
                {
                    Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected)
                    {
                        n++;
                    }
                }
                string[] list = new string[n];
                foreach (DataGridViewRow row in dg_grantcol.Rows)
                {
                    Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected)
                    {
                        string selectedCol = row.Cells["Column1"].Value.ToString(); //column name
                        list[i] = selectedCol;
                        i++;
                    }
                }
                //grant 
                try
                {
                    for (int j = 0; j < list.Length; j++)
                    {
                        OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                        conn.Open();
                        string query = "sp_grantPrivUpdate";
                        OracleCommand cmd = new OracleCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = rolename;
                        cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = tableName;
                        cmd.Parameters.Add("@colname", OracleDbType.NVarchar2).Value = list[j];

                        cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@colname"].Direction = ParameterDirection.Input;
                        int rs = cmd.ExecuteNonQuery();
                        if (rs != 0)
                        {
                            isOK = true;
                        }
                        else
                        {
                            isOK = false;
                        }
                        if (isOK == false)
                        {
                            MessageBox.Show("Grant UPDATE Multi Column Failed!!!");
                            return;
                        }
                        conn.Close();
                    }
                    if (isOK)
                    {
                        MessageBox.Show("Grant UPDATE Multi Column Successfully!!!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("## ERROR: " + ex.Message);
                }
            }

            if (action == "SELECT")
            {
                Boolean isSelected;
                foreach (DataGridViewRow row in dg_grantcol.Rows)
                {
                    isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected == true)
                    {
                        MessageBox.Show("Can not select on specified column! Update later!!");
                        return;
                    }
                }
            }
            //object role = cbSelectRole.SelectedItem as object;
            //object selectedtable = cbTableRole.SelectedItem as object;
            //object column = cbColumnRole.SelectedItem as object;
            //object action = cbSelectActionRole.SelectedItem as object;
            //if (action.ToString()== "INSERT" || action.ToString() == "DELETE" || 
            //        (action.ToString() == "SELECT" && column.ToString() == "ALL") ||
            //        (action.ToString() == "UPDATE" && column.ToString() == "ALL"))
            //{
            //    try
            //    {
            //        OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
            //        conn.Open();
            //        string query = "sp_grantPriv"; // for insert and delete

            //        DataTable table = new DataTable();
            //        OracleCommand cmd = new OracleCommand(query, conn);

            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = role.ToString();
            //        cmd.Parameters.Add("@action", OracleDbType.NVarchar2).Value = action.ToString();
            //        cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = selectedtable.ToString();


            //        cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
            //        cmd.Parameters["@action"].Direction = ParameterDirection.Input;
            //        cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;

            //        int rs = cmd.ExecuteNonQuery();
            //        if (rs != 0)
            //        {
            //            MessageBox.Show("GRANT " + action.ToString() + " on " + selectedtable.ToString()
            //                    + " to " + role.ToString() + " Successfully");
            //        }
            //        else
            //        {
            //            MessageBox.Show("GRANT " + action.ToString() + " on " + selectedtable.ToString()
            //                     + " to " + role.ToString() + " Failed");

            //        }
            //        conn.Close();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine("#### ERROR: " + ex.Message);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("UPDATE THIS ACTION LATER !!!");
            //}
        }

        private void cbTableRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTableRole.SelectedIndex;
            string tableName = cbTableRole.Items[index].ToString();
            //LoadColumnComboBox(tableName);
            LoadTableColumn(tableName);
        }

        private void cbSelectActionRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSelectActionRole.SelectedIndex;
            string action = cbSelectActionRole.Items[index].ToString();
            if (action == "DELETE" || action == "INSERT")
            {
                dg_grantcol.Enabled = false;
               // cbTableRole.Enabled = false;
               // MessageBox.Show(cbSelectActionRole.SelectedText.ToString());
            }
            else
            {
                cbTableRole.Enabled = true;

                //dg_grantcol.Enabled = true;
            }
        }
        public void LoadTableColumn(string tableName)
        {
            dg_grantcol.Rows.Clear(); //delete older data
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
                    DataGridViewRow newrow = new DataGridViewRow();
                    newrow.CreateCells(dg_grantcol);
                    newrow.Cells[0].Value = value;
                    dg_grantcol.Rows.Add(newrow);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
        }
    }
}
