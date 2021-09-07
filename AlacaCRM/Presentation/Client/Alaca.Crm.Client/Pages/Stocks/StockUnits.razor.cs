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
    public partial class StockUnits
    {
        protected FluentValidationValidator _fluentValidationValidator;
        [Inject] protected IStockUnitDefinitionService _stockUnitDefinitionService { get; set; }
        StockUnitDefinition[] stockUnitDefinitions;
        protected Blazorise.Modal modalRef;
        [Parameter] public List<StockUnit> stockUnits { get; set; }
        StockUnit stockUnit = new StockUnit();

        protected override async Task OnInitializedAsync()
        {
            stockUnitDefinitions = (await _stockUnitDefinitionService.GetAll()).Data;
        }
        protected void OnValidSubmitStockBarcode()
        {
            if (stockUnit.StockUnitId == Guid.Empty)
            {
                stockUnit.StockUnitId = Guid.NewGuid();
                stockUnits.Add(stockUnit);
            }
            else
            {
                stockUnits.Remove(stockUnits.FirstOrDefault(p => p.StockUnitId == stockUnit.StockUnitId));
                stockUnits.Add(stockUnit);
            }
            modalRef.Hide();
        }

        protected void Close()
        {
            modalRef.Hide();
        }
        protected void New()
        {
            stockUnit = new StockUnit();
            modalRef.Show();
        }

        protected void Delete()
        {
            stockUnits.Remove(stockUnit);
            modalRef.Hide();
        }

        protected void RowClick(StockUnit row)
        {
            stockUnit = row;
            modalRef.Show();
        }
    }
}
