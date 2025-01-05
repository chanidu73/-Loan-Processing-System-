using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;

namespace LoanDisbursement.Repositories
{
    public interface IDisbursementRepository
    {
    Task<IEnumerable<DisbursementModel>> GetAllAsync();
    Task<DisbursementModel> GetByIdAsync(int id);
    Task<IEnumerable<DisbursementModel>> GetByLoanIdAsync(int loanId);
    Task AddAsync(DisbursementModel disbursement);
    Task UpdateAsync(DisbursementModel disbursement);
    Task DeleteAsync(int id);
    }
}