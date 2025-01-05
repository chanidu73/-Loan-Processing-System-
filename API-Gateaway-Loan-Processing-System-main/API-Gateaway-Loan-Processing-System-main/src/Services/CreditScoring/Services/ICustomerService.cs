using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;

namespace CreditScoring.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerModel>> GetAllCustomersAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int id);
        Task<CustomerModel> GetCustomerByEmailAsync(string email);
        Task AddCustomerAsync(CustomerModel customer);
        Task UpdateCustomerAsync(CustomerModel customer);
        Task DeleteCustomerAsync(int id);
    }
}