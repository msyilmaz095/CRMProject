using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Service.Extensions;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Stocks
{
    public partial class AddEditStock
    {
        protected FluentValidationValidator _fluentValidationValidator;
        public StockUnits refUnit { get; set; }
        [Inject] protected IStockService _stockService { get; set; }
        [Inject] protected IStockUnitService _stockUnitService { get; set; }
        [Inject] protected IRayonService _rayonService { get; set; }
        [Inject] protected IStockBrandService _stockBrandService { get; set; }
        [Inject] protected IStockGroupService _stockGroupService { get; set; }
        [Inject] protected IStockStatuService _stockStatuService { get; set; }
        [Inject] protected IStockBarcodeService _stockBarcodeService { get; set; }
        [Inject] protected IPaymentMethodService _paymentMethodService { get; set; }
        [Parameter] public Guid? StockId { get; set; }

        Rayon[] rayons;
        List<StockBarcode> stockBarcodes = new List<StockBarcode>();
        List<StockUnit> stockUnits = new List<StockUnit>();
        StockBrand[] stockBrands;
        StockGroup[] stockGroups;
        StockStatu[] stockStatus;
        PaymentMethod[] paymentMethods;
        Stock stock = new Stock();
        protected override async Task OnInitializedAsync()
        {
            if (StockId != null && StockId != Guid.Empty)
            {
                stock = (await _stockService.GetById((Guid)StockId)).Data;
                stockBarcodes = (await _stockBarcodeService.GetByStockIdStockBarcode(StockId)).Data.ToList();
                stockUnits = (await _stockUnitService.GetByStockIdStockUnit(StockId)).Data.ToList();
            }
            stockBrands = (await _stockBrandService.GetAll()).Data;
            rayons = (await _rayonService.GetAll()).Data;
            stockGroups = (await _stockGroupService.GetAll()).Data;
            stockStatus = (await _stockStatuService.GetAll()).Data;
            paymentMethods = (await _paymentMethodService.GetAll()).Data;
        }
        protected void Close()
        {
            _navigationManager.NavigateTo("/Stocks");
        }

        protected async void Delete()
        {
            var result = await _stockService.Delete(stock.StockId);
            if (!result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                Close();
            }
        }

        private void Result(IResult result)
        {
        }

        protected async void OnValidSubmitStock()
        {
            IResult result;
            if (stock.StockId == Guid.Empty)
            {
                result = await _stockService.Insert(stock);
            }
            else
                result = await _stockService.Update(stock);
            if (!result.Success) _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            else
            {
                #region StockBarcodeService
                foreach (var item in stockBarcodes)
                {
                    if ((await _stockBarcodeService.GetById(item.StockBarcodeId)).Data != null)
                    {
                        await _stockBarcodeService.Update(item);
                    }
                    else
                    {
                        item.StockId = result.RecordId.ObjectToGuid();
                        await _stockBarcodeService.Insert(item);
                    }
                }
                foreach (var item in (await _stockBarcodeService.GetByStockIdStockBarcode(StockId)).Data)
                {
                    if (stockBarcodes.FirstOrDefault(p => p.StockBarcodeId == item.StockBarcodeId) == null)
                    {
                        await _stockBarcodeService.Delete(item.StockBarcodeId);
                    }
                }
                #endregion
                #region StockUnitService
                foreach (var item in stockUnits)
                {
                    if ((await _stockUnitService.GetById(item.StockUnitId)).Data != null)
                    {
                        await _stockUnitService.Update(item);
                    }
                    else
                    {
                        item.StockId =result.RecordId.ObjectToGuid();
                        await _stockUnitService.Insert(item);
                    }
                }
                foreach (var item in (await _stockUnitService.GetByStockIdStockUnit(StockId)).Data)
                {
                    if (stockUnits.FirstOrDefault(p => p.StockUnitId == item.StockUnitId) == null)
                    {
                        await _stockUnitService.Delete(item.StockUnitId);
                    }
                }
                #endregion
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                Close();
            }
        }
    }
}
