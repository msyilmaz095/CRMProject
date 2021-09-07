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
    public class LocationTypeController : ControllerBase
    {
        ILocationTypeService _locationTypeService;
        public LocationTypeController(ILocationTypeService locationTypeService)
        {
            _locationTypeService = locationTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _locationTypeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _locationTypeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(LocationType data)
        {
            return Ok(await _locationTypeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(LocationType data)
        {
            return Ok(await _locationTypeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _locationTypeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _locationTypeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
