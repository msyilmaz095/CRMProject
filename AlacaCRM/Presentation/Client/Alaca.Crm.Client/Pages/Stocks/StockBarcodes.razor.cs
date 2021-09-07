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
    public partial class StockBarcodes
    {
        protected FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Parameter] public List<StockBarcode> stockBarcodes { get; set; }
        [Parameter] public List<StockUnit> stockUnits { get; set; }
        StockBarcode stockBarcode = new StockBarcode();
        protected void OnValidSubmitStockBarcode()
        {
            if (stockBarcode.StockBarcodeId == Guid.Empty)
            {
                stockBarcode.StockBarcodeId = Guid.NewGuid();
                stockBarcodes.Add(stockBarcode);
            }
            else
            {
                stockBarcodes.Remove(stockBarcodes.FirstOrDefault(p => p.StockBarcodeId == stockBarcode.StockBarcodeId));
                stockBarcodes.Add(stockBarcode);
            }
            modalRef.Hide();
        }

        protected void Close()
        {
            modalRef.Hide();
        }
        protected void New()
        {
            ///StateHasChanged();
            stockBarcode = new StockBarcode();
            modalRef.Show();
        }

        protected void Delete()
        {
            stockBarcodes.Remove(stockBarcode);
            modalRef.Hide();
        }

        protected void RowClick(StockBarcode row)
        {
            stockBarcode = row;
            modalRef.Show();
        }
    }
}
