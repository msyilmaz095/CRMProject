using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectMilestoneStatuController : ControllerBase
    {
        IProjectMilestoneStatuService _projectMilestoneStatu;
        public ProjectMilestoneStatuController(IProjectMilestoneStatuService projectMilestoneStatu)
        {
            _projectMilestoneStatu = projectMilestoneStatu;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectMilestoneStatu.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(byte id)
        {
            return Ok(await _projectMilestoneStatu.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectMilestoneStatu data)
        {
            return Ok(await _projectMilestoneStatu.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ProjectMilestoneStatu data)
        {
            return Ok(await _projectMilestoneStatu.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(byte id)
        {
            var data = (await _projectMilestoneStatu.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectMilestoneStatu.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
