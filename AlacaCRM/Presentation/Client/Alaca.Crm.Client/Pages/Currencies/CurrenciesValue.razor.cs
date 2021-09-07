using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
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
    public partial class CurrenciesValue
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] ICurrencyValueService _currencyvalueService { get; set; }
        [Inject] ICurrencyService _currencyService { get; set; }
        public viewCurrencyValue[] lstData;
        public Currency[] lstCurrency;
        public CurrencyValue data = new CurrencyValue();

        protected override async Task OnInitializedAsync()
        {
            lstCurrency = (await _currencyService.GetAll()).Data;
            await GetAll();
        }
        protected async Task GetAll()
        {
            lstData = (await _currencyvalueService.GetviewCurrencyValue()).Data;
        }

        protected void New()
        {
            data = new CurrencyValue();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _currencyvalueService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _currencyvalueService.Delete(data.CurrencyValuesId);
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

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.CurrencyValuesId == Guid.Empty)
            {
                result = await _currencyvalueService.Insert(data);
            }
            else
            {
                result = await _currencyvalueService.Update(data);
            }
            await Result(result);
        }
    }
}
