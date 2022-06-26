using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DTO
{
    public class User
    {
        private string userID;
        private string userName;
        private string userPass;
        private DateTime userCreated;

        public User()
        {
            userID = "";
            userName = "";
            userPass = "";
            userCreated = DateTime.Now;
        }
        public User(string UserID, string UserName, string UserPass, DateTime UserCreated)
        {
            this.userID = UserID;
            this.userName = UserName;
            this.userPass = UserPass;
            this.userCreated = UserCreated;
        }

        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public DateTime UserCreated { get => userCreated; set => userCreated = value; }
    }

}
