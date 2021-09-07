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
    public class ServiceCardController : ControllerBase
    {
        IServiceCardService _ServiceCard;
        public ServiceCardController(IServiceCardService ServiceCard)
        {
            _ServiceCard = ServiceCard;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _ServiceCard.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _ServiceCard.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ServiceCard data)
        {
            return Ok(await _ServiceCard.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(ServiceCard data)
        {
            return Ok(await _ServiceCard.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _ServiceCard.GetById(id)).Data;
            if (data != null)
            {
                var result = await _ServiceCard.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
