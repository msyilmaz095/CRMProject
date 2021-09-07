using Alaca.Core.Entities;
using Alaca.Core.Utilities.Result;
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
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        IUserLoginInfoService _userLoginInfoService;
        public UsersController(IUserService userService,IUserLoginInfoService userLoginInfoService)
        {
            _userLoginInfoService = userLoginInfoService;
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var data =await _userService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetAllViewUsers")]
        public async Task<IActionResult> GetAllViewUsers()
        {
            var data = await _userService.GetviewUsers();
            return Ok(data);
        }
        [HttpGet("GetAllUserLoginInfo")]
        public async Task<IActionResult> GetAllUserLoginInfo()
        {
            var data = await _userLoginInfoService.GetAllviewUsrLoginInfo();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public Task<IResultData<User>> GetById(Guid id)
        {
            return _userService.GetById(id);
        }

        [HttpGet("GetByEmployeeId")]
        public Task<IResultData<User>> GetByEmployeeId(Guid EmployeeId)
        {
            return _userService.GetByEmployeeId(EmployeeId);
        }

        [HttpPost("insert")]
        public Task<IResult> Insert(User user)
        {
            return _userService.Add(user);
        }

        [HttpPost("update")]
        public Task<IResult> Update(User user)
        {
            return _userService.Update(user);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _userService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _userService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
