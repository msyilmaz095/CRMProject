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
    public partial class Zones
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IZoneService _zoneService { get; set; }
        public Zone[] lstData;
        public Zone data = new Zone();
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _zoneService.GetAll()).Data;
        }

        protected void New()
        {
            data = new Zone();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _zoneService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _zoneService.Delete(data.ZoneId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.ZoneId == Guid.Empty)
            {
                result = await _zoneService.Insert(data);
            }
            else
            {
                result = await _zoneService.Update(data);
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
