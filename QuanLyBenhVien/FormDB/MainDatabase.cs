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
    public partial class MainDatabase : Form
    {
        private string _user;
        private string _pass;
        public Button currentBtn;
        private Form activeForm;
        public MainDatabase(string user, string pass)
        {
            InitializeComponent();
            this._user = user;
            this._pass = pass;

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
            this.panelDB.Controls.Add(childform);
            this.panelDB.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btn_listTable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this._user);
            OpenChildForm(new FormDB.ShowListTable(this._user, this._pass), null);
        }

        private void btn_backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form backForm;
            backForm = new FormDB.MainScreen(this._user, this._pass);
            backForm.ShowDialog();
        }

        private void btn_showlistview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDB.ShowListView(this._user, this._pass), null);
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
