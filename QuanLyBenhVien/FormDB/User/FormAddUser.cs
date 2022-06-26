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
    public partial class FormAddUser : Form
    {
        //private Form activeForm;
        private string _user;
        private string _pass;
        public FormAddUser(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
             
        }

        private void ResetValueCapNhat()
        {
            txtUserName.Text = "";
            txtUserPass.Text = "";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return;
            }
            if (txtUserPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserPass.Focus();
                return;
            }
            string username = txtUserName.Text.ToUpper();
            string password = txtUserPass.Text;
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "createUser";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pi_username", OracleDbType.NVarchar2).Value = username;
                cmd.Parameters.Add("@pi_password", OracleDbType.NVarchar2).Value = password;

                cmd.Parameters["@pi_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["@pi_password"].Direction = ParameterDirection.Input;

                int rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    MessageBox.Show("CREATE USER " + username.ToUpper() + " Successfully");
                }
                else
                {
                    MessageBox.Show("CREATE USER " + username.ToUpper() + "Failed");

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
            
            ResetValueCapNhat();
        }
    }
}
