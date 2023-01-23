using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Interface
{
    interface IBook
    {
        bool InsertBook(Book b);
        bool DeleteBook(Book b);
        bool UpdateBook(Book b);
        Book GetBook(string bookId);
        List<Book> GetAllBooks();
    }
}
