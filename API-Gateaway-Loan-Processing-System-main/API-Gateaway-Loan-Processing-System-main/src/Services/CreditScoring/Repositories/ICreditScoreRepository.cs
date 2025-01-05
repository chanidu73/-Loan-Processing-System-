using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;

namespace CreditScoring.Repositories
{
    public interface ICreditScoreRepository
    {
    Task<IEnumerable<CreditScoreModel>> GetAllAsync();
    Task<CreditScoreModel> GetByIdAsync(int id);
    Task<CreditScoreModel> GetByCustomerIdAsync(int customerId);
    Task AddAsync(CreditScoreModel creditScore);
    Task UpdateAsync(CreditScoreModel creditScore);
    Task DeleteAsync(int id);
    }
}