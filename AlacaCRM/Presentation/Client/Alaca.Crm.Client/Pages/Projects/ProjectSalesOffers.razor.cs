using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class ProjectSalesOffers
    {
        [Inject] public ISalesOfferService _salesOfferService { get; set; }
        [Parameter] public Guid ProjectId { get; set; }
        viewSalesOffer[] salesOffers;

        protected async override Task OnInitializedAsync()
        {
            await RefreshSalesOffers();
        }

        private async Task RefreshSalesOffers()
        {
            salesOffers = (await _salesOfferService.GetByProjectIdSalesOffers(ProjectId)).Data;
        }

        public async void NewSalesOffer()
        {
            await ShowSalesOffer(Guid.Empty);
        }
        public async void RowClick(viewSalesOffer row)
        {
            await ShowSalesOffer(row.SalesOfferId);
        }

        private async Task ShowSalesOffer(Guid SalesOfferId)
        {
            if (!await _dialogService.ShowSalesOfferPopupIsCancelled(SalesOfferId))
            {
                await RefreshSalesOffers();
                StateHasChanged();
            }
        }
    }
}
