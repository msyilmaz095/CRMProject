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
    public class CompanyController : ControllerBase
    {
        ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _companyService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _companyService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Company data)
        {
            return Ok(await _companyService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Company data)
        {
            return Ok(await _companyService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _companyService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _companyService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
