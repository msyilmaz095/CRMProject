using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Factories
{
    public partial class Factories
    {
        protected Alaca.Entities.Concrete.Factory[] factories;
        [Inject] protected IFactoryService _factoryService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            factories = (await _factoryService.GetAll()).Data;
        }

        protected void NavigateToFactory(Guid FactoryId)
        {
            _navigationManager.NavigateTo("/AddEditFactories/" + FactoryId);
        }
        protected async void PopupShow(Guid FactoryId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditFactory.FactoryId), FactoryId);
            var popupResult = await _dialogService.Show<AddEditFactory>("Fabrika", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                factories = (await _factoryService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewFactory()
        {
            //NavigateToFactory(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.Factory factory)
        {
            ///NavigateToFactory(factory.FactoryId);
            PopupShow(factory.FactoryId);
        }
    }
}
