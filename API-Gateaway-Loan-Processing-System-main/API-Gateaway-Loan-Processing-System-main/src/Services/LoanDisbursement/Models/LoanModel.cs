using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanDisbursement.Models
{
    public class LoanModel
    {
        [Key]
        public int LoanId { get;set; }
        public int CustomerId  {get;set; }
        public decimal LoanAmount { get;set; }
        public decimal InterestRate { get;set; }
        public int TermMonths { get;set; }
        public DateTime StartDate { get;set; }
        public DateTime EndDate { get;set;}
    }
}
// Test the code and save the service 