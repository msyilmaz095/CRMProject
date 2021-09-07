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
    public partial class ContactStatusPage
    {
        private FluentValidationValidator _fluentValidationValidator;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] IContactStatuService _contactStatuService { get; set; }
        protected ContactStatu[] contactStatus;
        protected ContactStatu contactStatu = new ContactStatu();
        protected Blazorise.Modal modalRef;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            contactStatus = (await _contactStatuService.GetAll()).Data;
        }

        protected void NewContactStatu()
        {
            contactStatu = new ContactStatu();
            modalRef.Show();
        }
        protected async void GetContactType(Guid contactTypeId)
        {
            contactStatu = (await _contactStatuService.GetById(contactTypeId)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _contactStatuService.Delete(contactStatu.ContactStatuId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (contactStatu.ContactStatuId == Guid.Empty)
            {
                result = await _contactStatuService.Insert(contactStatu);
            }
            else
            {
                result = await _contactStatuService.Update(contactStatu);
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
