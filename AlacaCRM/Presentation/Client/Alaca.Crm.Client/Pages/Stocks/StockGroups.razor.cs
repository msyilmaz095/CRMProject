using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Stocks
{
    public partial class StockGroups
    {
        protected FluentValidationValidator _fluentValidationValidator;
        Blazorise.Modal modalRef;
        [Inject] public IStockGroupService _stockGroupService { get; set; }
        StockGroup stockGroup = new StockGroup();
        StockGroup[] stockGroups;
        protected override async Task OnInitializedAsync()
        {
            stockGroups = (await _stockGroupService.GetAll()).Data;
        }

        protected void NewStockGroup()
        {
            stockGroup = new StockGroup();
            modalRef.Show();
        }

        protected async void EditStockGroup(Guid Id)
        {
            stockGroup = (await _stockGroupService.GetById(Id)).Data;
        }

        protected void RowClick(StockGroup row)
        {
            stockGroup = row;
            ShowModel();
        }

        protected void ShowModel()
        {
            modalRef.Show();
        }
        protected void CloseModel()
        {
            modalRef.Hide();
        }
        protected async void Save()
        {
            IResult result = null;
            if (stockGroup.StockGroupId == Guid.Empty)
            {
                result = await _stockGroupService.Insert(stockGroup);
            }
            else
            {
                result = await _stockGroupService.Update(stockGroup);
            }
            await Result(result);
        }

        protected async void Delete()
        {
            var result = await _stockGroupService.Delete(stockGroup.StockGroupId);
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
                await Refresh();
            }
        }

        private async Task Refresh()
        {
            CloseModel();
            stockGroups = (await _stockGroupService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
