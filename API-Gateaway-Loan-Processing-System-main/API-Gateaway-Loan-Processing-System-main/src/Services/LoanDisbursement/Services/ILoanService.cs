using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;

namespace LoanDisbursement.Services
{
    public interface ILoanService
    {
    Task<IEnumerable<LoanModel>> GetAllLoansAsync();
    Task<LoanModel> GetLoanByIdAsync(int id);
    Task<IEnumerable<LoanModel>> GetLoansByCustomerIdAsync(int customerId);
    Task AddLoanAsync(LoanModel loan);
    Task UpdateLoanAsync(LoanModel loan);
    Task DeleteLoanAsync(int id); 
    }
}