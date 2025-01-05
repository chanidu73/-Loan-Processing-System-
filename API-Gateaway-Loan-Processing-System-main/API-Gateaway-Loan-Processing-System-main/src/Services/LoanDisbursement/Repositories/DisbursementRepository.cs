using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Data;
using LoanDisbursement.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanDisbursement.Repositories
{
    public class DisbursementRepository:IDisbursementRepository
    {
        private readonly ApplicationDbContext _context;
        public DisbursementRepository(ApplicationDbContext context)
        {
            _context =context;
        }

        public async Task AddAsync(DisbursementModel disbursement)
        {
            await _context.Disbursements.AddAsync(disbursement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var disbursement = await _context.Disbursements.FindAsync(id);
            if(disbursement != null)
            {
                _context.Disbursements.Remove(disbursement);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DisbursementModel>> GetAllAsync()
        {
            return await _context.Disbursements.ToListAsync();
        }

        public async Task<DisbursementModel> GetByIdAsync(int id)
        {
            return await _context.Disbursements.FindAsync(id);
            
        }

        public async Task<IEnumerable<DisbursementModel>> GetByLoanIdAsync(int loanId)
        {
            return await _context.Disbursements.Where(c=>c.LoanId ==loanId).ToListAsync();
        }

        public async Task UpdateAsync(DisbursementModel disbursement)
        {
            _context.Disbursements.Update(disbursement);
            await _context.SaveChangesAsync();
        }
    }
}