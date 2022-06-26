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
    public partial class FormListUser : Form
    {
        private Form activeForm;
        private string _user;
        private string _pass;
        public FormListUser(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
            LoadListUser();
        }

        void LoadListUser()
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                conn.Open();
                string query = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(table);
                gridListUser.DataSource = table;
                /*
                foreach (DataRow row in table.Rows)
                {
                    DataGridViewRow newrow = new DataGridViewRow();
                    newrow.CreateCells(gridListUser);
                    newrow.Cells[0].Value = row[0];
                    newrow.Cells[1].Value = row[1]; 
                    newrow.Cells[2].Value = row[2];
                    gridListUser.Rows.Add(newrow);
                }*/

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("##ERROR " + ex.Message);
            }
        }
        private void FormListUser_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //xóa giao diện cũ trên panel 
            panelListUser.Controls.Clear();
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelListUser.Controls.Add(childform);
            this.panelListUser.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void gridListUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = gridListUser.Rows[index];
            string username = row.Cells[0].Value.ToString();
            OpenChildForm(new FormDB.User.FormListPrivilegeUser(this._user, this._pass, username));
        }

        private void gridListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow currRow = gridListUser.CurrentRow;
            string username = currRow.Cells[0].Value.ToString();
            DialogResult rs = MessageBox.Show("Message", "Delete this user?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) // dong y xoa
            {
                try
                {
                    OracleConnection conn = DBUtils.GetDBConnection(this._user, this._pass);
                    conn.Open();
                    DataTable table = new DataTable();
                    string query = "sp_dropUser";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", OracleDbType.NVarchar2).Value = username;

                    cmd.Parameters["@username"].Direction = ParameterDirection.Input;

                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Delete Successfully!!");
                        LoadListUser();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!!");

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("#### ERROR: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Deleting User Canceled !!");
            }
        }

        private void panelListUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
