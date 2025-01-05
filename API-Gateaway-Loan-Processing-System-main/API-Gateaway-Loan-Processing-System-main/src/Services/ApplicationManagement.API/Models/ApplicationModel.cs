using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationManagement.API.Models
{
    public class ApplicationModel
    {
        [Key]
        public int ApplicationId { get;set; }
        [ForeignKey("User")]
        public int UserId { get;set; }
        public decimal LoanAmount { get;set; }
        public int Tenure  {get;set ; }
        public DateTime ApplicationDate { get;set; }
        public string Status { get;set; }
        
    }
}