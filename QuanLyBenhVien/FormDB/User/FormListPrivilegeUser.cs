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
using QuanLyBenhVien.FormDB.User;
namespace QuanLyBenhVien.FormDB.User
{
    public partial class FormListPrivilegeUser : Form
    {
        //private Form activeForm;
        private string _user;
        private string _pass;
        private string _username;
        public FormListPrivilegeUser(string user, string pass, string username)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            this._username = username;
            LoadUserName();
            LoadListPriRoleU();
        }

        private void FormListPrivilegeUser_Load(object sender, EventArgs e)
        {

        }

        void LoadUserName()
        {
            txtUser.Text = this._username;
        }

        void LoadListPriColumnU()
        {
            checkBoxColumn.Enabled = true;
            checkBoxRole.Enabled = false;
            checkBoxTable.Enabled = false;
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT GRANTEE, TABLE_NAME, COLUMN_NAME, PRIVILEGE FROM ALL_COL_PRIVS WHERE GRANTEE = '" + this._username + "'";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridListPrivilegeUser.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadListPriRoleU()
        {
            checkBoxRole.Enabled = true;
            checkBoxColumn.Enabled = false;
            checkBoxTable.Enabled = false;
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT GRANTEE, GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + this._username + "'";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridListPrivilegeUser.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadListPriTableU()
        {
            checkBoxTable.Enabled = true;
            checkBoxRole.Enabled = false;
            checkBoxColumn.Enabled = false;
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT GRANTEE, TABLE_NAME, PRIVILEGE FROM ALL_TAB_PRIVS WHERE GRANTEE = '" + this._username + "'";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridListPrivilegeUser.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridListPrivilegeUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListPriRoleU_Click(object sender, EventArgs e)
        {
            LoadListPriRoleU();
        }

        private void btnListPriTableU_Click(object sender, EventArgs e)
        {
            LoadListPriTableU();
        }

        private void btnListPriColumnU_Click(object sender, EventArgs e)
        {
            LoadListPriColumnU();
        }

        private void btnRevokePrivilege_Click(object sender, EventArgs e)
        {
            string user;
            string role;
            string table;
            string pri;
            string col;
            string query = "";
            int i = 0;
            DataGridViewRow currRow = gridListPrivilegeUser.CurrentRow;
            if (checkBoxRole.Enabled == true)
            {
                i = 1;
                user = currRow.Cells[0].Value.ToString();
                role = currRow.Cells[1].Value.ToString();
                query = "REVOKE " + role + " FROM " + user;
            }
            else
            {
                if (checkBoxTable.Enabled == true)
                {
                    i = 2;
                    user = currRow.Cells[0].Value.ToString();
                    table = currRow.Cells[1].Value.ToString();
                    pri = currRow.Cells[2].Value.ToString();
                    query = "REVOKE " + pri + " ON " + table + " FROM " + user;
                }
                else
                {
                    i = 3;
                    user = currRow.Cells[0].Value.ToString();
                    table = currRow.Cells[1].Value.ToString();
                    col = currRow.Cells[2].Value.ToString();
                    pri = currRow.Cells[3].Value.ToString();
                    query = "REVOKE " + pri + " ON " + table + " FROM " + user;
                }
            }
            DialogResult rs = MessageBox.Show("Message", "Delete this privilege?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) // dong y xoa
            {
                try
                {
                    OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                    conn.Open();
                    DataTable data = new DataTable();
                    OracleCommand cmd = new OracleCommand(query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Delete Successfully!!");
                        if (i == 1)
                        { LoadListPriRoleU(); }
                        else
                        {
                            if (i == 2)
                            {
                                LoadListPriTableU();
                            }
                            else
                            {
                                LoadListPriColumnU();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!!");

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
                MessageBox.Show("Deleting User Canceled !!");
            }
        }
    }

}
