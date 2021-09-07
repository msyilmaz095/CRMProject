using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class AddEditProject
    {
        protected MudSelect<Guid?> refMudSelectContact;
        [Parameter] public Guid ProjectId { get; set; }
        protected Project project { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [Inject] protected IProjectService _projectService { get; set; }
        [Inject] protected ICustomerService _customerService { get; set; }
        [Inject] protected IContactService _contactService { get; set; }
        [Inject] protected IEmployeeService _employeeService { get; set; }
        [Inject] protected ICurrencyService _currencyService { get; set; }
        [Inject] protected IPaymentMethodService _paymentMethodService { get; set; }
        [Inject] protected IProjectStatuService _projectStatuService { get; set; }
        Customer[] customers;
        Employee[] employees;
        ProjectStatu[] projectStatus;
        Currency[] currencies;
        PaymentMethod[] paymentMethods;
        Contact[] contacts;
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        protected override async Task OnInitializedAsync()
        {
            if (ProjectId != Guid.Empty)
            {
                project = (await _projectService.GetById(ProjectId)).Data;
            }
            paymentMethods = (await _paymentMethodService.GetAll()).Data;
            currencies = (await _currencyService.GetAll()).Data;
            customers = (await _customerService.GetAll()).Data;
            employees = (await _employeeService.GetAll()).Data;
            contacts = (await _contactService.GetAll()).Data;
            projectStatus = (await _projectStatuService.GetAll()).Data;
        }

        public async Task OnValidSubmit()
        {
            IResult result;
            if (project.ProjectId == Guid.Empty)
            {
                result = await _projectService.Insert(project);
            }
            else
            {
                result = await _projectService.Update(project);
            }
            Result(result);
            if (MudDialog != null)
                MudDialog.Close();
            else
            {
                _navigationManager.NavigateTo("/AddEditProject/" + result.RecordId);
                StateHasChanged();
            }
        }

        private void Result(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        private async void Delete()
        {
            var result = await _projectService.Delete(project.ProjectId);
            Result(result);
            if (MudDialog != null)
                MudDialog.Close();
            else
                _navigationManager.NavigateTo("/projects");
        }

        private void Cancel()
        {
            if (MudDialog != null)
                MudDialog.Cancel();
            else
            {
                _navigationManager.NavigateTo("/projects");
            }
        }
        protected async Task<IEnumerable<Guid>> SearchCustomer(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new Guid[0];
            var lst = customers.Where(x => x.CustomerName.Contains(value)).Select(col => col.CustomerId);
            return lst;
        }

        protected async void GetCustomerContact(Guid id)
        {
            contacts = (await _contactService.GetContactByCustomerIdAll(id)).Data.ToArray();
        }

        protected string ToStringFuncCustomer(Guid id)
        {
            GetCustomerContact(id);
            return customers.FirstOrDefault(p => p.CustomerId == id).CustomerName;
        }
    }
}
