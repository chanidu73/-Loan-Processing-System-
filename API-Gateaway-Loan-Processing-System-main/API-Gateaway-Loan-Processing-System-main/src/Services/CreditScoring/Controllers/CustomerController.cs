using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;
using CreditScoring.Repositories;
using CreditScoring.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreditScoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service ;
        }

        [HttpGet]
        public async Task<IActionResult>GetAllCustomers()
        {
            var customers = await _service.GetAllCustomersAsync();
            return Ok(customers);
        }
        [HttpGet("id")]
        public async Task<IActionResult>GetCustomerById(int id)
        {
            var customer = await _service.GetCustomerByIdAsync(id);
            if(customer == null)return NotFound();

            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult>AddCustomer(CustomerModel model)
        {
            if(!ModelState.IsValid)return BadRequest();
            await _service.AddCustomerAsync(model);
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id ,  CustomerModel model)
        {
            if(!ModelState.IsValid | id != model.CustomerId) return BadRequest();
            await _service.UpdateCustomerAsync(model);
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id )
        {
            var customer = await _service.GetCustomerByIdAsync(id); 
            if(customer == null) return BadRequest();
            await _service.DeleteCustomerAsync(id);
            return NoContent(); 
        }
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetCustomerByEmail(string email)
        {
            var customer = await _service.GetCustomerByEmailAsync(email);
            if(customer == null)return BadRequest();
            return Ok(customer);
        }
    }
}