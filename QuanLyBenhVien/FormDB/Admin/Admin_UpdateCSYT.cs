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
    public partial class Admin_UpdateCSYT : Form
    {
        private string _user;
        private string _pass;
        public Admin_UpdateCSYT(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
            LoadCSYT();
        }

        private void LoadCSYT()
        {
            ad_txt_upcsytid.Enabled = false;
            try
            {
                using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
                {
                    conn.Open();
                    DataTable table = new DataTable();
                    string query = "select * from DBA_QLBV.BV_CSYT";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(table);
                    dg_listCSYT.DataSource = table;
                    conn.Close();

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("### ERROR : " + ex.Message);
            }
        }

        private void dg_listCSYT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currRow = dg_listCSYT.CurrentRow;
            string id = currRow.Cells["MACSYT"].Value.ToString(); //select role
            string name = currRow.Cells["TENCSYT"].Value.ToString(); //select action
            string dc = currRow.Cells["DCCSYT"].Value.ToString();
            string sdt = currRow.Cells["SDTCSYT"].Value.ToString();

            ad_txt_upcsytid.Text = id;
            ad_txt_upcsytname.Text = name;
            ad_txt_upcsytsdt.Text = sdt;
            ad_txt_upcsytaddr.Text = dc;

        }

        private void ad_btn_addpt_Click(object sender, EventArgs e)
        {
            string id = ad_txt_upcsytid.Text;
            string name = ad_txt_upcsytname.Text;
            string dc = ad_txt_upcsytaddr.Text;
            string sdt = ad_txt_upcsytsdt.Text;

            try
            {
                using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
                {
                    conn.Open();
                    DataTable table = new DataTable();
                    string query = "DBA_QLBV.sp_AddCSYT"; //update
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
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Update Successfully!!");
                        LoadCSYT();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!!");
                        reset();
                    }
                    conn.Close();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(" ### ERROR : " + ex.Message);
            }


        }

        private void reset()
        {
            DataGridViewRow currRow = dg_listCSYT.CurrentRow;
            string id = currRow.Cells["MACSYT"].Value.ToString(); //select role
            string name = currRow.Cells["TENCSYT"].Value.ToString(); //select action
            string dc = currRow.Cells["DCCSYT"].Value.ToString();
            string sdt = currRow.Cells["SDTCSYT"].Value.ToString();
            ad_txt_upcsytid.Text = id;
            ad_txt_upcsytname.Text = name;
            ad_txt_upcsytsdt.Text = sdt;
            ad_txt_upcsytaddr.Text = dc;

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
