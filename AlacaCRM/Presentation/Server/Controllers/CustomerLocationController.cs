
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
    public class CustomerLocationController : ControllerBase
    {
        ICustomerLocationService _customerLocationService;
        public CustomerLocationController(ICustomerLocationService customerLocationService)
        {
            _customerLocationService = customerLocationService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _customerLocationService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _customerLocationService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(CustomerLocation data)
        {
            return Ok(await _customerLocationService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(CustomerLocation data)
        {
            return Ok(await _customerLocationService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _customerLocationService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _customerLocationService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetLocationByCustomerIdAll")]
        public async Task<IActionResult> GetLocationByCustomerIdAll(Guid id)
        {
            var data = await _customerLocationService.GetLocationByCustomerIdAll(id);
            return Ok(data);
        }
    }
}
