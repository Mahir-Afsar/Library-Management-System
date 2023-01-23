using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Interface
{
    interface ILoanList
    {
        bool InsertLoanList(LoanList l);
        bool DeleteLoanList(LoanList l);
        bool UpdateLoanList(LoanList l);
        LoanList GetLoanList(string loanId);
        List<LoanList> GetAllLoanList();
    }
}
