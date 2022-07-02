using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.FormDB.Admin
{
    public partial class Admin_Main : Form
    {
        private string _user;
        private string _pass;
        public Admin_Main(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
        }

        private void ql_addemp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến thêm nhân viên");
            this.Hide();
            this.Dispose();
            Form newForm;
            newForm = new Admin_Add(_user, _pass);
            //newForm.BringToFront();
            //newForm.Visible = true;
            newForm.ShowDialog();


        }

        private void ql_patient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến thêm bệnh nhân");
            this.Hide();
            //this.Dispose();
            Form newForm;
            newForm = new Admin_AddPatient(_user, _pass);
            //newForm.BringToFront();
            //newForm.Visible = true;
            newForm.ShowDialog();
            //this.Show();
        }

        private void ql_csyt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến thêm CSYT");
            this.Hide();
            Form newForm;
            newForm = new Admin_UpdateCSYT(_user, _pass);
            newForm.ShowDialog();
            
        }
    }
}
