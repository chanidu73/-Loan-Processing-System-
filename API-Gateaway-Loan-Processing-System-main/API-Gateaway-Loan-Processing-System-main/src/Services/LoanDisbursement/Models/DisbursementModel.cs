using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoanDisbursement.Models
{
    public class DisbursementModel
    {
        [Key]
        public int DisbursementId  {get;set; }
        [ForeignKey("Loan")]
        public int LoanId { get;set; }
        public decimal Amount  {get;set ;}
        public DateTime DisbursementDate { get;set;}
        public string Status { get;set; }
        public LoanModel Loan  {get;set;}
    }
}