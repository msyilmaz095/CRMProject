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

namespace Alaca.Crm.Client.Pages.Utilities
{
    public partial class ContactTypePage
    {
        private FluentValidationValidator _fluentValidationValidator;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] IContactTypeService _contactTypeService { get; set; }
        protected ContactType[] contactTypes;
        protected ContactType contactType = new ContactType();
        protected Blazorise.Modal modalRef;

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            contactTypes = (await _contactTypeService.GetAll()).Data;
        }

        protected void NewContactType()
        {
            contactType = new ContactType();
            modalRef.Show();
        }
        protected async void GetContactType(Guid contactTypeId)
        {
            contactType = (await _contactTypeService.GetById(contactTypeId)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _contactTypeService.Delete(contactType.ContactTypeId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (contactType.ContactTypeId == Guid.Empty)
            {
                result = await _contactTypeService.Insert(contactType);
            }
            else
            {
                result = await _contactTypeService.Update(contactType);
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
