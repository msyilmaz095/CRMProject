using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _employeeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _employeeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Employee data)
        {
            return Ok(await _employeeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Employee data)
        {
            return Ok(await _employeeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _employeeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _employeeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
