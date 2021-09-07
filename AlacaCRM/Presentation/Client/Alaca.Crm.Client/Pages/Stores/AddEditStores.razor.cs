using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Stores
{
    public partial class AddEditStores
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid StoreId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.Store store { get; set; } = new();
        [Inject] public IStoreService _storeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (StoreId != Guid.Empty)
            {
                store = (await _storeService.GetById(StoreId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (StoreId == Guid.Empty)
            {
                result = await _storeService.Insert(store);
            }
            else
            {
                result = await _storeService.Update(store);
            }
            ResultChechk(result);
        }

        private void ResultChechk(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
                if (_mudDialog == null)
                {
                    _navigationManager.NavigateTo("/Stores");
                }
                else
                {
                    _mudDialog.Close();
                }
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        public async void Delete()
        {
            ResultChechk(await _storeService.Delete(store.StoreId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/Stores");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
