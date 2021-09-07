using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Stores
{
    public partial class Stores
    {
        protected Alaca.Entities.Concrete.Store[] stores;
        [Inject] protected IStoreService _storeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            stores = (await _storeService.GetAll()).Data;
        }

        protected void NavigateToStore(Guid StoreId)
        {
            _navigationManager.NavigateTo("/AddEditStores/" + StoreId);
        }
        protected async void PopupShow(Guid StoreId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditStores.StoreId), StoreId);
            var popupResult = await _dialogService.Show<AddEditStores>("Store", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                stores = (await _storeService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewStore()
        {
            //NavigateToStore(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.Store store)
        {
            ///NavigateToStore(store.StoreId);
            PopupShow(store.StoreId);
        }
    }
}
