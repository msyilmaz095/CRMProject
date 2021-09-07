using Alaca.Core.Utilities.Extension;
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
    [Authorize()]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _customerService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _customerService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Customer data)
        {
            return Ok(await _customerService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Customer data)
        {
            return Ok(await _customerService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _customerService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _customerService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
