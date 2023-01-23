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
    class BookDataAccess : IBook
    {
        DatabaseConnection dbc;

        public BookDataAccess()
        {
            dbc = new DatabaseConnection();
        }

        public bool InsertBook(Book b)
        {
            string query1 = "INSERT into Book Values ('" + b.BookId + "', '" + b.Name + "', '" + b.Author + "', " + b.Quantity + ", " + b.Price + ", '" + b.Category + "', '" + b.Location + "')";
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

        public bool DeleteBook(Book b)
        {
            string query = "DELETE from Book WHERE BookId = '" + b.BookId + "'";
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

        public bool UpdateBook(Book b)
        {
            string query = "UPDATE Book SET Name = '" + b.Name + "', Author = '" + b.Author + "', Price = " + b.Price + ", Quantity = " + b.Quantity + ", Category = '" + b.Category + "', Location = '" + b.Location + "' WHERE BookId = '" + b.BookId + "'";

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

        public Book GetBook(string bookId)
        {
            Book b = null;
            string query = "SELECT * from Book WHERE BookId = '" + bookId + "'";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                b = new Book();
                b.BookId = sdr["BookId"].ToString();
                b.Name = sdr["Name"].ToString();
                b.Author = sdr["Author"].ToString();
                b.Price = Convert.ToInt32(sdr["Price"].ToString());
                b.Quantity = Convert.ToInt32(sdr["Quantity"].ToString());
                b.Category = sdr["Category"].ToString();
                b.Location = sdr["Location"].ToString();
            }

            dbc.CloseConnection();
            return b;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> listOfBook = new List<Book>();

            string query = "SELECT * from Book";

            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                Book b = new Book();
                b.BookId = sdr["BookId"].ToString();
                b.Name = sdr["Name"].ToString();
                b.Author = sdr["Author"].ToString();
                b.Price = Convert.ToInt32(sdr["Price"].ToString());
                b.Quantity = Convert.ToInt32(sdr["Quantity"].ToString());
                b.Category = sdr["Category"].ToString();
                b.Location = sdr["Location"].ToString();

                listOfBook.Add(b);
            }

            dbc.CloseConnection();

            return listOfBook;
        }
    }
}
