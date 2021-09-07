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
    public class ShelfController : ControllerBase
    {
        IShelfService _Shelf;
        public ShelfController(IShelfService Shelf)
        {
            _Shelf = Shelf;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _Shelf.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _Shelf.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Shelf data)
        {
            return Ok(await _Shelf.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Shelf data)
        {
            return Ok(await _Shelf.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _Shelf.GetById(id)).Data;
            if (data != null)
            {
                var result = await _Shelf.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
