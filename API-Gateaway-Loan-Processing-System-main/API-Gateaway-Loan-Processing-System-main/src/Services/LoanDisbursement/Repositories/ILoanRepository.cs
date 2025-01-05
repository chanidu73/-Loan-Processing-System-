using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;

namespace LoanDisbursement.Repositories
{
    public interface ILoanRepository
    {
    Task<IEnumerable<LoanModel>> GetAllAsync();
    Task<LoanModel> GetByIdAsync(int id);
    Task<IEnumerable<LoanModel>> GetByCustomerIdAsync(int customerId);
    Task AddAsync(LoanModel loan);
    Task UpdateAsync(LoanModel loan);
    Task DeleteAsync(int id);
    }
}