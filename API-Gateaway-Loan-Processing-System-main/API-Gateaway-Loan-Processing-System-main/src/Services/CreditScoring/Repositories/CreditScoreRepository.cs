using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Data;
using CreditScoring.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditScoring.Repositories
{
    public class CreditScoreRepository:ICreditScoreRepository
    {
        private readonly ApplicationDbContext _context;
        public CreditScoreRepository(ApplicationDbContext context)
        {
            _context= context;
        }

        public async Task AddAsync(CreditScoreModel creditScore)
        {
            await _context.CreditScores.AddAsync(creditScore);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int creditScoreId)
        {
            var credit = await _context.CreditScores.FindAsync(creditScoreId);
            if(credit != null)
            {
                _context.CreditScores.Remove(credit);
                await _context.SaveChangesAsync();
            }
        }

  
        public async Task<IEnumerable<CreditScoreModel>> GetAllAsync()
        {
            return await _context.CreditScores.ToListAsync();
        }

        public async Task<CreditScoreModel> GetByCustomerIdAsync(int customerId)
        {
            return await _context.CreditScores.FirstOrDefaultAsync(c=>c.CustomerId==customerId);
        }

        public async Task<CreditScoreModel> GetByIdAsync(int id)
        {
            return await _context.CreditScores.FindAsync(id);
        }

        public async Task UpdateAsync(CreditScoreModel creditScore)
        {
            _context.CreditScores.Update(creditScore);
            await _context.SaveChangesAsync();
        }
    }
}