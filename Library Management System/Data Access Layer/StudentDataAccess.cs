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
    class StudentDataAccess:IStudent
    {
        DatabaseConnection dbc;
        public StudentDataAccess()
        {
            dbc = new DatabaseConnection();
        }
        public bool InsertStudent(Student s)
        {
            //string query = "INSERT into Student Values ('" + s.StudentId + "', '" + s.Name + "', '" + s.Email + "', '" + s.Address + "', " + s.Balance + ", " + s.Fine + ")";
            string query = "INSERT into Students Values ('" + s.StudentId + "', '" + s.Name + "', '" + s.Email + "', '" + s.Address + "', " + s.Balance + ", 0)";
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
        public bool DeleteStudent(Student s)
        {
            string query = "DELETE from Students WHERE StudentId = '" + s.StudentId + "'";
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

        public bool UpdateStudent(Student s)
        {
            string query = "UPDATE Students SET name = '" + s.Name + "', email = '" + s.Email + "', address = '" + s.Address + "', balance = " + s.Balance + ", fine = " + s.Fine + " WHERE studentId = '" + s.StudentId + "'";
            //string query = "UPDATE Student SET Name = '" + s.Name + "', Email = '" + s.Email + "', Address = '" + s.Address + "' WHERE StudentId = '" + s.StudentId + "'";
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

        public bool UpdateStudents(Student s)
        {
            //string query = "UPDATE Student SET Name = '" + s.Name + "', Email = '" + s.Email + "', Address = '" + s.Address + "', Balance = " + s.Balance + ", Fine = " + s.Fine + " WHERE StudentId = '" + s.StudentId + "'";
            string query = "UPDATE Students SET name = '" + s.Name + "', email = '" + s.Email + "', address = '" + s.Address + "' WHERE studentId = '" + s.StudentId + "'";
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

        public Student GetStudent(string studentId)
        {
            Student s = null;
            string query = "SELECT * from Students WHERE StudentId = '" + studentId + "'";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                s = new Student();
                s.StudentId = sdr["studentId"].ToString();
                s.Name = sdr["name"].ToString();
                s.Email = sdr["email"].ToString();
                s.Address = sdr["address"].ToString();
                s.Balance = Convert.ToInt32(sdr["balance"].ToString());
                s.Fine = Convert.ToInt32(sdr["fine"].ToString());
            }

            dbc.CloseConnection();
            return s;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> listOfStudent = new List<Student>();

            string query = "SELECT * from Students";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            if (sdr == null)
            {
                return null;
            }
            else
            {
                while (sdr.Read())
                {
                    Student s = new Student();
                    s.StudentId = sdr["StudentId"].ToString();
                    s.Name = sdr["Name"].ToString();
                    s.Email = sdr["Email"].ToString();
                    s.Address = sdr["Address"].ToString();
                    s.Balance = Convert.ToInt32(sdr["Balance"].ToString());
                    s.Fine = Convert.ToInt32(sdr["Fine"].ToString());

                    listOfStudent.Add(s);
                }

                dbc.CloseConnection();

                return listOfStudent;
            }

        }

    }
}
