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
    public class CustomerGroupController : ControllerBase
    {
        ICustomerGroupService _customerGroupService;
        public CustomerGroupController(ICustomerGroupService customerGroupService)
        {
            _customerGroupService = customerGroupService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _customerGroupService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _customerGroupService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(CustomerGroup data)
        {
            return Ok(await _customerGroupService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(CustomerGroup data)
        {
            return Ok(await _customerGroupService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _customerGroupService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _customerGroupService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
