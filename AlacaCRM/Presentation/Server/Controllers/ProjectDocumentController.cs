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
    public class ProjectDocumentController : ControllerBase
    {
        IProjectDocumentService _projectDocumentService;
        public ProjectDocumentController(IProjectDocumentService projectDocumentService)
        {
            _projectDocumentService = projectDocumentService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _projectDocumentService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _projectDocumentService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectDocument data)
        {
            return Ok(await _projectDocumentService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ProjectDocument data)
        {
            return Ok(await _projectDocumentService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _projectDocumentService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _projectDocumentService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
