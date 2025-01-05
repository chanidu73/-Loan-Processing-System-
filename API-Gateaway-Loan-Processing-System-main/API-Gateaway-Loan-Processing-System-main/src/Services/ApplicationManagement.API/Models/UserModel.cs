using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationManagement.API.Models
{
    public class UserModel
    {
        [Key]
        public int UserId {get;set; }
        public string Name { get;set; }
        public string Email { get;set; }
        public string Phone { get;set;}
        public string Address { get;set; }
        
    }
}