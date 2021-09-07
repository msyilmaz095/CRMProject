using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.SalesOffers
{
    public partial class SalesOffers
    {
        [Inject] public ISalesOfferService _salesOfferService { get; set; }
        viewSalesOffer[] salesOffers;
        protected override async Task OnInitializedAsync()
        {
            salesOffers = (await _salesOfferService.GetviewSalesOffers()).Data;
        }

        public void NewSalesOffer()
        {
            _navigationManager.NavigateTo("AddEditSalesOffer");
        }
        public void RowClick(viewSalesOffer row)
        {
            _navigationManager.NavigateTo("AddEditSalesOffer/" + row.SalesOfferId);
        }
    }
}
