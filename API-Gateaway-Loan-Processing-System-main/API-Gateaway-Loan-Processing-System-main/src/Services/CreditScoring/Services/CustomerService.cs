using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;
using CreditScoring.Repositories;

namespace CreditScoring.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository= repository;
        }

        public async Task AddCustomerAsync(CustomerModel customer)
        {
            await _repository.AddAsync(customer);
            
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerModel>> GetAllCustomersAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CustomerModel> GetCustomerByEmailAsync(string email)
        {
            return await _repository.GetByEmailAsync(email);
        }

        public async Task<CustomerModel> GetCustomerByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateCustomerAsync(CustomerModel customer)
        {
            await _repository.UpdateAsync(customer);
        }
    }
}