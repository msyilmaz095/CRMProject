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
    public partial class StockUnitDefinitions
    {
        protected FluentValidationValidator _fluentValidationValidator;
        Blazorise.Modal modalRef;
        [Inject] public IStockUnitDefinitionService _stockUnitDefinitionService { get; set; }
        StockUnitDefinition stockUnitDefinition = new StockUnitDefinition();
        StockUnitDefinition[] stockUnitDefinitions;
        protected override async Task OnInitializedAsync()
        {
            stockUnitDefinitions = (await _stockUnitDefinitionService.GetAll()).Data;
        }

        protected void NewStockUnit()
        {
            stockUnitDefinition = new StockUnitDefinition();
            modalRef.Show();
        }

        protected async void EditStockStatu(Guid Id)
        {
            stockUnitDefinition = (await _stockUnitDefinitionService.GetById(Id)).Data;
        }

        protected void RowClick(StockUnitDefinition row)
        {
            stockUnitDefinition = row;
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
            if (stockUnitDefinition.StockUnitDefinitionId == Guid.Empty)
            {
                result = await _stockUnitDefinitionService.Insert(stockUnitDefinition);
            }
            else
            {
                result = await _stockUnitDefinitionService.Update(stockUnitDefinition);
            }
            await Result(result);
        }

        protected async void Delete()
        {
            var result = await _stockUnitDefinitionService.Delete(stockUnitDefinition.StockUnitDefinitionId);
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
            stockUnitDefinitions = (await _stockUnitDefinitionService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
