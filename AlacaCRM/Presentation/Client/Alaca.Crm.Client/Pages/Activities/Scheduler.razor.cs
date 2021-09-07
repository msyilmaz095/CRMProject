using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components.Web;
using Radzen.Blazor;
using Microsoft.AspNetCore.Http;
using Alaca.Core.Utilities.Extension;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using Alaca.Crm.Client.Extensions;
using Alaca.Entities.Dto;

namespace Alaca.Crm.Client.Pages.Activities
{
    public partial class Scheduler
    {
        [Inject] IActivityService _activityService { get; set; }
        [Inject] AuthenticationStateProvider _authenticationState { get; set; }
        viewActivity[] activities;
        RadzenScheduler<Activity> scheduler;

        void OnSlotSelect(Radzen.SchedulerSlotSelectEventArgs args)
        {
            ActivityPopup(Guid.Empty);
        }

        public async void ActivityPopup(Guid ActivityId)
        {
            if (!await _dialogService.ShowActivityPopupIsCancelled(ActivityId, Guid.Empty, Guid.Empty))
            {
                await scheduler.Reload();
            }
        }

        void OnAppointmentSelect(Radzen.SchedulerAppointmentSelectEventArgs<Activity> args)
        {
            ActivityPopup(args.Data.ActivityId);
        }

       async void OnLoadData(Radzen.SchedulerLoadDataEventArgs args)
        {
            var result =await _authenticationState.GetAuthenticationStateAsync();
            var UserId = Guid.Parse(result.User.ClaimNameIdentifier()[0]);
            activities = (await _activityService.GetByDateBetweenviewActivities(args.Start,args.End, UserId)).Data;
            StateHasChanged();
        }
    }
}
