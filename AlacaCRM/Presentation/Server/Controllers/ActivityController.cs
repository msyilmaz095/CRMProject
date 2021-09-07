using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        IActivityService _ActivityService;
        public ActivityController(IActivityService ActivityService)
        {
            _ActivityService = ActivityService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _ActivityService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetviewActivities")]
        public async Task<IActionResult> GetviewActivities()
        {
            var data = await _ActivityService.GetviewActivities();
            return Ok(data);
        }

        [HttpGet("GetByCustomerIdviewActivities")]
        public async Task<IActionResult> GetByCustomerIdviewActivities(Guid id)
        {
            var data = await _ActivityService.GetByCustomerIdviewActivities(id);
            return Ok(data);
        }

        [HttpGet("GetByProjectIdviewActivities")]
        public async Task<IActionResult> GetByProjectIdviewActivities(Guid ProjectId)
        {
            var data = await _ActivityService.GetByProjectIdviewActivities(ProjectId);
            return Ok(data);
        }

        [HttpGet("GetByDateBetweenviewActivities")]
        public async Task<IActionResult> GetByDateBetweenviewActivities(DateTime StartDate, DateTime FinishDate, Guid AssignedToEmployee)
        {
            var data = await _ActivityService.GetByDateBetweenviewActivities(StartDate, FinishDate, AssignedToEmployee);
            return Ok(data); 
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _ActivityService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Activity data)
        {
            return Ok(await _ActivityService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Activity data)
        {
            return Ok(await _ActivityService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _ActivityService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _ActivityService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
