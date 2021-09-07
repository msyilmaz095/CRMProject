
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Dto;
using Alaca.Crm.Client.Service.Abstract;

namespace Alaca.Crm.Client.Pages.Users
{
    public class UserRolsBase : ComponentBase
    {
        protected Blazorise.Modal modalRef;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] IUserRoleService _userRoleService { get; set; }
        [Inject] IMenuService _menuService { get; set; }
        public HashSet<Menu> lstMenu;
        public UserRole userRole;
        public UserRole[] lstUserRole;
        protected Menu ActivatedValue { get; set; }
        protected HashSet<Menu> SelectedValues { get; set; }
        public UserRolsBase()
        {
        }
        protected async override Task OnInitializedAsync()
        {
            userRole = new UserRole();
            lstMenu = (await _menuService.GetAll()).Data.Where(p => p.MainMenuId == null).ToHashSet();
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _userRoleService.GetAll();
            lstUserRole = response.Data;
        }

        protected void NewUserRole()
        {
            SelectedValues = new HashSet<Menu> { };
            userRole = new Entities.Concrete.UserRole();
            modalRef.Show();
        }

        protected async Task GetUserRole(Guid id)
        {
            SelectedValues = (await _userRoleService.GetByUserRoleIdMenus(id)).Data;
            userRole = (await _userRoleService.GetById(id)).Data;
            StateHasChanged();
            modalRef.Show();
        }

        protected async Task DeleteUserRole(Guid id)
        {
            var response = await _userRoleService.Delete(id);
            await GetAll();
            await DialogService.ShowDialogAlertSuccess("Kayıt Silme", "Rol Tanımı Silindi!!!");
        }

        protected async Task OnValidSubmit()
        {
            if (userRole.UserRoleId == Guid.Empty)
            {
                var response = await _userRoleService.Insert(userRole, SelectedValues);
                await DialogService.ShowDialogAlertSuccess("Yeni Rol", "Yeni Rol Kaydı Başarılı!!!");
            }
            else
            {
                var response = await _userRoleService.Update(userRole, SelectedValues);
               await DialogService.ShowDialogAlertSuccess("Rol Güncelleme", "Rol Güncelleme Başarılı!!!");
            }
            await GetAll();
            modalRef.Hide();
        }

    }
}
