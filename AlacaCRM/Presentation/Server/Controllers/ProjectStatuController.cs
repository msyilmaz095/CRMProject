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
    public class ProjectStatuController : ControllerBase
    {
        IProjectStatuService _projectStatu;
        public ProjectStatuController(IProjectStatuService projectStatu)
        {
            _projectStatu = projectStatu;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectStatu.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(byte id)
        {
            return Ok(await _projectStatu.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectStatu data)
        {
            return Ok(await _projectStatu.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ProjectStatu data)
        {
            return Ok(await _projectStatu.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(byte id)
        {
            var data = (await _projectStatu.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectStatu.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
