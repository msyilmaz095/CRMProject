using Alaca.Core.Entities;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;
using Alaca.Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IUserService _userService;
        IMenuService _menuService;
        IUserRoleMenuService _userRoleMenuService;
        IUserLoginInfoService _userLoginInfoService;
        public AccountController(IUserService userService,
            IMenuService menuService,
            IUserLoginInfoService userLoginInfoService,
            IUserRoleMenuService userRoleMenuService)
        {
            _userRoleMenuService = userRoleMenuService;
            _userLoginInfoService = userLoginInfoService;
            _menuService = menuService;
            _userService = userService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(Core.Utilities.Authentication.Login login)
        {
            var response = await _userService.Login(login);
            if (response.Success)
            {
                var tokenresult = await _userService.CreateAccessToken(response.Data);
                tokenresult.Data.UserId = response.Data.UserId;
                tokenresult.Data.UserRoleId = response.Data.UserRoleId;
                tokenresult.Data.UserName = response.Data.UserName;
                tokenresult.Data.Email = response.Data.Email;
                /*string RemoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                await _userLoginInfoService.Add(new UserLoginInfo()
                {
                    Createdate = DateTime.Now,
                    UserId = response.Data.UserId,
                    Languages = "",
                    Ipaddress = RemoteIpAddress
                });*/
                return Ok(tokenresult);
            }
            return Unauthorized();
        }

        [HttpGet("GetAllMenu")]
        public async Task<IResultData<List<Menu>>> GetAllUserMenu()
        {
            return await _menuService.GetAllList();
        }
    }
}
