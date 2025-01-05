using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;
using ApplicationManagement.API.Repositories;

namespace ApplicationManagement.API.Services
{
    public class LoanApplicationService:ILoanApplicationService
    {
        private readonly ILoanApplicationRepository _repository;
        public  LoanApplicationService(ILoanApplicationRepository repository)
        {
            _repository= repository;
        }

        public async Task AddAsync(ApplicationModel application)
        {
            await _repository.AddAsync(application);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ApplicationModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ApplicationModel?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id); 
        }

        public async Task<IEnumerable<ApplicationModel>> GetPendingApplicationsAsync()
        {
            return await _repository.GetPendingApplicationsAsync();
        }

        public async Task UpdateAsync(ApplicationModel application)
        {
            await _repository.UpdateAsync(application);
        }
    }
}