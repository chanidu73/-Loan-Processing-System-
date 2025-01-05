using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Data;
using CreditScoring.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditScoring.Repositories
{
    public class CustomerRepository:ICustomerRepository 
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task AddAsync(CustomerModel customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int  customerId)
        {
            var user= await _context.Customers.FindAsync(customerId);
            if(user != null)
            {
                _context.Customers.Remove(user);
                await _context.SaveChangesAsync();
            } 

        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<CustomerModel> GetByEmailAsync(string email)
        {
            return await _context.Customers.FirstOrDefaultAsync(e=>e.Email==email);

        }

        public async Task<CustomerModel> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }


        public async Task UpdateAsync(CustomerModel customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}