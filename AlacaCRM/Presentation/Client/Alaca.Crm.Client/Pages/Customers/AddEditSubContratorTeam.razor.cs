using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Core.Utilities.Result;
using MudBlazor;

namespace Alaca.Crm.Client.Pages.Customers
{
    public partial class AddEditSubContratorTeam
    {
        [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }
        [Inject] public ISubContratorTeamService _subContratorTeamService { get; set; }
        [Inject] protected ICustomerService _customerService { get; set; }
        [Inject] public ICityService _cityService { get; set; }
        public SubContratorTeam subContratorTeam { get; set; } = new();
        [Parameter] public Guid SubContratorTeamId { get; set; }
        [Parameter] public Guid CustomerId { get; set; }
        Customer[] customers;
        City[] cities;
        protected override async Task OnInitializedAsync()
        {
            if (SubContratorTeamId != Guid.Empty)
                subContratorTeam = (await _subContratorTeamService.GetById(SubContratorTeamId)).Data;
            customers = (await _customerService.GetAll()).Data;
            cities = (await _cityService.GetAll()).Data;
        }

        protected string ToStringFuncCustomer(Guid id)
        {
            return customers.FirstOrDefault(p => p.CustomerId == id).CustomerName;
        }

        protected async Task<IEnumerable<Guid>> SearchCustomer(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new Guid[0];
            var lst = customers.Where(x => x.CustomerName.Contains(value)).Select(col => col.CustomerId);
            return lst;
        }

        protected async void OnValidSubmit()
        {
            subContratorTeam.CustomerId = CustomerId;
            IResult result = null;
            if (subContratorTeam.SubContratorTeamId == Guid.Empty)
                result = await _subContratorTeamService.Insert(subContratorTeam);
            else
                result = await _subContratorTeamService.Update(subContratorTeam);
            Result(result);
        }

        protected async void Delete()
        {
            var result = await _subContratorTeamService.Delete(subContratorTeam.SubContratorTeamId);
            Result(result);
        }

        private void Result(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                _mudDialog.Close();
            }
            else
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
        }

        protected void Cancel()
        {
            _mudDialog.Cancel();
        }
    }
}
