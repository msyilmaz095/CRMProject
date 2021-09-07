using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using Alaca.Core.Utilities.Result;

namespace Alaca.Crm.Client.Pages.Positions
{
    public partial class Positions
    {

        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;

        [Inject] IPositionService _positionService { get; set; }

        public Entities.Concrete.Position[] lstData;

        public Entities.Concrete.Position data = new Entities.Concrete.Position();

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _positionService.GetAll()).Data;
        }

        protected void New()
        {
            data = new Entities.Concrete.Position();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _positionService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _positionService.Delete(data.PositionId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.PositionId == Guid.Empty)
            {
                result = await _positionService.Insert(data);
            }
            else
            {
                result = await _positionService.Update(data);
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