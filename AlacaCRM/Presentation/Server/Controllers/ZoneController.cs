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
    public class ZoneController : ControllerBase
    {
        IZoneService _zoneService;
        public ZoneController(IZoneService zoneService)
        {
            _zoneService = zoneService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _zoneService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _zoneService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Zone data)
        {
            return Ok(await _zoneService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Zone data)
        {
            return Ok(await _zoneService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _zoneService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _zoneService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
