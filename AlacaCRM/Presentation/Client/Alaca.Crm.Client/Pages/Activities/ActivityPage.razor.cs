using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Activities
{
    public partial class ActivityPage
    {
        private FluentValidationValidator _fluentValidationValidator;
        [CascadingParameter] private MudDialogInstance mudDialog { get; set; }
        [Parameter] public Guid ActivityId { get; set; }
        [Parameter] public Guid ProjectId { get; set; }
        [Parameter] public Guid CustomerId { get; set; }
        [Inject] public IActivityService _activityService { get; set; }
        [Inject] public IEmployeeService _employeeService { get; set; }
        [Inject] public ICustomerService _customerService { get; set; }
        [Inject] public IActivityTypeService _activityTypeService { get; set; }
        [Inject] public IContactService _contactService { get; set; }
        [Inject] public IProjectService _projectService { get; set; }

        protected HashSet<Guid?> selectedEmployees { get; set; } = new HashSet<Guid?>() { };
        protected bool IsEmployeesActivities = false;
        protected Activity activity = new Activity();
        protected ActivityType[] activityTypes;
        protected Employee[] employees;
        protected Contact[] contacts;
        protected Customer[] customers;
        protected Project[] projects;
        protected async override Task OnInitializedAsync()
        {
            customers = (await _customerService.GetAll()).Data;
            employees = (await _employeeService.GetAll()).Data;
            activityTypes = (await _activityTypeService.GetAll()).Data;
            if (ActivityId == Guid.Empty)
            {
                activity = new Activity();
                activity.CustomerId = CustomerId;
                activity.ProjectId = ProjectId;
            }
            else
            {
                activity = (await _activityService.GetById(ActivityId)).Data;
            }
            await GetCustomerDetail(activity.CustomerId);
        }

        protected async void Save()
        {
            if (activity.ProjectId!=null && projects.FirstOrDefault(p => p.ProjectId == activity.ProjectId) == null)
            {
                _snackBar.Add("Proje seçimi doğru yapılmadı kontrol edin.", Severity.Error);
                return;
            }

            IResult result;
            if (activity.ActivityId == Guid.Empty)
            {
                if (IsEmployeesActivities)
                    result = await InsertEmployeesActivity();
                else
                    result = await _activityService.Insert(activity);
            }
            else
                result = await _activityService.Update(activity);
            if (!result.Success)
                _snackBar.Add("Aktivite Kaydı Başarısız.", Severity.Error);
            else
            {
                _snackBar.Add("Aktivite Kaydı Başarılı.", Severity.Success);
                Close();
            }
        }

        private void Close()
        {
            if (mudDialog != null)
                mudDialog.Close();
            else
                _navigationManager.NavigateTo("/Activities");
        }

        private async Task<IResult> InsertEmployeesActivity()
        {
            IResult result = new FailedResult("Personel seçimi yapılmadı!");
            foreach (var item in selectedEmployees)
            {
                activity.EmployeeId = item;
                result = await _activityService.Insert(activity);
            }
            return result;
        }

        protected async void CustomerSelectionChange(Guid? id)
        {
            activity.CustomerId = id;
            await GetCustomerDetail(id);
        }

        private async Task GetCustomerDetail(Guid? CustomerId)
        {
            if (CustomerId == null || CustomerId == Guid.Empty)
                return;
            projects = (await _projectService.GetByCustomerIdProject((Guid)CustomerId)).Data;
            contacts = (await _contactService.GetContactByCustomerIdAll((Guid)CustomerId)).Data.ToArray();
        }

        protected void Cancel()
        {
            if (mudDialog == null)
                _navigationManager.NavigateTo("Activities");
            else
                mudDialog.Cancel();
        }

        protected async void Delete()
        {
            await _activityService.Delete(activity.ActivityId);
            _snackBar.Add("Aktivite Kaydı Silindi.", Severity.Success);
            Close();
        }

        public ActivityType SelectionActiveType
        {
            get
            {
                return activityTypes?.FirstOrDefault(p => p.ActivityTypeId == activity.ActivityTypeId);
            }
        }

        protected string GetMultiSelectionText(List<string> selectedValues)
        {
            var selectedEmployees = employees?.Where(p => selectedValues.Contains(p.EmployeeId.ToString())).Select(x => x.Name + " " + x.Surname).ToList();
            return $"{string.Join(", ", selectedEmployees.Select(x => x))}";
        }

        protected void IsEmployeesActivitiesChange(bool value)
        {
            IsEmployeesActivities = value;
            activity.EmployeeId = null;
            selectedEmployees = new HashSet<Guid?>();
        }
    }
}
