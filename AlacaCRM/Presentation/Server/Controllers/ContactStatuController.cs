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
    public class ContactStatuController : ControllerBase
    {
        IContactStatuService _contactStatuService;
        public ContactStatuController(IContactStatuService contactStatuService)
        {
            _contactStatuService = contactStatuService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _contactStatuService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _contactStatuService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ContactStatu data)
        {
            return Ok(await _contactStatuService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ContactStatu data)
        {
            return Ok(await _contactStatuService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _contactStatuService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _contactStatuService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
