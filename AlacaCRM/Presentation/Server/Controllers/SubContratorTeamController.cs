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
    public class SubContratorTeamController : ControllerBase
    {
        ISubContratorTeamService _subContratorTeamService;
        public SubContratorTeamController(ISubContratorTeamService subContratorTeamService)
        {
            _subContratorTeamService = subContratorTeamService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _subContratorTeamService.GetAllList();
            return Ok(data);
        }
        [HttpGet("GetByCustomerIdSubContratorTeam")]
        public async Task<IActionResult> GetByCustomerIdSubContratorTeam(Guid CustomerId)
        {
            var data = await _subContratorTeamService.GetByCustomerIdSubContratorTeam(CustomerId);
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _subContratorTeamService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(SubContratorTeam data)
        {
            return Ok(await _subContratorTeamService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SubContratorTeam data)
        {
            return Ok(await _subContratorTeamService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _subContratorTeamService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _subContratorTeamService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
