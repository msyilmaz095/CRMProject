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
    public class DepartmentController : ControllerBase
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _departmentService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _departmentService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Department data)
        {
            return Ok(await _departmentService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Department data)
        {
            return Ok(await _departmentService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _departmentService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _departmentService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
