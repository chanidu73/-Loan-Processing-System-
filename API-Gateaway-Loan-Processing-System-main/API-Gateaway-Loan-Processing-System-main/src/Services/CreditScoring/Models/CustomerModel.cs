using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreditScoring.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get;set; }
        public string Name { get;set; }
        public string Email { get;set; }
        public DateTime DateOfBirth { get;set; }
        public decimal AnnualIncome  { get;set; }
        // public CredictScore CredictScore {get;set ; }
    }
}