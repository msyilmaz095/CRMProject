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
    public class WorkTaskController : ControllerBase
    {
        IWorkTaskService _WorkTask;
        public WorkTaskController(IWorkTaskService WorkTask)
        {
            _WorkTask = WorkTask;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _WorkTask.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _WorkTask.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(WorkTask data)
        {
            return Ok(await _WorkTask.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(WorkTask data)
        {
            return Ok(await _WorkTask.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _WorkTask.GetById(id)).Data;
            if (data != null)
            {
                var result = await _WorkTask.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
