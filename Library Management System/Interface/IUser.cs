using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Interface
{
    interface IUser
    {
        bool InsertUser(User u);
        bool DeleteUser(User u);
        bool UpdateUser(User u);
        User GetUser(string userId, string password);
    }
}
