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
    public class ActivityTypeController : ControllerBase
    {
        IActivityTypeService _ActivityTypeService;
        public ActivityTypeController(IActivityTypeService ActivityTypeService)
        {
            _ActivityTypeService = ActivityTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _ActivityTypeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _ActivityTypeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ActivityType data)
        {
            return Ok(await _ActivityTypeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ActivityType data)
        {
            return Ok(await _ActivityTypeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _ActivityTypeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _ActivityTypeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
