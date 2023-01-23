using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Data_Access_Layer.Entities
{
    class Student
    {
        private string studentId;
        private string name;
        private string address;
        private string email;
        private int balance;
        private int fine;

        public Student()
        {

        }

        public Student(string studentId, string name, string address, string email, int balance, int fine)
        {
            this.studentId = studentId;
            this.name = name;
            this.address = address;
            this.email = email;
            this.balance = balance;
            this.fine = fine;
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int Fine
        {
            get { return fine; }
            set { fine = value; }
        }
    }
}
