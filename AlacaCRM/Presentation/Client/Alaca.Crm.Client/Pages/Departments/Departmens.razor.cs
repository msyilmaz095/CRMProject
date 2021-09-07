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

namespace Alaca.Crm.Client.Pages.Departments
{
    public partial class Departmens
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;

        [Inject] IDepartmentService _departmentService { get; set; }

        public Department[] lstData;

        public Department data = new Department();

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        protected async Task GetAll()
        {
            lstData = (await _departmentService.GetAll()).Data;
        }

        protected void New()
        {
            data = new Department();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            data = (await _departmentService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _departmentService.Delete(data.DepartmentId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.DepartmentId == Guid.Empty)
            {
                result = await _departmentService.Insert(data);
            }
            else
            {
                result = await _departmentService.Update(data);
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
