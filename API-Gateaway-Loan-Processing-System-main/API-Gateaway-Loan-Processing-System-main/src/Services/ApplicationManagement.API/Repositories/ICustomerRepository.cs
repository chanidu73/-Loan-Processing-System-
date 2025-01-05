using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;

namespace ApplicationManagement.API.Repositories
{
    public interface ICustomerRepository
    {
    Task<IEnumerable<UserModel>> GetAllAsync();
    Task<UserModel?> GetByIdAsync(int id);
    Task<UserModel?> GetByEmailAsync(string email);
    Task AddAsync(UserModel user);
    Task UpdateAsync(UserModel user);
    Task DeleteAsync(int id);
    }
}