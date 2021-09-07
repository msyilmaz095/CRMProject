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
    public class MenuController : ControllerBase
    {
        IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _menuService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _menuService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Menu data)
        {
            return Ok(await _menuService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Menu data)
        {
            return Ok(await _menuService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _menuService.GetById(id)).Data;
            if (data != null)
            {
                var result =await _menuService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
