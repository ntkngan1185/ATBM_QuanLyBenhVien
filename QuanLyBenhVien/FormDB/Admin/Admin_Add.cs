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
    public partial class Admin_Add : Form
    {
        private string _user;
        private string _pass;
        public Admin_Add(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadCbCKhoa();
            LoadCbCSYT();
            LoadCbGender();
            LoadCbRole();
            
        }

        private void ad_btn_addemp_Click(object sender, EventArgs e)
        {
            //them user
            
            string id = ad_txt_empid.Text.ToUpper().Trim();
            string role = ad_cb_role.Items[ad_cb_role.SelectedIndex].ToString();
            string name = ad_txt_empname.Text;
            string gender = ad_cb_sex.Items[ad_cb_sex.SelectedIndex].ToString();
            string dob = ad_dtp_dob.Value.Date.ToString("dd-MM-yyyy");
            DateTime dobtime = DateTime.ParseExact(dob, "dd-MM-yyyy", null);
            string cmnd = ad_txt_cmnd.Text;
            string addr = ad_txt_addr.Text;
            string phone = ad_txt_phone.Text;
            string csyt = ad_cb_csyt.Items[ad_cb_csyt.SelectedIndex].ToString();
            string chuyenkhoa = ad_cb_ck.Items[ad_cb_ck.SelectedIndex].ToString();

            //MessageBox.Show("ROLE LA: " + role);
            //CREATE USER, GRANT ROLE
            CreateUser(id, role);
            MessageBox.Show(this._user, this._pass);
            using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
            {
                try
                {
                    conn.Open();
                    
                    string query = "DBA_QLBV.addEmployee";
                    DataTable table = new DataTable();
                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ip_MANV", OracleDbType.Varchar2).Value = id;
                    cmd.Parameters.Add("@ip_HOTEN", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("@ip_PHAI", OracleDbType.Varchar2).Value = gender;
                    cmd.Parameters.Add("@ip_NGAYSINH", OracleDbType.Date).Value = dobtime;
                    cmd.Parameters.Add("@ip_CMND", OracleDbType.Varchar2).Value = cmnd;
                    cmd.Parameters.Add("@ip_QUEQUAN", OracleDbType.Varchar2).Value = addr;
                    cmd.Parameters.Add("@ip_SODT", OracleDbType.Varchar2).Value = phone;
                    cmd.Parameters.Add("@ip_CSYT", OracleDbType.Varchar2).Value = csyt;
                    cmd.Parameters.Add("@ip_VAITRO", OracleDbType.Varchar2).Value = role;
                    cmd.Parameters.Add("@ip_CHUYENKHOA", OracleDbType.Varchar2).Value = chuyenkhoa;


                    cmd.Parameters["@ip_MANV"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_HOTEN"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_PHAI"].Direction = ParameterDirection.Input;

                    cmd.Parameters["@ip_NGAYSINH"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_CMND"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_QUEQUAN"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_SODT"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_CSYT"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_VAITRO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ip_CHUYENKHOA"].Direction = ParameterDirection.Input;

                   
                    int rs = cmd.ExecuteNonQuery();
                    if (rs != 0)
                    {
                        MessageBox.Show("THÊM NHÂN VIÊN " + id + " THÀNH CÔNG");
                    }
                    else
                    {
                        MessageBox.Show("THÊM NHÂN VIÊN " + id + "THẤT BẠI");

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("## ERROR : " + ex.Message);
                }
                conn.Close();
            }
            
        }

        private void LoadCbRole()
        {
            ad_cb_role.Items.Add("Thanh tra");
            ad_cb_role.Items.Add("Nghien cuu");
            ad_cb_role.Items.Add("Nhan vien CSYT");
            ad_cb_role.Items.Add("Bac si");
            ad_cb_role.Items.Add("Y ta");

            ad_cb_role.SelectedIndex = 0;
        }
        private void LoadCbGender()
        {
            ad_cb_sex.Items.Add("Nam");
            ad_cb_sex.Items.Add("Nữ");
            ad_cb_sex.Items.Add("Giới tính khác");

            ad_cb_sex.SelectedIndex = 0;
        }
        private void LoadCbCKhoa()
        {
            ad_cb_ck.Items.Add("Khoa thần kinh");
            ad_cb_ck.Items.Add("Khoa Xương");
            ad_cb_ck.Items.Add("Khoa Nội");

            ad_cb_ck.SelectedIndex = 0;
        }
        private void LoadCbCSYT()
        {
            try
            {
                using (OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass))
                {

                    conn.Open();
                    string query = "SELECT MACSYT FROM DBA_QLBV.BV_CSYT";
                    DataTable table = new DataTable();
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        string value = row["MACSYT"].ToString();
                        ad_cb_csyt.Items.Add(value);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            ad_cb_csyt.SelectedIndex = 0;
        }
        private void CreateUser(string id, string vt)
        {
            string username = id.ToUpper().Trim();
            string password = id.ToUpper().Trim();
            string role = vt.ToUpper().Trim();

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

                    string query1 = "";

                    switch (vt)
                    {
                        case "Thanh tra":
                            query1 = "GRANT THANHTRA TO " + username;
                            break;
                        case "Nghien cuu":
                            query1 = "GRANT NGHIENCUU TO " + username;
                            break;
                        case "Nhan vien CSYT":
                            query1 = "GRANT NV_CSYT TO " + username;
                            break;
                        case "Bac si":
                            query1 = "GRANT BACSIYTA TO " + username;
                            break;
                        case "Y ta":
                            query1 = "GRANT BACSIYTA TO " + username;
                            break;
                        default:
                            break;
                    }
                    cmd = new OracleCommand(query1, conn);
                    int rs1 = cmd.ExecuteNonQuery();
                    if (rs1 != 0)
                    {
                        MessageBox.Show("GRANT ROLE " + vt + " Successfully");
                    }
                    else
                    {
                        MessageBox.Show("GRANT ROLE " + vt + " Failed");
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
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
