using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;

namespace CreditScoring.Services
{
    public interface ICreditScoreService
    {
    Task<IEnumerable<CreditScoreModel>> GetAllCreditScoresAsync();
    Task<CreditScoreModel> GetCreditScoreByIdAsync(int id);
    Task<CreditScoreModel> GetCreditScoreByCustomerIdAsync(int customerId);
    Task AddCreditScoreAsync(CreditScoreModel creditScore);
    Task UpdateCreditScoreAsync(CreditScoreModel creditScore);
    Task DeleteCreditScoreAsync(int id);
    
    }
}