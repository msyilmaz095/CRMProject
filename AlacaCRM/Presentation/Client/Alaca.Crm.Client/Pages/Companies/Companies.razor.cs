using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Helpers;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Companies
{
    public partial class Companies
    {

        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ICompanyService _companyService { get; set; }     
        public Company[] lstData;
        public Company data = new Company();
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _companyService.GetAll();
            lstData = response.Data;
        }

        protected void New()
        {
            data = new Company();
            modalRef.Show();
        }

        protected async Task Get(Guid CompanyId)
        {
            data = (await _companyService.GetById(CompanyId)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            //await JSRuntime.InvokeVoidAsync("swalAlert");
            var response = await _companyService.Delete(data.CompanyId);
            await GetAll();
            await DialogService.ShowDialogAlertSuccess("Kayıt Silme", "Şirket Kaydı Silindi!!!");
            modalRef.Hide();
        }

        protected async Task OnValidSubmit()
        {
            if (data.CompanyId == Guid.Empty)
            {
                var response = await _companyService.Insert(data);
                await DialogService.ShowDialogAlertSuccess("Yeni Şirket", "Yeni Şirket Kaydı Başarılı!!!");
            }
            else
            {
                await _companyService.Update(data);
                await DialogService.ShowDialogAlertSuccess("Şirket Güncelleme", "Şirket Güncelleme Başarılı!!!");
            }
            await GetAll();
            modalRef.Hide();
        }
    }
}
