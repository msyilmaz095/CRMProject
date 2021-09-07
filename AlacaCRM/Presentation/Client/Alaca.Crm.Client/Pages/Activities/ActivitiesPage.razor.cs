using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Activities
{
    public partial class ActivitiesPage
    {
        [Parameter]
        public Guid CustomerId { get; set; }
        List<viewActivity> lstActivity;

        protected override async Task OnInitializedAsync()
        {
            if (CustomerId == Guid.Empty)
            {
                lstActivity = (await _activityService.GetviewActivities()).Data.ToList();
            }
            else
            {
                lstActivity = (await _activityService.GetByCustomerIdviewActivities(CustomerId)).Data.ToList();
            }
        }

        protected void RowClick(viewActivity row)
        {
            NavigateToActivity(row.ActivityId);
        }

        protected void NewActivity()
        {
            NavigateToActivity(Guid.Empty);
        }

        private void NavigateToActivity(Guid ActivityId)
        {
            _navigationManager.NavigateTo("/Activity/" + ActivityId);
        }
    }
}
