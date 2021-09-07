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
    public class DistrictController : ControllerBase
    {
        IDistrictService _districtService;
        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _districtService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _districtService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(District data)
        {
            return Ok(await _districtService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(District data)
        {
            return Ok(await _districtService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _districtService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _districtService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
