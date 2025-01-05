using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Data;
using ApplicationManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManagement.API.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(UserModel user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserModel> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u=>u.Email == email);
        }

        public async Task<UserModel?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateAsync(UserModel user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}