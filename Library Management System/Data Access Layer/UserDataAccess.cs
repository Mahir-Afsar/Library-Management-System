using Library_Management_System.Data_Access_Layer.Entities;
using Library_Management_System.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Data_Access_Layer
{
    class UserDataAccess:IUser
    {
        DatabaseConnection dbc;
        public UserDataAccess()
        {
            dbc = new DatabaseConnection();
        }

        public User GetUser(string userId, string password)
        {
            User u = null;

            string query = "SELECT * from [User] WHERE userId = '" + userId + "' AND password = '" + password + "'";
            try
            {
                dbc.ConnectWithDB();
                SqlDataReader sdr = dbc.GetData(query);

                while (sdr.Read())
                {
                    u = new User();
                    u.UserId = sdr["UserId"].ToString();
                    u.Password = sdr["Password"].ToString();
                    u.Status = Convert.ToInt32(sdr["Status"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
                //MessageBox.Show(e.Message);
            }

            dbc.CloseConnection();
            return u;
        }

        public bool InsertUser(User u)
        {
            string query = "INSERT into [User] Values ('" + u.UserId + "', '" + u.Password + "', " + u.Status + ")";
            try
            {
                dbc.ConnectWithDB();
                int n = dbc.ExecuteSQL(query);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                dbc.CloseConnection();
            }
        }

        public bool DeleteUser(User u)
        {
            string query = "DELETE from [User] WHERE UserId = '" + u.UserId + "'";

            try
            {
                dbc.ConnectWithDB();
                int n = dbc.ExecuteSQL(query);
                dbc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateUser(User u)
        {
            string query = "Update [User] SET Password = '" + u.Password + "' WHERE UserId = '" + u.UserId + "'";

            try
            {
                dbc.ConnectWithDB();
                int n = dbc.ExecuteSQL(query);
                dbc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
