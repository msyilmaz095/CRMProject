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
    public class StockUnitDefinitionController : ControllerBase
    {
        IStockUnitDefinitionService _stockUnitDefinitionService;
        public StockUnitDefinitionController(IStockUnitDefinitionService stockUnitDefinitionService)
        {
            _stockUnitDefinitionService = stockUnitDefinitionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockUnitDefinitionService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockUnitDefinitionService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockUnitDefinition data)
        {
            return Ok(await _stockUnitDefinitionService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockUnitDefinition data)
        {
            return Ok(await _stockUnitDefinitionService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockUnitDefinitionService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockUnitDefinitionService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
