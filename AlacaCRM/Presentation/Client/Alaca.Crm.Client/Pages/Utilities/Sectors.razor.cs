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
    public partial class Sectors
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] ISectorService _sectorService { get; set; }
        public Sector[] lstData;
        public Sector data = new Sector();
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _sectorService.GetAll()).Data;
        }

        protected void New()
        {
            data = new Sector();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _sectorService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _sectorService.Delete(data.SectorId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.SectorId == Guid.Empty)
            {
                result = await _sectorService.Insert(data);
            }
            else
            {
                result = await _sectorService.Update(data);
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
