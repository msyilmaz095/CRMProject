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
    public class CurrencyValueController : ControllerBase
    {
        ICurrencyValueService _currencyValueService;
        public CurrencyValueController(ICurrencyValueService currencyValueService)
        {
            _currencyValueService = currencyValueService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _currencyValueService.GetAllList();
            return Ok(data);
        }


        [HttpGet("GetAllviewCurrencyValue")]
        public async Task<IActionResult> GetAllviewCurrencyValue()
        {
            var data = await _currencyValueService.GetviewCurrencyValue();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _currencyValueService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(CurrencyValue data)
        {
            return Ok(await _currencyValueService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(CurrencyValue data)
        {
            return Ok(await _currencyValueService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _currencyValueService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _currencyValueService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
