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
    public class WorkTaskTypeController : ControllerBase
    {
        IWorkTaskTypeService _WorkTaskType;
        public WorkTaskTypeController(IWorkTaskTypeService WorkTaskType)
        {
            _WorkTaskType = WorkTaskType;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _WorkTaskType.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _WorkTaskType.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(WorkTaskType data)
        {
            return Ok(await _WorkTaskType.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(WorkTaskType data)
        {
            return Ok(await _WorkTaskType.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _WorkTaskType.GetById(id)).Data;
            if (data != null)
            {
                var result = await _WorkTaskType.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
