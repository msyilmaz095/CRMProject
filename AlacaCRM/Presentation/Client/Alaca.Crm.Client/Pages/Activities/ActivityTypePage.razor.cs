using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using MudBlazor;
using Alaca.Crm.Client.Extensions;
using Blazored.FluentValidation;

namespace Alaca.Crm.Client.Pages.Activities
{
    public partial class ActivityTypePage
    {
        private FluentValidationValidator _fluentValidationValidator;
        protected Blazorise.Modal modalRef;
        [Inject] IActivityTypeService _activityTypeService { get; set; }
        protected ActivityType[] activityTypes;
        protected ActivityType activityType = new ActivityType();
        protected override async Task OnInitializedAsync()
        {
            activityTypes = (await _activityTypeService.GetAll()).Data;
        }

        protected void RowClick(ActivityType row)
        {
            activityType = row;
            ShowModel();
        }

        protected void ShowModel()
        {
            modalRef.Show();
        }

        protected void NewRecord()
        {
            activityType = new ActivityType();
            ShowModel();
        }

        protected void CloseModel()
        {
            modalRef.Hide();
        }

        protected async void Delete()
        {
            await _activityTypeService.Delete(activityType.ActivityTypeId);
            var result = await _dialogService.ShowDialogAlertSuccess("Aktivite Türü", "Aktivite Tür Silindi!!!");
            await Refresh();
        }

        protected async void Save()
        {
            if (activityType.ActivityTypeId == Guid.Empty)
            {
                await _activityTypeService.Insert(activityType);
            }
            else
            {
                await _activityTypeService.Update(activityType);
            }
            var result = await _dialogService.ShowDialogAlertSuccess("Aktivite Türü", "Aktivite Tür Kaydedildi!!!");
            await Refresh();
        }

        private async Task Refresh()
        {
            CloseModel();
            activityTypes = (await _activityTypeService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
