using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Extensions;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class ProjectActivities
    {
        [Parameter] public Guid ProjectId { get; set; }
        [Parameter] public Guid CustomerId { get; set; }
        List<viewActivity> lstActivity;
        [Inject] public IActivityService _activityService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await RefreshData();
        }

        private async Task RefreshData()
        {
            lstActivity = (await _activityService.GetByProjectIdviewActivities(ProjectId)).Data.ToList();
        }

        protected async void RowClick(viewActivity row)
        {
            if (!await _dialogService.ShowActivityPopupIsCancelled(row.ActivityId,row.CustomerId,row.ProjectId))
            {
                await RefreshData();
                StateHasChanged();
            }
        }

        protected async void NewActivity()
        {
            if (!await _dialogService.ShowActivityPopupIsCancelled(Guid.Empty, CustomerId, ProjectId))
            {
                await RefreshData();
                StateHasChanged();
            }
        }
    }
}
