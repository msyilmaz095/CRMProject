using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Stock data)
        {
            return Ok(await _stockService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Stock data)
        {
            var result = await _stockService.Update(data);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
