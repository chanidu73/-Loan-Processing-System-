using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanDisbursement.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {}
        public DbSet<LoanModel>Loans { get;set; }
        public DbSet<DisbursementModel> Disbursements  {get;set; }
    }
}
