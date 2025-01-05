using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;
using LoanDisbursement.Repositories;

namespace LoanDisbursement.Services
{
    public class DisbursementService:IDisbursementService
    {
        private readonly IDisbursementRepository _repository;
        public DisbursementService(IDisbursementRepository repository)
        {
            _repository = repository;
        }

        public async Task AddDisbursementAsync(DisbursementModel disbursement)
        {
            await _repository.AddAsync(disbursement);
        }

        public async Task DeleteDisbursementAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DisbursementModel>> GetAllDisbursementsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<DisbursementModel> GetDisbursementByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<DisbursementModel>> GetDisbursementsByLoanIdAsync(int loanId)
        {
            return await _repository.GetByLoanIdAsync(loanId); 
        }

        public async Task UpdateDisbursementAsync(DisbursementModel disbursement)
        {
            await _repository.UpdateAsync(disbursement);
        }
    }
}