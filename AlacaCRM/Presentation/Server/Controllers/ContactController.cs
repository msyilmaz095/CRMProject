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
    public class ContactController : ControllerBase
    {
        IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _contactService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _contactService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Contact data)
        {
            return Ok(await _contactService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Contact data)
        {
            return Ok(await _contactService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _contactService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _contactService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetContactByCustomerIdAll")]
        public async Task<IActionResult> GetContactByCustomerIdAll(Guid id)
        {
            var data = await _contactService.GetContactByCustomerIdAll(id);
            return Ok(data);
        }
    }
}
