using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.ServiceCard
{
    public partial class AddEditServiceCard
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid ServiceCardId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.ServiceCard serviceCard { get; set; } = new();
        [Inject] public IServiceCardService _serviceCardService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (ServiceCardId != Guid.Empty)
            {
                serviceCard = (await _serviceCardService.GetById(ServiceCardId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (ServiceCardId == Guid.Empty)
            {
                result = await _serviceCardService.Insert(serviceCard);
            }
            else
            {
                result = await _serviceCardService.Update(serviceCard);
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
                    _navigationManager.NavigateTo("/ServiceCards");
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
            ResultChechk(await _serviceCardService.Delete(serviceCard.ServiceCardId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/ServiceCards");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
