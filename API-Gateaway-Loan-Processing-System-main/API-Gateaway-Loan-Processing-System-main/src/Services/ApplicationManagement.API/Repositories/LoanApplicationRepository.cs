using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Data;
using ApplicationManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManagement.API.Repositories
{
    public class LoanApplicationRepository:ILoanApplicationRepository
    {
        private readonly ApplicationDbContext _context;
        public LoanApplicationRepository(ApplicationDbContext context)
        {
            _context =context;
        }

        public async Task AddAsync(ApplicationModel application)
        {
            await _context.Applications.AddAsync(application);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            if(application != null)
            {
                _context.Applications.Remove(application);
                await _context.SaveChangesAsync(); 
            }
        }

        public async Task<IEnumerable<ApplicationModel>> GetAllAsync()
        {
            return await _context.Applications.ToListAsync();
        }

        public async Task<ApplicationModel?> GetByIdAsync(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public async Task<IEnumerable<ApplicationModel>> GetPendingApplicationsAsync()
        {
            return await _context.Applications.Where(la =>la.Status == "Pending").ToListAsync();
        }

        public async Task UpdateAsync(ApplicationModel application)
        {
            _context.Applications.Update(application);
            await _context.SaveChangesAsync();
        }
    }
}