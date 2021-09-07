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
    public class MilestoneStatuController : ControllerBase
    {
        IMilestoneStatuService _milestoneStatuService;
        public MilestoneStatuController(IMilestoneStatuService milestoneStatuService)
        {
            _milestoneStatuService = milestoneStatuService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _milestoneStatuService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _milestoneStatuService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(MilestoneStatu data)
        {
            return Ok(await _milestoneStatuService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(MilestoneStatu data)
        {
            return Ok(await _milestoneStatuService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _milestoneStatuService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _milestoneStatuService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
