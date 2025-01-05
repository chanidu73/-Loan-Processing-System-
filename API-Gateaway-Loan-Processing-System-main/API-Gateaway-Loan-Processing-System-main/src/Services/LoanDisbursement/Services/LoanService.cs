using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;
using LoanDisbursement.Repositories;

namespace LoanDisbursement.Services
{
    public class LoanService:ILoanService
    {
        private readonly ILoanRepository _repository;
        public LoanService(ILoanRepository loanRepository)
        {
            _repository = loanRepository;
        }

        public async Task AddLoanAsync(LoanModel loan)
        {
            await _repository.AddAsync(loan);
        }

        public async Task DeleteLoanAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<LoanModel>> GetAllLoansAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<LoanModel> GetLoanByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<LoanModel>> GetLoansByCustomerIdAsync(int customerId)
        {
            return await _repository.GetByCustomerIdAsync(customerId);
        }

        public async Task UpdateLoanAsync(LoanModel loan)
        {
            await _repository.UpdateAsync(loan);
        }
    }
}