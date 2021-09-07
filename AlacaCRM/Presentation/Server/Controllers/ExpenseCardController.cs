using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseCardController : ControllerBase
    {
        IExpenseCardService _ExpenseCard;
        public ExpenseCardController(IExpenseCardService ExpenseCard)
        {
            _ExpenseCard = ExpenseCard;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _ExpenseCard.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _ExpenseCard.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ExpenseCard data)
        {
            return Ok(await _ExpenseCard.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ExpenseCard data)
        {
            return Ok(await _ExpenseCard.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _ExpenseCard.GetById(id)).Data;
            if (data != null)
            {
                var result = await _ExpenseCard.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
