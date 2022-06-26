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
    public partial class GrantMulti : Form
    {
        private string _user;
        private string _pass;
        private string _rolename;
        public GrantMulti(string user, string pass,string rolename)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            this._rolename = rolename;
            lbl_selectedRoleMulti.Text = this._rolename;
            LoadActionComboBox();
            LoadTableComboBox();
        }
        public void LoadActionComboBox()
        {
            cb_multiaction.Items.Add("SELECT");
            cb_multiaction.Items.Add("UPDATE");
            cb_multiaction.Items.Add("INSERT");
            cb_multiaction.Items.Add("DELETE");
            cb_multiaction.SelectedIndex = 0;
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
                    cb_multitable.Items.Add(value);
                }

                cb_multitable.SelectedIndex = 0;
                //cbTableRole.DataSource = table;
                //cbTableRole.DisplayMember = "TABLE_NAME";

                cb_multitable.AutoCompleteMode = AutoCompleteMode.Append;
                cb_multitable.AutoCompleteSource = AutoCompleteSource.ListItems;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
            //LoadColumnComboBox(cbTableRole.SelectedText.ToString());
        }
        public void LoadTableColumn(string tableName)
        {
            dg_multicolumn.Rows.Clear(); //delete older data
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
                    newrow.CreateCells(dg_multicolumn);
                    newrow.Cells[0].Value = value;
                    dg_multicolumn.Rows.Add(newrow);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
        }

        private void cb_multitable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_multiaction.SelectedIndex;
            string selectedTable = cb_multitable.Items[index].ToString();
            LoadTableColumn(selectedTable);
        }

        private void btn_multiadd_Click(object sender, EventArgs e)
        {
            string action = cb_multiaction.Items[cb_multiaction.SelectedIndex].ToString();
            string tableName = cb_multitable.Items[cb_multitable.SelectedIndex].ToString();
            if (action == "DELETE" || action == "INSERT" || action == "SELECT")
            {
                bool isAll = cbAll.Checked;
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
                        cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = this._rolename;
                        cmd.Parameters.Add("@action", OracleDbType.NVarchar2).Value = action;
                        cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = tableName;


                        cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@action"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;

                        int rs = cmd.ExecuteNonQuery();
                        if (rs != 0)
                        {
                            MessageBox.Show("GRANT " + action.ToString() + " on " + tableName
                                    + " to " + this._rolename + " Successfully");
                        }
                        else
                        {
                            MessageBox.Show("GRANT " + action.ToString() + " on " + tableName
                                     + " to " + this._rolename + " Failed");

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
                int count = dg_multicolumn.RowCount - 1;
               
                
                int i = 0;
                int n=0;
                bool isOK = false;
                foreach (DataGridViewRow row in dg_multicolumn.Rows)
                {
                    Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected)
                    {
                        n++;
                    }
                }
                string[] list = new string[n];
                foreach (DataGridViewRow row in dg_multicolumn.Rows)
                {
                    Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected)
                    {
                        string selectedCol = row.Cells["Column1"].Value.ToString(); //column name
                        list[i] = selectedCol;
                        i++;
                    }
                }
                for (int j = 0; j < list.Length; j++)
                {
                    Console.WriteLine(list[j] + "xx");
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
                        cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = this._rolename;
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
                foreach (DataGridViewRow row in dg_multicolumn.Rows)
                {
                    isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                    if (isSelected==true)
                    {
                        MessageBox.Show("Can not select on specified column! Update later!!");
                        return;
                    }
                }
            }
        }

        private void cb_multiaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_multiaction.SelectedIndex;
            string action = cb_multiaction.Items[index].ToString();
            if (action == "DELETE" || action == "INSERT")
            {
                dg_multicolumn.Enabled = false;
                //cb_multitable.Enabled = false;
                // MessageBox.Show(cbSelectActionRole.SelectedText.ToString());
            }
            else
            {
                dg_multicolumn.Enabled = true;
                //cb_multitable.Enabled = true;

            }
        }

        private void btn_multiBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form backForm;
            backForm = new FormDB.PrivRoleForm(this._user, this._pass, this._rolename);
            backForm.ShowDialog();
        }
    }
}
