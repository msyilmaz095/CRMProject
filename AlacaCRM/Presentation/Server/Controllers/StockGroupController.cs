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
    public class StockGroupController : ControllerBase
    {
        IStockGroupService _stockGroupService;
        public StockGroupController(IStockGroupService stockGroupService)
        {
            _stockGroupService = stockGroupService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockGroupService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockGroupService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockGroup data)
        {
            return Ok(await _stockGroupService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockGroup data)
        {
            return Ok(await _stockGroupService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockGroupService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockGroupService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
