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
    class LoanListDataAccess: ILoanList
    {
        DatabaseConnection dbc;

        public LoanListDataAccess()
        {
            dbc = new DatabaseConnection();
        }

        public bool InsertLoanList(LoanList l)
        {
            //string query1 = "INSERT into IssueBook Values ('" + l.LoanId + "', '" + l.BookId + "', '" + l.StudentName + "', '" + l.StudentId + "', '" + l.IDate + "','" + l.DDate + "', '" + l.Status + "', '" + l.RDate + "', " + l.Fine + ")";
            string query1 = "INSERT into IssueBook Values ('" + l.LoanId + "', '" + l.BookId + "', '" + l.StudentName + "', '" + l.StudentId + "', '" + l.IDate + "','" + l.DDate + "', '" + l.Status + "', '" + l.RDate + "', 0)";
            //string query2 = "UPDATE Book SET Quantity =  Quantity - 1  WHERE BookId = '" + l.BookId + "'";
            //string query3 = "INSERT into History Values ('" + l.Fine + "', '" + l.LoanId + "', '" + l.BookId + "', '" + l.StudentId + "','" + l.DDate + "', '" + l.RDate + "')";

            try
            {
                dbc.ConnectWithDB();

                int n1 = dbc.ExecuteSQL(query1);
              //  int n2 = dbc.ExecuteSQL(query2);
                //int n3 = dbc.ExecuteSQL(query3);

                dbc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteLoanList(LoanList l)
        {
            string query = "DELETE from IssueBook WHERE LoanId = '" + l.LoanId + "'";
            //string query2 = "UPDATE Book SET Quantity =  Quantity + 1  WHERE BookId = '" + l.BookId + "'";

            try
            {
                dbc.ConnectWithDB();

                //int n1 = dbc.ExecuteSQL(query2);
                int n2 = dbc.ExecuteSQL(query);

                dbc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateLoanList(LoanList l)
        {
            string query1 = "UPDATE IssueBook SET StudentName = '" + l.StudentName + "', BookId = '" + l.BookId + "', StudentId = '" + l.StudentId + "', IssueDate = '" + l.IDate + "', DueDate = '" + l.DDate + "', ReturnDate = '" + l.RDate + "', Status = '" + l.Status + "', Fine = '" + l.Fine + "' WHERE LoanId = '" + l.LoanId + "'";


            try
            {
                dbc.ConnectWithDB();

                int n1 = dbc.ExecuteSQL(query1);
               

                dbc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public LoanList GetLoanList(string loanId)
        {
            LoanList l = null;
            string query = "SELECT * from IssueBook WHERE LoanId = '" + loanId + "'";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                l = new LoanList();
                l.LoanId = sdr["LoanId"].ToString();
                l.BookId = sdr["BookId"].ToString();
                l.StudentId = sdr["StudentId"].ToString();
                l.StudentName = sdr["StudentName"].ToString();
                l.IDate = sdr["IssueDate"].ToString();
                l.DDate = sdr["DueDate"].ToString();
                l.RDate = sdr["ReturnDate"].ToString();
                l.Status = sdr["Status"].ToString();
                l.Fine = Convert.ToInt32(sdr["Fine"].ToString());
            }

            dbc.CloseConnection();
            return l;
        }
        public List<LoanList> GetAllLoanList()
        {
            List<LoanList> listOfLoan = new List<LoanList>();

            string query = "SELECT * from IssueBook";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                LoanList l = new LoanList();
                l.LoanId = sdr["LoanId"].ToString();
                l.BookId = sdr["BookId"].ToString();
                l.StudentId = sdr["StudentId"].ToString();
                l.StudentName = sdr["StudentName"].ToString();
                l.IDate = sdr["IssueDate"].ToString();
                l.DDate = sdr["DueDate"].ToString();
                l.RDate = sdr["ReturnDate"].ToString();
                l.Status = sdr["Status"].ToString();
                l.Fine = Convert.ToInt32(sdr["Fine"].ToString());

                listOfLoan.Add(l);
            }

            dbc.CloseConnection();

            return listOfLoan;
        }

        public List<LoanList> GetAllLoanLists()
        {
            List<LoanList> listOfLoan = new List<LoanList>();
            User u = new User();

            string query = "SELECT * from IssueBook where status = 'Issued'";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                LoanList l = new LoanList();
                l.LoanId = sdr["LoanId"].ToString();
                l.BookId = sdr["BookId"].ToString();
                l.StudentId = sdr["StudentId"].ToString();
                l.StudentName = sdr["StudentName"].ToString();
                l.IDate = sdr["IssueDate"].ToString();
                l.DDate = sdr["DueDate"].ToString();
                l.RDate = sdr["ReturnDate"].ToString();
                l.Status = sdr["Status"].ToString();
                l.Fine = Convert.ToInt32(sdr["Fine"].ToString());

                listOfLoan.Add(l);
            }

            dbc.CloseConnection();

            return listOfLoan;
        }

    }
}
