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
    public class RayonController : ControllerBase
    {
        IRayonService _rayonService;
        public RayonController(IRayonService rayonService)
        {
            _rayonService = rayonService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _rayonService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _rayonService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Rayon data)
        {
            return Ok(await _rayonService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Rayon data)
        {
            return Ok(await _rayonService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _rayonService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _rayonService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
