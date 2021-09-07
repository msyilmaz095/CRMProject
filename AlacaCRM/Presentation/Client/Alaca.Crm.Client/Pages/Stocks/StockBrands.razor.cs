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
    public partial class StockBrands
    {
        protected FluentValidationValidator _fluentValidationValidator;
        Blazorise.Modal modalRef;
        [Inject] public IStockBrandService _stockBrandService { get; set; }
        StockBrand stockBrand = new StockBrand();
        StockBrand[] stockBrands;
        protected override async Task OnInitializedAsync()
        {
            stockBrands = (await _stockBrandService.GetAll()).Data;
        }

        protected void NewStockBrand()
        {
            stockBrand = new StockBrand();
            modalRef.Show();
        }

        protected async void EditStockBrand(Guid Id)
        {
            stockBrand = (await _stockBrandService.GetById(Id)).Data;
        }

        protected void RowClick(StockBrand row)
        {
            stockBrand = row;
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
            if (stockBrand.StockBrandId == Guid.Empty)
            {
                result = await _stockBrandService.Insert(stockBrand);
            }
            else
            {
                result = await _stockBrandService.Update(stockBrand);
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
                await Refresh();
            }
        }

        protected async void Delete()
        {
            var result = await _stockBrandService.Delete(stockBrand.StockBrandId);
            await Result(result);
        }
        private async Task Refresh()
        {
            CloseModel();
            stockBrands = (await _stockBrandService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
