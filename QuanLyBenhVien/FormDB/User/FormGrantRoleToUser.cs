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
    public partial class FormGrantRoleToUser : Form
    {
        //private Form activeForm;
        private string _user;
        private string _pass;
        public FormGrantRoleToUser(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadComboBoxUserNameRole();
            LoadComboBoxRoleName();
        }

        private void FormGrantRoleToUser_Load(object sender, EventArgs e)
        {

        }
        void LoadComboBoxUserNameRole()
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
                    cbUserNameRole.Items.Add(row["USERNAME"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        void LoadComboBoxRoleName()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT GRANTED_ROLE FROM user_role_privs";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cbGrantRoleU.Items.Add(row["GRANTED_ROLE"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }

        private void cbUserNameRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrantRoleUser_Click(object sender, EventArgs e)
        {
            if (cbUserNameRole.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn User", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUserNameRole.Focus();
                return;
            }
            if (cbGrantRoleU.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn Role", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGrantRoleU.Focus();
                return;
            }
            string username = cbUserNameRole.Text.Trim();
            string rolename = cbGrantRoleU.Text.Trim();
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "GRANT " + rolename + " TO " + username;
                //DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);

                int rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    MessageBox.Show("GRANT USER " + username + " TO " + rolename + " Successfully");
                }
                else
                {
                    MessageBox.Show("GRANT USER " + username + " TO " + rolename + " Failed");

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
        }
    }
}
