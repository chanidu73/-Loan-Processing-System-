using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;

namespace CreditScoring.Repositories
{
    public interface ICustomerRepository
    {
    Task<IEnumerable<CustomerModel>> GetAllAsync();
    Task<CustomerModel> GetByIdAsync(int id);
    Task<CustomerModel> GetByEmailAsync(string email);
    Task AddAsync(CustomerModel customer);
    Task UpdateAsync(CustomerModel customer);
    Task DeleteAsync(int customerId);
   
    }
}