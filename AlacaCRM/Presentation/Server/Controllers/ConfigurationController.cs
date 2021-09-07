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
    public class ConfigurationController : ControllerBase
    {
        IConfigurationService _configurationService;
        public ConfigurationController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _configurationService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _configurationService.GetById(id));
        }

        [HttpGet("GetByIdString")]
        public async Task<IActionResult> GetByIdString(string id)
        {
            return Ok(await _configurationService.GetById2(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Configuration data)
        {
            return Ok(await _configurationService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Configuration data)
        {
            return Ok(await _configurationService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            var data = (await _configurationService.GetById2(id)).Data;
            if (data != null)
            {
                var result =await _configurationService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
