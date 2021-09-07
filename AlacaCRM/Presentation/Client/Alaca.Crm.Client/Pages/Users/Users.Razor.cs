using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using MudBlazor;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Entities;
using Alaca.Entities.Dto;
using System;

namespace Alaca.Crm.Client.Pages.Users
{
    public class UsersBase : ComponentBase
    {
        [Inject] NavigationManager _navigationManager { get; set; }
        [Inject] IUserService _userService { get; set; }
        public viewUser[] users;
        public UsersBase()
        {

        }

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _userService.GetAllviewUser();
            users = response.Data;
        }

        protected void NewUser()
        {
            _navigationManager.NavigateTo("/User/"+Guid.Empty);
        }

        protected void EditUser(Guid UserId)
        {
            _navigationManager.NavigateTo("/User/" + UserId);
        }

    }
}
