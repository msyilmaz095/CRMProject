using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Helpers;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Menus
{
    public partial class Menus
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] IMenuService _menuService { get; set; }
        public HashSet<Menu> lstData;
        public Menu[] MenuList;
        public Menu data = new Menu();
        protected override async Task OnInitializedAsync()
        {
            lstData = new HashSet<Menu>();
            MenuList = new Menu[] { };
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _menuService.GetAll();
            MenuList = response.Data;
            lstData = response.Data.Where(p => p.MainMenuId == null).ToList().ToHashSet();
        }
        public HashSet<Menu> GetData()
        {
            return lstData;
        }

        protected void New(Guid? MainMenuId)
        {
            data = new Menu();
            data.MainMenuId = MainMenuId;
            modalRef.Show();
        }

        protected async Task Get(Guid CompanyId)
        {
            data = (await _menuService.GetById(CompanyId)).Data;
            modalRef.Show();
        }

        protected async Task Delete(Guid id)
        {
            var result = await _menuService.Delete(id); 
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.MenuId == Guid.Empty)
            {
                result = await _menuService.Insert(data);
            }
            else
            {
                result = await _menuService.Update(data);
            }
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
                modalRef.Hide();
                await GetAll();
            }
        }
    }

}
