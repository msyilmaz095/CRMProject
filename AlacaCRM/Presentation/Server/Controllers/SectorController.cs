using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        IStockService _stockService;
        public SectorController(IStockService stockService)
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
            return Ok(await _stockService.Update(data));
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
