using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.FormDB.BacSi_YTa
{
    public partial class ShowInfoBS : Form
    {
        private string _user;
        private string _pass;
        public ShowInfoBS(string user, string pass)
        {
            InitializeComponent();
            this._user = user;  
            this._pass = pass;
        }
    }
}
