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

namespace Alaca.Crm.Client.Pages.LocationTypes
{
    public partial class LocationTypes
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] ILocationTypeService _locationTypeService { get; set; }
        public LocationType[] lstData;
        public LocationType data = new LocationType();
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _locationTypeService.GetAll();
            lstData = response.Data;
        }

        protected void New()
        {
            data = new LocationType();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _locationTypeService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _locationTypeService.Delete(data.LocationTypeId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.LocationTypeId == Guid.Empty)
            {
                result = await _locationTypeService.Insert(data);
            }
            else
            {
                result = await _locationTypeService.Update(data);
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
