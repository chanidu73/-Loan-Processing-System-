using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreditScoring.Models
{
    public class CreditScoreModel
    {
        [Key]
        public int CredictScoreId { get; set; }
        public int CustomerId { get;set ; }
        public int Score { get;set; }
        public string RiskLevel { get;set; }
        public DateTime LastUpdated { get;set; }
        public CustomerModel Customer { get;set ;}
    }
}