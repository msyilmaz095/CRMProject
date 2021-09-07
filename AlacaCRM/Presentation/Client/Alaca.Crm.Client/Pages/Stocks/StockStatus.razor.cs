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
    public partial class StockStatus
    {
        protected FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] public IStockStatuService _stockStatuService { get; set; }
        StockStatu stockStatu = new StockStatu();
        StockStatu[] stockStatus;

        protected override async Task OnInitializedAsync()
        {
            stockStatus = (await _stockStatuService.GetAll()).Data;
        }

        protected void NewStockStatu()
        {
            stockStatu = new StockStatu();
            modalRef.Show();
        }

        protected async void EditStockStatu(Guid Id)
        {
            stockStatu = (await _stockStatuService.GetById(Id)).Data;
        }

        protected void RowClick(StockStatu row)
        {
            stockStatu = row;
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
            if (stockStatu.StockStatuId == Guid.Empty)
            {
                result = await _stockStatuService.Insert(stockStatu);
            }
            else
            {
                result = await _stockStatuService.Update(stockStatu);
            }
            await Result(result);
        }

        protected async void Delete()
        {
            var result = await _stockStatuService.Delete(stockStatu.StockStatuId);
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
            stockStatus = (await _stockStatuService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
