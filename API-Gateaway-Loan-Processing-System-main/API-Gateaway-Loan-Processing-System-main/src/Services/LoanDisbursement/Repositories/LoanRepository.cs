using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Data;
using LoanDisbursement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanDisbursement.Repositories
{
    public class LoanRepository:ILoanRepository
    {
        private readonly ApplicationDbContext _context;
        public LoanRepository(ApplicationDbContext context)
        {
            _context= context;
        }

        public async Task AddAsync(LoanModel loan)
        {
            await _context.Loans.AddAsync(loan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if(loan !=null)
            {
                _context.Loans.Remove(loan);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<LoanModel>> GetAllAsync()
        {
            return await _context.Loans.ToListAsync();
        }

        public async Task<IEnumerable<LoanModel>> GetByCustomerIdAsync(int customerId)
        {
            var c = await _context.Loans.Where(c=>c.CustomerId == customerId).ToListAsync();

            return c;
        }

        public async Task<LoanModel> GetByIdAsync(int id)
        {
            return await _context.Loans.FindAsync(id);
        }

        public async Task UpdateAsync(LoanModel loan)
        {
            _context.Loans.Update(loan);
            await _context.SaveChangesAsync();
        }
    }
}