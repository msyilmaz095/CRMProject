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
    public class StoreController : ControllerBase
    {
        IStoreService _Store;
        public StoreController(IStoreService Store)
        {
            _Store = Store;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _Store.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _Store.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Store data)
        {
            return Ok(await _Store.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Store data)
        {
            return Ok(await _Store.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _Store.GetById(id)).Data;
            if (data != null)
            {
                var result = await _Store.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
