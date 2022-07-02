using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.FormDB;
namespace QuanLyBenhVien.FormDB
{
    public partial class MainUser : Form
    {
        public Button currentBtn;
        private Form activeForm;
        private string _user;
        private string _pass;
       // private string UserID;
        public MainUser(string username, string pass)
        {
            InitializeComponent();
            this._user = username;
            this._pass = pass;
           //this.UserID = userid;
           // OpenChildForm(new FormUser.FormListUser(this.UserID), null);
            //btnSCloseChildForm.Visible = false;
            //btnSInfo.Text = this.UserID;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(135, 162, 182); //xanh nhat
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btnSCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelUIMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(18, 39, 55);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //highlight button chosen
            ActivateButton(btnSender);
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelUChildForm.Controls.Add(childform);
            this.panelUChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btnAddUser_Click(object sender, EventArgs e)       
        {
            OpenChildForm(new FormDB.User.FormAddUser(this._user, this._pass), null);
        }

        private void MainUser_Load(object sender, EventArgs e)
        {

        }

        private void panelUChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDB.User.FormListUser(this._user, this._pass), null);
        }

        private void btnGrantUser_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormUser.FormGrantPrivilegeUser(this.UserID), null);
            OpenChildForm(new FormDB.User.FormGrantPrivilegeUser(this._user, this._pass), null);
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDB.AddRole(this._user, this._pass), null);
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDB.GrantRoleForm(this._user, this._pass), null);
        }

        private void btnListRole_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormDB.ShowListRoleForm(this._user, this._pass), null);

        }

       

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form backForm;
            backForm = new FormDB.MainScreen(this._user, this._pass);
            backForm.ShowDialog();
        }
    }
}
