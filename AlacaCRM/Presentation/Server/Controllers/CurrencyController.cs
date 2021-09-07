using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        ICurrencyService _currencyService;
        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _currencyService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _currencyService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Currency data)
        {
            return Ok(await _currencyService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Currency data)
        {
            return Ok(await _currencyService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _currencyService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _currencyService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
