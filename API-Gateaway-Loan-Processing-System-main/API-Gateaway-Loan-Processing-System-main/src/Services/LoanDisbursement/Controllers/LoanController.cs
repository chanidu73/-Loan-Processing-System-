using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;
using LoanDisbursement.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoanDisbursement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController:ControllerBase
    {
        private readonly ILoanService _service ;
        public LoanController(ILoanService service)
        {
            _service=service;
        }
        [HttpGet]
        public async Task<IActionResult>GetAllLoans()
        {
            var loans = await _service.GetAllLoansAsync();
            return Ok(loans);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoanById(int id)
        {
            var loan = await _service.GetLoanByIdAsync(id);
            if(loan == null)return NotFound();
            return Ok(loan);
        }

        [HttpGet("customer/{customerId}")]
        public async Task<IActionResult>GetLoanByCustomerId(int id)
        {
            var loan = await _service.GetLoansByCustomerIdAsync(id);
            if(loan ==null)return NotFound();
            return Ok(loan);
        }

        [HttpPost]
        public async Task<IActionResult>CreateLoan(LoanModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.AddLoanAsync(model);
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = _service.GetLoanByIdAsync(id);
            if(loan== null)return NotFound();
            await _service.DeleteLoanAsync(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateLoan(int id , LoanModel model)
        {
            if(id != model.LoanId | !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.UpdateLoanAsync(model);
            return Ok(model);
        }

    }
}