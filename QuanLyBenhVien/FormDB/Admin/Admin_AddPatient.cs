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

namespace QuanLyBenhVien.FormDB.Admin
{
    public partial class Admin_AddPatient : Form
    {
        private string _user;
        private string _pass;
        public Admin_AddPatient(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
            
        }

        private void ad_btn_addpt_Click(object sender, EventArgs e)
        {
            //them tai khoan benh nhan
            string username = ad_txt_ptuser.Text.Trim().ToUpper();
            string password = ad_txt_ptuser.Text.Trim().ToUpper();

            try
            {
                using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
                {

                    conn.Open();
                    string query = "DBA_QLBV.createUser";

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
                    GrantPatient(username);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(" ### ERROR: " + ex.Message);
            }
            //back to main
            OpenMain();
        }

        private void GrantPatient(string user)
        {
            try
            {
                using (OracleConnection conn =  DBUtils.GetDBConnection(_user, _pass))
                {
                    conn.Open();
                    string query = "GRANT BENHNHAN TO " + user;
                    OracleCommand cmd = new OracleCommand(query, conn);
                    int rs;
                    rs = cmd.ExecuteNonQuery();
                    if (rs != 0)
                    {
                        MessageBox.Show("GRANT ROLE Bệnh nhân thành công");

                    }
                    else
                    {
                        MessageBox.Show("GRANT ROLE Bệnh nhân thất bại");

                    }
                    conn.Close();
                }

            }catch(Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }   
        }
        private void Admin_AddPatient_Load(object sender, EventArgs e)
        {

        }
        private void OpenMain()
        {
            this.Hide();
            Form mainform;
            mainform = new Admin_Main(_user, _pass);
            mainform.ShowDialog();
        }

        private void ad_addemp_btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainform;
            mainform = new Admin_Main(_user, _pass);
            mainform.ShowDialog();
        }
    }
}
