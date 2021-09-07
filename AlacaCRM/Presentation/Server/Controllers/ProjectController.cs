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
    public class ProjectController : ControllerBase
    {
        IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetviewProjects")]
        public async Task<IActionResult> GetviewProjects()
        {
            var data = await _projectService.GetviewProjects();
            return Ok(data);
        }
        [HttpGet("GetByCustomerIdProject")]
        public async Task<IActionResult> GetByCustomerIdProject(Guid CustomerId)
        {
            var data = await _projectService.GetByCustomerIdProject(CustomerId);
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _projectService.GetById(id));
        }

        [HttpGet("GetByDateTimeBetweenviewProjects")]
        public async Task<IActionResult> GetByDateTimeBetweenviewProjects(DateTime StartDate, DateTime EndDate)
        {
            var data = await _projectService.GetByDateTimeBetweenviewProjects(StartDate, EndDate);
            return Ok(data);
        }

        [HttpGet("GetOrderDescTop10viewProjects")]
        public async Task<IActionResult> GetOrderDescTop10viewProjects()
        {
            var data = await _projectService.GetOrderDescTop10viewProjects();
            return Ok(data);
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Project data)
        {
            return Ok(await _projectService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Project data)
        {
            return Ok(await _projectService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _projectService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
