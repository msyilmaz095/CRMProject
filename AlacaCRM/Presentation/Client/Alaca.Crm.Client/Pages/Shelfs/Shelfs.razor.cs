using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Shelfs
{
    public partial class Shelfs
    {
        protected Alaca.Entities.Concrete.Shelf[] shelfs;
        [Inject] protected IShelfService _shelfService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            shelfs = (await _shelfService.GetAll()).Data;
        }

        protected void NavigateToShelf(Guid ShelfId)
        {
            _navigationManager.NavigateTo("/AddEditShelfs/" + ShelfId);
        }
        protected async void PopupShow(Guid ShelfId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditShelfs.ShelfId), ShelfId);
            var popupResult = await _dialogService.Show<AddEditShelfs>("Raf", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                shelfs = (await _shelfService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewShelf()
        {
            //NavigateToShelf(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.Shelf shelf)
        {
            ///NavigateToShelf(shelf.ShelfId);
            PopupShow(shelf.ShelfId);
        }
    }
}
