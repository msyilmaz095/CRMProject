using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectMilestoneController : ControllerBase
    {
        IProjectMilestoneService _projectMilestone;
        public ProjectMilestoneController(IProjectMilestoneService projectMilestone)
        {
            _projectMilestone = projectMilestone;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectMilestone.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _projectMilestone.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectMilestone data)
        {
            return Ok(await _projectMilestone.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ProjectMilestone data)
        {
            return Ok(await _projectMilestone.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _projectMilestone.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectMilestone.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetByProjectIdProjectMilestone")]
        public async Task<IActionResult> GetByProjectIdProjectMilestone(Guid ProjectId)
        {
            return Ok(await _projectMilestone.GetByProjectIdProjectMilestone(ProjectId));
        }
    }
}
