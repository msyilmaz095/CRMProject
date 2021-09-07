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
    public class StockUnitController : ControllerBase
    {
        IStockUnitService _stockUnitService;
        public StockUnitController(IStockUnitService stockUnitService)
        {
            _stockUnitService = stockUnitService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockUnitService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetByStockIdStockUnit")]
        public async Task<IActionResult> GetByStockIdStockUnit(Guid? StockId)
        {
            var data = await _stockUnitService.GetByStockIdStockUnit(StockId);
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockUnitService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockUnit data)
        {
            return Ok(await _stockUnitService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockUnit data)
        {
            return Ok(await _stockUnitService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockUnitService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockUnitService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
