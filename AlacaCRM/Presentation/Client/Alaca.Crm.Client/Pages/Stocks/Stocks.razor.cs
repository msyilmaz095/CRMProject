using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Stocks
{
    public partial class Stocks
    {
        [Inject] public IStockService _stockService { get; set; }
        Stock stock = new Stock();
        Stock[] stocks;
        protected override async Task OnInitializedAsync()
        {
            stocks = (await _stockService.GetAll()).Data;
        }

        public void NewStock()
        {
            _navigationManager.NavigateTo("AddEditStock");
        }
        public void RowClick(Stock row)
        {
            _navigationManager.NavigateTo("AddEditStock/" + row.StockId);
        }
    }
}
