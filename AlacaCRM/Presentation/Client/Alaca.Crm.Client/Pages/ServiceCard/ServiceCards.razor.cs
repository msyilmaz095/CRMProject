using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.ServiceCard
{
    public partial class ServiceCards
    {
        protected Alaca.Entities.Concrete.ServiceCard[] serviceCards;
        [Inject] protected IServiceCardService _serviceCardService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            serviceCards = (await _serviceCardService.GetAll()).Data;
        }

        protected void NavigateToServiceCard(Guid ServiceCardId)
        {
            _navigationManager.NavigateTo("/AddEditServiceCards/" + ServiceCardId);
        }
        protected async void PopupShow(Guid ServiceCardId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditServiceCard.ServiceCardId), ServiceCardId);
            var popupResult = await _dialogService.Show<AddEditServiceCard>("Hizmet", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                serviceCards = (await _serviceCardService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewServiceCard()
        {
            //NavigateToServiceCard(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.ServiceCard serviceCard)
        {
            ///NavigateToServiceCard(serviceCard.ServiceCardId);
            PopupShow(serviceCard.ServiceCardId);
        }
    }
}
