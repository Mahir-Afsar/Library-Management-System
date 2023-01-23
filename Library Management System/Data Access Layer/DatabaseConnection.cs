using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Data_Access_Layer
{
    class DatabaseConnection
    {
        static SqlConnection myConnection;
        static SqlCommand cmd;

        public DatabaseConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["LibraryManagment"].ConnectionString;
            myConnection = new SqlConnection(con);
        }

        public void ConnectWithDB()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
        }

        public SqlDataReader GetData(string query)
        {
            cmd = new SqlCommand(query, myConnection);
            return cmd.ExecuteReader();
        }

        public int ExecuteSQL(string query)
        {
            cmd = new SqlCommand(query, myConnection);
            return cmd.ExecuteNonQuery();
        }

        public static bool ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryManagment"].ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
        }
    }
}
