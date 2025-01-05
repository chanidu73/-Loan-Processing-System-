using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScoring.Models;
using CreditScoring.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreditScoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredictScoreController:ControllerBase
    {
        private readonly ICreditScoreService _service ;
        public CredictScoreController(ICreditScoreService service)
        {
            _service =service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCreditScores()
        {
            var credits = await _service.GetAllCreditScoresAsync();
            return Ok(credits);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetCreditScoreById(int id)
        {
            var credit =await _service.GetCreditScoreByIdAsync(id);
            if(credit ==null)return NotFound();
            return Ok(credit);
        }
        [HttpPost]
        public async Task<IActionResult>AddCreditScore(CreditScoreModel model)
        {
            if(!ModelState.IsValid)return BadRequest();
            await _service.AddCreditScoreAsync(model);
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateCreditScore(int id , CreditScoreModel model)
        {
            if(!ModelState.IsValid | id != model.CredictScoreId)return BadRequest();
            await _service.UpdateCreditScoreAsync(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreditScore(int id )
        {
            var score = await _service.GetCreditScoreByIdAsync(id);
            if(score == null)return BadRequest();
            await _service.DeleteCreditScoreAsync(id);
            return NoContent();
        }
        

    }
}