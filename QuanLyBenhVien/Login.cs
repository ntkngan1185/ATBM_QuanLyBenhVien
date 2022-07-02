
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
using Oracle.ManagedDataAccess.Client;
using Tutorial.SqlConn;

namespace QuanLyBenhVien
{
    public partial class Login : Form
    {
        private string _user;
        private string _pass;
        private string dba_user = "DBA_QLBV";
        private string dba_pass = "123";
        public Login()
        {
            InitializeComponent();
            _user = txt_user.Text.ToString();
            _pass = txt_pass.Text.ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //khi click thi se lấy username và password
            _user = txt_user.Text.ToString();
            _pass = txt_pass.Text.ToString();
            Form userForm;
            string role = "";
            //MessageBox.Show(_user + " " + _pass);
            if (txt_user.Text == "" || txt_pass.Text=="")
            {
                MessageBox.Show("This field can not be empty !!");
            }
            else
            {
                try
                {
                    using (OracleConnection conn = DBUtils.GetDBConnection(dba_user, dba_pass))
                    {
                        //CheckExist(conn);
                        conn.Open();
                        //MessageBox.Show(_user);
                        // string query = "select count(*) as count from dba_users where username= 'sfdf';";
                        if (_user== "DBA_QLBV")
                        {
                            MessageBox.Show("Xin chào Boss !!!");
                            userForm = new FormDB.MainScreen(txt_user.Text.ToString(), txt_pass.Text.ToString());
                            userForm.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            string query = "select count(*) from dba_users where username= '" + _user + "'";
                            OracleCommand cmd = new OracleCommand(query, conn);
                            DataTable table = new DataTable();
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            adapter.Fill(table);
                            string count = table.Rows[0][0].ToString();
                            int number = Int32.Parse(count);
                            if (number == 0)
                            {
                                MessageBox.Show("Incorrect User!!");
                            }
                            else
                            {
                                role = CheckRole(_user);
                                conn.Close();
                                using (OracleConnection conn2 = DBUtils.GetDBConnection(_user, _pass))
                                {
                                    conn2.Open();
                                    //MessageBox.Show("Welcome " + _user + " !!!");
                                    //this.Hide();

                                    switch (role)
                                    {
                                        case ("DBA_QL"):
                                            MessageBox.Show("Xin chào Quản lý !!!");
                                            userForm = new FormDB.Admin.Admin_Main(txt_user.Text.ToString(), txt_pass.Text.ToString());
                                            userForm.ShowDialog();
                                            this.Dispose();
                                            break;
                                        case ("THANHTRA"):
                                            MessageBox.Show("Xin chào Thanh tra !!!");
                                            userForm = new FormDB.ThanhTra.Main_ThanhTra(txt_user.Text.ToString(), txt_pass.Text.ToString());
                                            userForm.ShowDialog();
                                            this.Dispose();
                                            break;
                                        case ("BACSIYTA"):
                                            MessageBox.Show("Xin chào Bác sĩ !!!");
                                            userForm = new FormDB.BacSi_YTa.MainBSiYTa(txt_user.Text.ToString(), txt_pass.Text.ToString());
                                            userForm.ShowDialog();
                                            this.Dispose();
                                            break;
                                        default:
                                            MessageBox.Show("Thông tin không hợp lệ!!!");
                                            break;
                                    }

                                    conn2.Close();
                                }

                            }

                        }
                        
                    } 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("## ERROR: " + ex.Message);
                }
            }

        }
        private string CheckRole(string username)
        {
            string role = "";
            using (OracleConnection conn = DBUtils.GetDBConnection(dba_user, dba_pass))
            {
                try
                {
                    conn.Open();
                    string query = "select granted_role from dba_role_privs where Granted_role != 'CONNECT' and Granted_role != 'RESOURCE' and grantee= '" + username + "'";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    DataTable table = new DataTable();
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(table);
                    role = table.Rows[0][0].ToString();
                   
                    conn.Close();

                }
                catch(Exception ex)
                {
                    Console.WriteLine(" ###ERROR: " + ex.Message);
                }

            }
            
           return role;
            
        }
        private void CheckExist(OracleConnection connn)
        {
            using (OracleConnection conn = DBUtils.GetDBConnection(dba_user, dba_pass))
            {
                try
                {
                    conn.Open();
                    _user = txt_user.ToString();
                    string query = "select*from dba_users where username= sdfsdf";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    DataTable table = new DataTable();
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(table);
                    MessageBox.Show(table.Rows.Count.ToString());
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Incorrect login!!");
                        
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("### ERROR: " + ex.Message);
                }
                conn.Close();
               
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
