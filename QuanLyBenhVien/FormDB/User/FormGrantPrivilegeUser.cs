using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.FormDB.User
{
    public partial class FormGrantPrivilegeUser : Form
    {
        private Form activeForm;
        private string _user;
        private string _pass;
        public FormGrantPrivilegeUser(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
        }

        private void FormGrantPrivilegeUser_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //xóa giao diện cũ trên panel 
            panelGrantPrivilege.Controls.Clear();
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelGrantPrivilege.Controls.Add(childform);
            this.panelGrantPrivilege.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btnGrantPrivilegeUser_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormDB.User.FormGrantPriToUsercs(this._user, this._pass));
            Form newForm;
            newForm = new FormDB.User.FormGrantPriToUsercs(this._user, this._pass);
            newForm.ShowDialog();
        }

        private void btnGrantRoleUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDB.User.FormGrantRoleToUser(this._user, this._pass));
        }
    }
}
