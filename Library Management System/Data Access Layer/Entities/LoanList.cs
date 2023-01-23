using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Data_Access_Layer.Entities
{
    class LoanList
    {
        private string loanId;
        private string bookId;
        private string studentId;
        private string studentName;
        private int fine;
        private string idate;
        private string ddate;
        private string rdate;
        private string status;

        public LoanList()
        {

        }

        public LoanList(string loanId, string bookId, string studentId, string studentName, string idate, string ddate, string rdate, string status, int fine)
        {
            this.loanId = loanId;
            this.bookId = bookId;
            this.studentId = studentId;
            this.studentName = studentName;
            this.idate = idate;
            this.ddate = ddate;
            this.rdate = rdate;
            this.status = status;
            this.fine = fine;
        }

        public string LoanId
        {
            get { return loanId; }
            set { loanId = value; }
        }

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string IDate
        {
            get { return idate; }
            set { idate = value; }
        }

        public string DDate
        {
            get { return ddate; }
            set { ddate = value; }
        }

        public string RDate
        {
            get { return rdate; }
            set { rdate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Fine
        {
            get { return fine; }
            set { fine = value; }
        }
    }
}
