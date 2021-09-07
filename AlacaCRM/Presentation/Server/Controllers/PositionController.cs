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
    public class PositionController : ControllerBase
    {
        IPositionService _positionService;
        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _positionService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _positionService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Position data)
        {
            return Ok(await _positionService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Position data)
        {
            return Ok(await _positionService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _positionService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _positionService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
