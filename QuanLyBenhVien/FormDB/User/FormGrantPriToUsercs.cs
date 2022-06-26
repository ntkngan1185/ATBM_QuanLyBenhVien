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

namespace QuanLyBenhVien.FormDB.User
{
    public partial class FormGrantPriToUsercs : Form
    {
        //private Form activeForm;
        private string _user;
        private string _pass;
        public FormGrantPriToUsercs(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadComboBoxUserName();
            LoadComboBoxAction();
            LoadComboBoxTable();
        }

        private void FormGrantPriToUsercs_Load(object sender, EventArgs e)
        {

        }

        private void cbUserNamePri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadComboBoxUserName()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT USERNAME FROM ALL_USERS";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbUserNamePri.Items.Add(row["USERNAME"]);
                }    

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }
        void LoadComboBoxAction()
        {
            cbActionUser.Items.Add("Select");
            cbActionUser.Items.Add("Update");
            cbActionUser.Items.Add("Insert");
            cbActionUser.Items.Add("Delete");
        }

        void LoadComboBoxTable()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT TABLE_NAME FROM USER_TABLES";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbTableUser.Items.Add(row["TABLE_NAME"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadComboBoxColumnTable(string tablename)
        {
            //cbColumnUser.Items.Clear();
            cbColumnUser.Items.Add("ALL");
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME = '" + tablename + "'";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbColumnUser.Items.Add(row[0]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        private void cbTableUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbColumnUser.Items.Clear();
            LoadComboBoxColumnTable(cbTableUser.SelectedItem.ToString());
            LoadTableColumn(cbTableUser.SelectedItem.ToString());
            
        }

        private void checkbAllow_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGrantPriUser_Click(object sender, EventArgs e)
        {
            if (cbUserNamePri.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn User name", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUserNamePri.Focus();
                return;
            }
            if (cbActionUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn Action", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbActionUser.Focus();
                return;
            }
            if (cbTableUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn Table", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTableUser.Focus();
                return;
            }

            string username = cbUserNamePri.Text.Trim();
            string action = cbActionUser.Text.Trim();   
            string table = cbTableUser.Text.Trim();
            string column = cbColumnUser.Text.Trim();
            try
            {
                string query;
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();

                if (action == "Insert" || action == "Delete" || (action == "Select" && column.Trim().Length == 0)
                     || (action == "Select" && column == "ALL") 
                    || (action == "Update" && column == "ALL"))
                {
                    if (checkbAllow.Checked == true)
                    {
                        query = "GRANT " + action + " ON " + table + " TO " + username + " WITH GRANT OPTION";
                        OracleCommand cmd = new OracleCommand(query, conn);
                        int rs = cmd.ExecuteNonQuery();
                        if (rs != 0)
                        {
                            MessageBox.Show("GRANT " + action + " ON " + table + " TO " + username + " WITH GRANT OPTION" + " Successfully");
                        }
                        else
                        {
                            MessageBox.Show("GRANT " + action + " ON " + table + " TO " + username + " WITH GRANT OPTION" + " Failed");

                        }
                    }
                    else 
                    { 
                        query = "GRANT " + action + " ON " + table + " TO " + username;
                        OracleCommand cmd = new OracleCommand(query, conn);
                        int rs = cmd.ExecuteNonQuery();
                        if (rs != 0)
                        {
                            MessageBox.Show("GRANT x " + action + " ON " + table + " TO " + username + " Successfully");
                        }
                        else
                        {
                            MessageBox.Show("GRANT x " + action + " ON " + table + " TO " + username + " Failed");

                        }
                    }
                    
                }
                else
                {
                    if (cbActionUser.Text.Trim() == "Update")
                    {
                        if (checkbAllow.Checked == true)
                        {
                            //query = "GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username + " WITH GRANT OPTION";
                            //OracleCommand cmd = new OracleCommand(query, conn);
                            //int rs = cmd.ExecuteNonQuery();
                            //if (rs != 0)
                            //{
                            //    MessageBox.Show("GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username + " WITH GRANT OPTION" + " Successfully");
                            //}
                            //else
                            //{
                            //    MessageBox.Show("GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username + " WITH GRANT OPTION" + " Failed");

                            //}
                            int count = dg_userListCol.RowCount - 1;


                            int i = 0;
                            int n = 0;
                            bool isOK = false;
                            foreach (DataGridViewRow row in dg_userListCol.Rows)
                            {
                                Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                                if (isSelected)
                                {
                                    n++;
                                }
                            }
                            string[] list = new string[n];
                            foreach (DataGridViewRow row in dg_userListCol.Rows)
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
                                    //OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                                    //conn.Open();
                                    string queryU = "sp_grantPrivUpdateUserOption";
                                    OracleCommand cmd = new OracleCommand(queryU, conn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("@username", OracleDbType.NVarchar2).Value = username;
                                    cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = table;
                                    cmd.Parameters.Add("@colname", OracleDbType.NVarchar2).Value = list[j];

                                    cmd.Parameters["@username"].Direction = ParameterDirection.Input;
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
                                        MessageBox.Show("Grant UPDATE User Multi Column Failed!!!");
                                        return;
                                    }
                                    
                                }
                                if (isOK)
                                {
                                    MessageBox.Show("Grant UPDATE User Multi Column Successfully!!!");
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("## ERROR: " + ex.Message);
                            }
                        }
                        else
                        {
                            //query = "GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username;
                            //OracleCommand cmd = new OracleCommand(query, conn);
                            //int rs = cmd.ExecuteNonQuery();
                            //if (rs != 0)
                            //{
                            //    MessageBox.Show("GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username + " Successfully");
                            //}
                            //else
                            //{
                            //    MessageBox.Show("GRANT " + action + "(" + column + ")" + " ON " + table + " TO " + username + " Failed");

                            //}
                            int count = dg_userListCol.RowCount - 1;


                            int i = 0;
                            int n = 0;
                            bool isOK = false;
                            foreach (DataGridViewRow row in dg_userListCol.Rows)
                            {
                                Boolean isSelected = Convert.ToBoolean(row.Cells["Column2"].Value); //checkbox
                                if (isSelected)
                                {
                                    n++;
                                }
                            }
                            string[] list = new string[n];
                            foreach (DataGridViewRow row in dg_userListCol.Rows)
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
                                    //OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                                    //conn.Open();
                                    string queryU = "sp_grantPrivUpdateUser";
                                    OracleCommand cmd = new OracleCommand(queryU, conn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("@username", OracleDbType.NVarchar2).Value = username;
                                    cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = table;
                                    cmd.Parameters.Add("@colname", OracleDbType.NVarchar2).Value = list[j];

                                    cmd.Parameters["@username"].Direction = ParameterDirection.Input;
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
                                        MessageBox.Show("Grant UPDATE User Multi Column Failed!!!");
                                        return;
                                    }
                                    
                                }
                                if (isOK)
                                {
                                    MessageBox.Show("Grant UPDATE User Multi Column Successfully!!!");
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("## ERROR: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (checkbAllow.Checked == true)
                        {           
                            query = "CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table + 
                                ";\nGRANT SELECT ON SELECT" + column + " TO " + username + " WITH GRANT OPTION";
                            MessageBox.Show(query);
                            OracleCommand cmd = new OracleCommand(query, conn);
                            int rs = cmd.ExecuteNonQuery();
                            if (rs != 0)
                            {
                                MessageBox.Show("CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table +
                                "; GRANT SELECT ON SELECT" + column + " TO " + username + " WITH GRANT OPTION" + " Successfully");
                            }
                            else
                            {
                                MessageBox.Show("CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table +
                                "; GRANT SELECT ON SELECT" + column + " TO " + username + " WITH GRANT OPTION" + " Failed");

                            }
                        }
                        else
                        {
                            query = "CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table +
                                "; GRANT SELECT ON SELECT" + column + " TO " + username;
                            OracleCommand cmd = new OracleCommand(query, conn);
                            int rs = cmd.ExecuteNonQuery();
                            if (rs != 0)
                            {
                                MessageBox.Show("CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table +
                                "; GRANT SELECT ON SELECT" + column + " TO " + username + " Successfully");
                            }
                            else
                            {
                                MessageBox.Show("CREATE VIEW SELECT" + column + " AS SELECT " + column + " FROM " + table +
                                "; GRANT SELECT ON SELECT" + column + " TO " + username + " Failed");

                            }
                        }
                    }                            
                        
                        
                    
                }
                //DataTable data = new DataTable();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
             
            
        }

        private void cbActionUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActionUser.Text.Trim() == "Insert" || cbActionUser.Text.Trim() == "Delete")
            {
                cbColumnUser.Hide();
            }
            else
            {
                cbColumnUser.Show();
            }
        }
        public void LoadTableColumn(string tableName)
        {
            dg_userListCol.Rows.Clear(); //delete older data
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
                    newrow.CreateCells(dg_userListCol);
                    newrow.Cells[0].Value = value;
                    dg_userListCol.Rows.Add(newrow);
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
