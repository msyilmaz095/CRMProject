using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Factories
{
    public partial class AddEditFactory
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid FactoryId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.Factory factory { get; set; } = new();
        [Inject] public IFactoryService _factoryService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (FactoryId != Guid.Empty)
            {
                factory = (await _factoryService.GetById(FactoryId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (FactoryId == Guid.Empty)
            {
                result = await _factoryService.Insert(factory);
            }
            else
            {
                result = await _factoryService.Update(factory);
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
                    _navigationManager.NavigateTo("/Factories");
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
            ResultChechk(await _factoryService.Delete(factory.FactoryId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/Factories");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
