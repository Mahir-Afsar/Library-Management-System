using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Data_Access_Layer.Entities
{
    class Book
    {
        private string bookId;
        private string name;
        private string author;
        private int quantity;
        private float price;
        private string category;
        private string location;

        public Book()
        {

        }

        public Book(String bookId, String name, String author, int quantity, float price, string category, string location)
        {
            this.bookId = bookId;
            this.name = name;
            this.author = author;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
            this.location = location;
        }

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
