using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;
using CreditScoring.Repositories;

namespace CreditScoring.Services
{
    public class CreditScoreService:ICreditScoreService 
    {
        private readonly ICreditScoreRepository _repository;
        public CreditScoreService(ICreditScoreRepository repository)
        {
            _repository =repository;
        }

        public async Task AddCreditScoreAsync(CreditScoreModel creditScore)
        {
            await _repository.AddAsync(creditScore);
        }

        public async Task DeleteCreditScoreAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CreditScoreModel>> GetAllCreditScoresAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CreditScoreModel> GetCreditScoreByCustomerIdAsync(int customerId)
        {
            return await _repository.GetByCustomerIdAsync(customerId);
        }

        public async Task<CreditScoreModel> GetCreditScoreByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateCreditScoreAsync(CreditScoreModel creditScore)
        {
            await _repository.UpdateAsync(creditScore);
        }
    }
}