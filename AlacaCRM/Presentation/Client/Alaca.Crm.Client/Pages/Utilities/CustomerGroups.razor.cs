using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Utilities
{
    public partial class CustomerGroups
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] protected ICustomerGroupService _customerGroupService { get; set; }
        protected CustomerGroup data;
        protected CustomerGroup[] lstData;

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _customerGroupService.GetAll()).Data;
        }

        protected void New()
        {
            data = new CustomerGroup();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _customerGroupService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _customerGroupService.Delete(data.CustomerGroupId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.CustomerGroupId == Guid.Empty)
            {
                result = await _customerGroupService.Insert(data);
            }
            else
            {
                result = await _customerGroupService.Update(data);
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
