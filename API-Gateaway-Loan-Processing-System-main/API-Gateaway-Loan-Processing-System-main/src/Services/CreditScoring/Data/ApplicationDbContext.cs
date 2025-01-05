using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditScoring.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<CreditScoreModel> CreditScores { get;set; }
        public DbSet<CustomerModel> Customers { get;set; } 
    }
}