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
    public class ContactTypeController : ControllerBase
    {
        IContactTypeService _contactTypeService;
        public ContactTypeController(IContactTypeService contactTypeService)
        {
            _contactTypeService = contactTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _contactTypeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _contactTypeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ContactType data)
        {
            return Ok(await _contactTypeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ContactType data)
        {
            return Ok(await _contactTypeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _contactTypeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _contactTypeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
