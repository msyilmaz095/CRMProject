using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;

namespace Alaca.Crm.Client.Pages.Users
{
    public partial class UserPage
    {
        protected User user = new User();
        protected UserRole[] userRoles;
        protected Department[] departments;
        [Parameter] public Guid UserId { get; set; }
        [Inject] IDepartmentService _departmentService { get; set; }
        [Inject] ICompanyService _companyService { get; set; }
        [Inject] IUserRoleService _userRoleService { get; set; }
        [Inject] IUserService _userService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            departments = (await _departmentService.GetAll()).Data;
            userRoles = (await _userRoleService.GetAll()).Data;
            if (UserId == Guid.Empty)
            {
                user = new User();
            }
            else
            {
                user = (await _userService.GetById(UserId)).Data;
                options = user.UserDepartmentPermissions.Select(col => col.DepartmentId).ToHashSet();
            }
        }

        protected async Task DeleteUser()
        {
            var result = await _userService.Delete(user.UserId);
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (!result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                _navigationManager.NavigateTo("/users");
            }
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (user.UserDepartmentPermissions != null)
                user.UserDepartmentPermissions.Clear();
            foreach (var item in options)
            {
                user.UserDepartmentPermissions.Add(new UserDepartmentPermission()
                {
                    DepartmentId = item.Value
                });
            }
            if (user.UserId == Guid.Empty)
            {
                result = await _userService.Insert(user);
            }
            else
            {
                result = await _userService.Update(user);
            }
            await Result(result);
        }

        protected void Close()
        {
            _navigationManager.NavigateTo("/users");
        }

        protected Guid? value { get; set; }

        protected HashSet<Guid?> options { get; set; } = new HashSet<Guid?>() { };

        protected string GetMultiSelectionText(List<string> selectedValues)
        {
            return $"{selectedValues.Count} adet departman seçildi.";
        }
    }
}
