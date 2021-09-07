using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Currencies
{
    public partial class Currencies
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ICurrencyService _currencyService { get; set; }
        public Currency[] lstData;
        public Currency data = new Currency();
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _currencyService.GetAll();
            lstData = response.Data;
        }

        protected void New()
        {
            data = new Currency();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _currencyService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _currencyService.Delete(data.CurrencyId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.CurrencyId == Guid.Empty)
            {
                result = await _currencyService.Insert(data);
            }
            else
            {
                result = await _currencyService.Update(data);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (!result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                modalRef.Hide();
                await GetAll();
            }
        }
    }
}