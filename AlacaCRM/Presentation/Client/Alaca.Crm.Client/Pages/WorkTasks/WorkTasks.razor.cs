using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.WorkTasks
{
    public partial class WorkTasks
    {
        protected Alaca.Entities.Concrete.WorkTask[] workTasks;
        [Inject] protected IWorkTaskService _workTaskService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            workTasks = (await _workTaskService.GetAll()).Data;
        }

        protected void NavigateToWorkTask(Guid WorkTaskId)
        {
            _navigationManager.NavigateTo("/AddEditWorkTasks/" + WorkTaskId);
        }
        protected async void PopupShow(Guid WorkTaskId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditWorkTasks.WorkTaskId), WorkTaskId);
            var popupResult = await _dialogService.Show<AddEditWorkTasks>("WorkTask", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                workTasks = (await _workTaskService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewWorkTask()
        {
            //NavigateToWorkTask(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.WorkTask workTask)
        {
            ///NavigateToworkTask(workTask.workTaskId);
            PopupShow(workTask.WorkTaskId);
        }
    }
}
