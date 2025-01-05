using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;

namespace ApplicationManagement.API.Repositories
{
    public interface ILoanApplicationRepository
    {
    Task<IEnumerable<ApplicationModel>> GetAllAsync();
    Task<ApplicationModel?> GetByIdAsync(int id);
    Task<IEnumerable<ApplicationModel>> GetPendingApplicationsAsync();
    Task AddAsync(ApplicationModel application);
    Task UpdateAsync(ApplicationModel application);
    Task DeleteAsync(int id); 
    }
}