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
    public partial class ShowListRoleForm : Form
    {
        private string _user;
        private string _pass;
        public ShowListRoleForm(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadListRole();
        }

        public void LoadListRole()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                DataTable table = new DataTable();
                string query = "select * from user_role_privs";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                dg_listrole.DataSource = table;
                conn.Close();
                
            }catch(Exception ex)
            {
                Console.WriteLine("### ERROR : " + ex.Message);
            }
        }

        private void btn_deleterole_Click(object sender, EventArgs e)
        {
            //get current selected row
            DataGridViewRow currRow = dg_listrole.CurrentRow;
            string rolename = currRow.Cells["GRANTED_ROLE"].Value.ToString(); //select role
            DialogResult rs = MessageBox.Show("Message", "Delete this role?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) // dong y xoa
            {
                try
                {
                    OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                    conn.Open();
                    DataTable table = new DataTable();
                    string query = "sp_dropRole";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@rolename", OracleDbType.NVarchar2).Value = rolename;
                   
                    cmd.Parameters["@rolename"].Direction = ParameterDirection.Input;
                   
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Delete Successfully!!");
                        LoadListRole();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!!");

                    }
                    conn.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("#### ERROR: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Deleting Role Canceled !!");
            }
        }

        private void dg_listrole_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dg_listrole.CurrentRow;
            string rolename = row.Cells["GRANTED_ROLE"].Value.ToString();
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.PrivRoleForm(this._user, this._pass, rolename);
            newForm.ShowDialog();
            
        }
    }
}
