using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.WorkTaskTypes
{
    public partial class WorkTaskTypes
    {
        protected Alaca.Entities.Concrete.WorkTaskType[] workTaskTypes;
        [Inject] protected IWorkTaskTypeService _workTaskTypeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            workTaskTypes = (await _workTaskTypeService.GetAll()).Data;
        }

        protected void NavigateToWorkTaskType(Guid WorkTaskTypeId)
        {
            _navigationManager.NavigateTo("/AddEditWorkTaskTypes/" + WorkTaskTypeId);
        }
        protected async void PopupShow(Guid WorkTaskTypeId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditWorkTaskTypes.WorkTaskTypeId), WorkTaskTypeId);
            var popupResult = await _dialogService.Show<AddEditWorkTaskTypes>("WorkTaskType", dialogParameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                workTaskTypes = (await _workTaskTypeService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewWorkTaskType()
        {
            //NavigateToWorkTaskType(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.WorkTaskType workTaskType)
        {
            ///NavigateToworkTaskType(workTaskType.workTaskTypeId);
            PopupShow(workTaskType.WorkTaskTypeId);
        }
    }
}
