using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;
using ApplicationManagement.API.Repositories;

namespace ApplicationManagement.API.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(UserModel user)
        {
            await _repository.AddAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<UserModel?> GetByEmailAsync(string email)
        {
            return await _repository.GetByEmailAsync(email);
        }

        public async Task<UserModel?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(UserModel user)
        {
            await _repository.UpdateAsync(user);   
        }
    }
}