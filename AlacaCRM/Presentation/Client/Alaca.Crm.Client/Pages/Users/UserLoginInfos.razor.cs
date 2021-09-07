using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Entities;
using Alaca.Entities.Dto;

namespace Alaca.Crm.Client.Pages.Users
{
    public class UserLoginInfosBase : ComponentBase
    {
        [Inject] IUserService _userService { get; set; }
        public viewUserLoginInfo[] lstloginInfo;
        public UserLoginInfosBase()
        {

        }

        protected override async Task OnInitializedAsync()
        {
            lstloginInfo = (await _userService.GetAllUserLoginInfo()).Data;
        }
    }
}
