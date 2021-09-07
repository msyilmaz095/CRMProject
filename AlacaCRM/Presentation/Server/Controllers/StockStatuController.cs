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
    public class StockStatuController : ControllerBase
    {
        IStockStatuService _stockStatuService;
        public StockStatuController(IStockStatuService stockStatuService)
        {
            _stockStatuService = stockStatuService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockStatuService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockStatuService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockStatu data)
        {
            return Ok(await _stockStatuService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockStatu data)
        {
            return Ok(await _stockStatuService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockStatuService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockStatuService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
