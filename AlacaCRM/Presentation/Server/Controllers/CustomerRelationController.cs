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
    public class CustomerRelationController : ControllerBase
    {
        ICustomerRelationService _customerRelationService;
        public CustomerRelationController(ICustomerRelationService customerRelationService)
        {
            _customerRelationService = customerRelationService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _customerRelationService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _customerRelationService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(CustomerRelation data)
        {
            return Ok(await _customerRelationService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(CustomerRelation data)
        {
            return Ok(await _customerRelationService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _customerRelationService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _customerRelationService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
