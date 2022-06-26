using Oracle.ManagedDataAccess.Client;
using QuanLyBenhVien.DAO;
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
    public partial class AddRole : Form
    {
        private string _user;
        private string _pass;
        public AddRole(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
        }

        private void btn_createrole_Click(object sender, EventArgs e)
        {
            string rolename = txt_rolename.Text.ToUpper();
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "createRole";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pi_rolename", OracleDbType.NVarchar2).Value = rolename;
                cmd.Parameters.Add("@pi_password", OracleDbType.NVarchar2).Value = "a1";

                cmd.Parameters["@pi_rolename"].Direction = ParameterDirection.Input;
                cmd.Parameters["@pi_password"].Direction = ParameterDirection.Input;

                int rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    MessageBox.Show("CREATE ROLE " + rolename.ToUpper() + " Successfully");
                }
                else
                {
                    MessageBox.Show("CREATE ROLE " + rolename.ToUpper() + "Failed");

                }
                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
            //if (rolename!= "")
            //{
            //    int rs = AdminDAO.Instance.CreateRole(this._user, this._pass, rolename);
            //    if (rs > 0)
            //    {
            //        MessageBox.Show("Create role " + rolename.ToUpper() + " successfully!!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Create role failed!");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter Role name!!");
            //}

        }
    }
}
