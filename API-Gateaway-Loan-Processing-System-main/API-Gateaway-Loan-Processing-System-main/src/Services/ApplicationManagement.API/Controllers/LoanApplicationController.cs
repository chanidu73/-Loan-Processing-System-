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
    public class LoanApplicationController:ControllerBase
    {
        private readonly ILoanApplicationService _service ;
        public LoanApplicationController(ILoanApplicationService service)
        {
            _service =service;
        }

        [HttpGet]
        public async Task<IActionResult>GetAllLoans()
        {
            var loans = await _service.GetAllAsync();
            return Ok(loans);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoanById(int id)
        {
            var loan = await _service.GetByIdAsync(id);
            if(loan== null)return NotFound();
            return Ok(loan);
        }
        [HttpPost]
        public async Task<IActionResult> AddLoan(ApplicationModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.AddAsync(model);
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLoan(int id , ApplicationModel model)
        {
            if(id != model.ApplicationId)
            {
                return BadRequest();
            }
            if(!ModelState.IsValid)return BadRequest();
            await _service.UpdateAsync(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id )
        {
            var loan = await _service.GetByIdAsync(id);
            if(loan == null)return BadRequest();
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}