using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManagement.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<ApplicationModel> Applications { get;set; }
        public DbSet<UserModel> Users  {get;set; }
    }
}