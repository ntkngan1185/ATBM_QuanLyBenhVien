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
    public partial class Admin_AddCSYT : Form
    {
        private string _user;
        private string _pass;
        public Admin_AddCSYT(string user, string pass)
        {
            InitializeComponent();
            _user= user;    
            _pass = pass;
        }

        private void ad_btn_addcsyt_Click(object sender, EventArgs e)
        {
            string id = ad_txt_csytid.Text.Trim().ToUpper();
            string name = ad_txt_csytname.Text;
            string dc = ad_txt_csytaddr.Text;
            string sdt = ad_txt_csytphone.Text;

            try
            {
                using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
                {
                    conn.Open();
                    string query = "DBA_QLBV.sp_addCSYT";
                    DataTable table = new DataTable();
                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ip_MACSYT", OracleDbType.Varchar2).Value = id;
                    cmd.Parameters.Add("@ip_TENCSYT", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("@ip_DC", OracleDbType.Varchar2).Value = dc;
                    cmd.Parameters.Add("@ip_SDT", OracleDbType.Varchar2).Value = sdt;
                   

                    cmd.Parameters["@ip_MACSYT"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_TENCSYT"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_DC"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_SDT"].Direction = ParameterDirection.Input;
                    


                    int rs = cmd.ExecuteNonQuery();
                    if (rs != 0)
                    {
                        MessageBox.Show("THÊM CSYT " + id + " THÀNH CÔNG");
                    }
                    else
                    {
                        MessageBox.Show("THÊM CSYT " + id + "THẤT BẠI");

                    }
                    conn.Close();

                }
                

            }
            catch(Exception ex)
            {
                Console.WriteLine("### ERROR: " + ex.Message);
            }
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
