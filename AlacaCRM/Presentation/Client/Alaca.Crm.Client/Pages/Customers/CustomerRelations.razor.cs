using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using MudBlazor;
using Alaca.Crm.Client.Extensions;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using Blazored.FluentValidation;
using Alaca.Core.Utilities.Result;

namespace Alaca.Crm.Client.Pages.Customers
{
    public partial class CustomerRelations
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] protected ICustomerRelationService _customerRelationService { get; set; }
        protected CustomerRelation data;
        protected CustomerRelation[] lstData;

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _customerRelationService.GetAll()).Data;
        }

        protected void New()
        {
            data = new CustomerRelation();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _customerRelationService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _customerRelationService.Delete(data.CustomerRelationId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.CustomerRelationId == Guid.Empty)
            {
                result = await _customerRelationService.Insert(data);
            }
            else
            {
                result = await _customerRelationService.Update(data);
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
