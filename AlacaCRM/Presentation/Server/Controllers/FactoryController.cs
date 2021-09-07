using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        IFactoryService _Factory;
        public FactoryController(IFactoryService Factory)
        {
            _Factory = Factory;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _Factory.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _Factory.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Factory data)
        {
            return Ok(await _Factory.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Factory data)
        {
            return Ok(await _Factory.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _Factory.GetById(id)).Data;
            if (data != null)
            {
                var result = await _Factory.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
