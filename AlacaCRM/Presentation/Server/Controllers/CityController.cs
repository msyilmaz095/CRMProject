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
    public class CityController : ControllerBase
    {
        ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _cityService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _cityService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(City data)
        {
            return Ok(await _cityService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(City data)
        {
            return Ok(await _cityService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _cityService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _cityService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
