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
    public class UnitController : ControllerBase
    {
        IUnitService _Unit;
        public UnitController(IUnitService Unit)
        {
            _Unit = Unit;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _Unit.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _Unit.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Unit data)
        {
            return Ok(await _Unit.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Unit data)
        {
            return Ok(await _Unit.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _Unit.GetById(id)).Data;
            if (data != null)
            {
                var result = await _Unit.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
