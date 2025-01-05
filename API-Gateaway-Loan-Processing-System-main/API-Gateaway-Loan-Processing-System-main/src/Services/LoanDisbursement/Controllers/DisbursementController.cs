using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanDisbursement.Models;
using LoanDisbursement.Repositories;
using LoanDisbursement.Services;
using Microsoft.AspNetCore.Mvc;
namespace LoanDisbursement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisbursementController:ControllerBase
    {
        private readonly IDisbursementService _service;
        public DisbursementController(IDisbursementService service)
        {
            _service= service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDisburse()
        {
            var disburses = await _service.GetAllDisbursementsAsync();
            return Ok(disburses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDisburseById(int id)
        {
            var disburse = await _service.GetDisbursementByIdAsync(id);
            if(disburse ==null)
            {
                return NotFound();
            }
            return Ok(disburse);
        }
        [HttpGet("loan/{loanId}")]
        public async Task<IActionResult> GetDisburseByLoanId( int loanId)
        {
            var disburse= await _service.GetDisbursementsByLoanIdAsync(loanId);
            if(disburse ==null)return NotFound();
            return Ok(disburse);
        }
        [HttpPut("id")]
        public async Task<IActionResult>UpdateDisburse(int id , DisbursementModel model)
        {
            if(model.DisbursementId!=id |!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.UpdateDisbursementAsync(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteDisburse(int id)
        {
            var disburse= await _service.GetDisbursementByIdAsync(id);
            if(disburse==null)return NotFound();
            await _service.DeleteDisbursementAsync(id);
            return NoContent();
        }

    }

}