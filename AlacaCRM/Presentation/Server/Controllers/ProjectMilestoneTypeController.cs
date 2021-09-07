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
    public class ProjectMilestoneTypeController : ControllerBase
    {
        IProjectMilestoneTypeService _projectMilestoneType;
        public ProjectMilestoneTypeController(IProjectMilestoneTypeService projectMilestoneType)
        {
            _projectMilestoneType = projectMilestoneType;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectMilestoneType.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(byte id)
        {
            return Ok(await _projectMilestoneType.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectMilestoneType data)
        {
            return Ok(await _projectMilestoneType.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ProjectMilestoneType data)
        {
            return Ok(await _projectMilestoneType.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(byte id)
        {
            var data = (await _projectMilestoneType.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectMilestoneType.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
