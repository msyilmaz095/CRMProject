using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using MudBlazor;
using Alaca.Crm.Client.Extensions;
using Blazorise.DataGrid;
using Blazored.FluentValidation;
using Alaca.Core.Utilities.Result;

namespace Alaca.Crm.Client.Pages.Utilities
{
    public partial class Districts
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IDistrictService _districtService { get; set; }
        [Inject] ICityService _cityService { get; set; }
        public District[] lstData;
        public City[] cities;
        public District data = new District();
        protected override async Task OnInitializedAsync()
        {
            cities = (await _cityService.GetAll()).Data;
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _districtService.GetAll()).Data;
        }

        protected void New()
        {
            data = new District();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _districtService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _districtService.Delete(data.Districtd);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.Districtd == Guid.Empty)
            {
                result = await _districtService.Insert(data);
            }
            else
            {
                result = await _districtService.Update(data);
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
