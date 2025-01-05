using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;

namespace LoanDisbursement.Services
{
    public interface IDisbursementService
    {
    Task<IEnumerable<DisbursementModel>> GetAllDisbursementsAsync();
    Task<DisbursementModel> GetDisbursementByIdAsync(int id);
    Task<IEnumerable<DisbursementModel>> GetDisbursementsByLoanIdAsync(int loanId);
    Task AddDisbursementAsync(DisbursementModel disbursement);
    Task UpdateDisbursementAsync(DisbursementModel disbursement);
    Task DeleteDisbursementAsync(int id);
    
    }
}