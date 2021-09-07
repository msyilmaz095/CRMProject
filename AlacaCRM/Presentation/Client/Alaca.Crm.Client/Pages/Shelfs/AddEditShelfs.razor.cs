using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Shelfs
{
    public partial class AddEditShelfs
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid ShelfId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.Shelf shelf { get; set; } = new();
        [Inject] public IShelfService _shelfService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (ShelfId != Guid.Empty)
            {
                shelf = (await _shelfService.GetById(ShelfId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (ShelfId == Guid.Empty)
            {
                result = await _shelfService.Insert(shelf);
            }
            else
            {
                result = await _shelfService.Update(shelf);
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
                    _navigationManager.NavigateTo("/Shelfs");
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
            ResultChechk(await _shelfService.Delete(shelf.ShelfId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/Shelfs");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
