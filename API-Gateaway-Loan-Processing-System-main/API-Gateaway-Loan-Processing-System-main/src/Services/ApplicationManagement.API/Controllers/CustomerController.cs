using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationManagement.API.Models;
using ApplicationManagement.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult>GetAllCustomers()
        {
            var customers = await _service.GetAllAsync();
            return Ok(customers);
        }
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetCustomerById(int id )
        {
            var user = await _service.GetByIdAsync(id);
            if(user ==null)return NotFound();
            return Ok(user);
        }

        [HttpGet("email/{email}")] 
        public async Task<IActionResult> GetCustomerById(string email )
        {
            var user = await _service.GetByEmailAsync(email);
            if(user ==null)return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult>AddCustomer(UserModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.AddAsync(model);
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id , UserModel model)
        {
            if(id != model.UserId)return BadRequest();
            if(!ModelState.IsValid) return BadRequest();
            await _service.UpdateAsync(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var user = await _service.GetByIdAsync(id);
            if(user==null)return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}