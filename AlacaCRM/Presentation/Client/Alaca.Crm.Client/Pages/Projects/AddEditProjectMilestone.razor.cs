using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using MudBlazor;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class AddEditProjectMilestone
    {
        private FluentValidationValidator _fluentValidationValidator;
        [Parameter] public Guid ProjectId { get; set; }
        [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid ProjectMilestoneId { get; set; }
        [Inject] protected IProjectMilestoneService _projectMilestoneService { get; set; }
        [Inject] protected ICustomerService _customerService { get; set; }
        [Inject] protected IProjectMilestoneTypeService _projectMilestoneTypeService { get; set; }
        [Inject] protected IEmployeeService _employeeService { get; set; }
        [Inject] protected IProjectMilestoneStatuService _projectMilestoneStatuService { get; set; }
        [Inject] protected ISubContratorTeamService _subContratorTeamService { get; set; }
        protected ProjectMilestone projectMilestone { get; set; } = new();
        protected Customer[] customers;
        protected Employee[] employees;
        protected SubContratorTeam[] subContratorTeams;
        protected ProjectMilestoneStatu[] projectMilestoneStatus;
        protected ProjectMilestoneType[] projectMilestoneTypes;
        protected override async Task OnInitializedAsync()
        {
            employees = (await _employeeService.GetAll()).Data;
            projectMilestoneStatus = (await _projectMilestoneStatuService.GetAll()).Data;
            projectMilestoneTypes = (await _projectMilestoneTypeService.GetAll()).Data;
            customers = (await _customerService.GetAll()).Data;
            if (ProjectMilestoneId != Guid.Empty)
            {
                projectMilestone = (await _projectMilestoneService.GetById(ProjectMilestoneId)).Data;
                if (projectMilestone.SubContratorId != null)
                    GetByCustomerIdSubContratorTeam((Guid)projectMilestone.SubContratorId);
            }
        }
        protected async void Delete()
        {
            var result = await _projectMilestoneService.Delete(projectMilestone.ProjectMilestoneId);
            Result(result);
        }

        protected async void OnValidSubmit()
        {
            IResult result;
            if (projectMilestone.ProjectMilestoneId == Guid.Empty)
            {
                projectMilestone.ProjectId = ProjectId;
                result = await _projectMilestoneService.Insert(projectMilestone);
            }
            else
            {
                result = await _projectMilestoneService.Update(projectMilestone);
            }
            Result(result);
        }

        private void Result(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
                _mudDialog.Close();
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        protected async Task<IEnumerable<Guid?>> SearchCustomer(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new Guid?[0];
            var lst = customers.Where(x => x.CustomerName.Contains(value)).Select(col => (Guid?)col.CustomerId);
            return lst;
        }

        protected string ToStringFuncCustomer(Guid? id)
        {
            GetByCustomerIdSubContratorTeam((Guid)id);
            return customers.FirstOrDefault(p => p.CustomerId == id).CustomerName;
        }

        protected async void GetByCustomerIdSubContratorTeam(Guid id)
        {
            subContratorTeams = (await _subContratorTeamService.GetByCustomerIdSubContratorTeam((Guid)id)).Data;
        }
    }
}
