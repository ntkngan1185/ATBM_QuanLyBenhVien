
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
        private string dba_user = "SYS";
        private string dba_pass = "o18";
        public Login()
        {
            InitializeComponent();
            _user = txt_user.Text.ToString();
            _pass = txt_pass.Text.ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //khi click thi se lấy username và password
            
            if (txt_user.Text == "" || txt_pass.Text=="")
            {
                MessageBox.Show("This field can not be empty !!");
            }
            else
            {
                
                OracleConnection conn = DBUtils.GetDBConnection(dba_user, dba_pass);
                bool isCorrect = CheckExist(conn);
                if (isCorrect)
                {
                    MessageBox.Show("Welcome !!");
                    this.Hide();
                    Form userForm;
                    userForm = new FormDB.MainScreen(txt_user.Text.ToString(), txt_pass.Text.ToString());

                    userForm.ShowDialog();
                    this.Dispose();
                }
                else
                {

                }
            }
            

        }
        private bool CheckExist(OracleConnection conn)
        {
            try
            {
                conn.Open();
                string query = "select*from all_users";
                OracleCommand cmd = new OracleCommand(query, conn);
                DataTable table = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Incorrect login!!");
                    return false;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
            return true;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
