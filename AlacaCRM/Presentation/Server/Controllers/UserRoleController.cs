using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
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
    public class UserRoleController : ControllerBase
    {
        IUserRoleService _userRoleService;
        IUserRoleMenuService _userRoleMenuService;
        public UserRoleController(IUserRoleService userRoleService, IUserRoleMenuService userRoleMenuService)
        {
            _userRoleMenuService = userRoleMenuService;
            _userRoleService = userRoleService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _userRoleService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _userRoleService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Data data)
        {
            var resultrole = await _userRoleService.Add(data.userData);
            await _userRoleMenuService.SetUserRoleMenu(data.userData.UserRoleId, data.lstMenu);
            return Ok(resultrole);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Data data)
        {
            var resultrole = await _userRoleService.Update(data.userData);
            await _userRoleMenuService.SetUserRoleMenu(data.userData.UserRoleId, data.lstMenu);
            return Ok(resultrole);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _userRoleService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _userRoleService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetAllUserRoleMenu")]
        public async Task<IActionResult> GetAllUserRoleMenu(Guid UserId)
        {
            var data = await _userRoleMenuService.GetViewUserRoleMenus(UserId);
            return Ok(data);
        }

        [HttpGet("GetByUserRoleIdMenus")]
        public async Task<IActionResult> GetByUserRoleIdMenus(Guid UserRoleId)
        {
            var data = await _userRoleMenuService.GetByUserRoleIdMenus(UserRoleId);
            return Ok(data);
        }
    }

    public class Data
    {
        public UserRole userData { get; set; }
        public HashSet<Menu> lstMenu { get; set; }
    }
}
