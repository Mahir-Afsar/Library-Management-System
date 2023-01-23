using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Data_Access_Layer.Entities
{
    class User
    {
        private string userId;
        private string password;
        private int status;

        public User()
        {

        }

        public User(String userId, String password, int status)
        {
            this.userId = userId;
            this.password = password;
            this.status = status;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
