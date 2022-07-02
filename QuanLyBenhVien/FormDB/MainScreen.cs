using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.FormDB
{
    public partial class MainScreen : Form
    {
        private string _user;
        private string _pass;
        public MainScreen(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;
        }

        private void btn_userrole_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.MainUser(this._user, this._pass);
            newForm.ShowDialog();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.MainDatabase(this._user, this._pass);
            newForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this._user);
        }

        private void btn_Audit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.Admin.Admin_Audit(this._user, this._pass);
            newForm.ShowDialog();
        }

        private void btn_fga_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new FormDB.Admin.Admin_FGA(this._user, this._pass);
            newForm.ShowDialog();
        }
    }
}
