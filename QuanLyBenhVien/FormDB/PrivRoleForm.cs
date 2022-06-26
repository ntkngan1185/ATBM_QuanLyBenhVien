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

    public partial class PrivRoleForm : Form
    {
        private string _user;
        private string _pass;
        private string _rolename;
        public PrivRoleForm(string user, string pass, string rolename)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            this._rolename = rolename;
            LoadPrivs();
        }

        public void LoadPrivs()
        {
            lbl_selectedRole.Text = this._rolename;
            try
            {
                DataTable table = new DataTable();
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "select * from  role_tab_privs where role = '" + this._rolename + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_listprivrole.DataSource = table;
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("#### ERROR: " + ex.Message);
            }
        }

        private void btn_addmorePriv_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            //newForm = new FormDB.AddMoreGrant(this._user, this._pass, this._rolename);
            newForm = new FormDB.GrantMulti(this._user, this._pass, this._rolename);
            newForm.ShowDialog();
        }

        private void btn_revokeRole_Click(object sender, EventArgs e)
        {
            DataGridViewRow currRow = dg_listprivrole.CurrentRow;
            string rolename = currRow.Cells["ROLE"].Value.ToString(); //select role
            string actionPriv = currRow.Cells["PRIVILEGE"].Value.ToString(); //select action
            string tablePriv = currRow.Cells["TABLE_NAME"].Value.ToString();
            //string columnPriv = currRow.Cells["COLUMN_NAME"].ToString();
            DialogResult rs = MessageBox.Show("Revoke this privilege?", "Message: This action will " + 
                "revoke privileges on entire table!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) // dong y xoa
            {
                try
                {
                    OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                    conn.Open();
                    DataTable table = new DataTable();
                    string query = "sp_RevokeRolePriv";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = rolename;
                    cmd.Parameters.Add("@action", OracleDbType.NVarchar2).Value = actionPriv;
                    cmd.Parameters.Add("@tablename", OracleDbType.NVarchar2).Value = tablePriv;

                    cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@action"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@tablename"].Direction = ParameterDirection.Input;

                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Revoke Successfully!!");
                        LoadPrivs();
                    }
                    else
                    {
                        MessageBox.Show("Revoke Failed!!");

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
                MessageBox.Show("Revoking Privilege of Role Canceled !!");
            }
        }
    }
}
