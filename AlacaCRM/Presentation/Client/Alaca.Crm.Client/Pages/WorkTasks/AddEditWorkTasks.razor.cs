using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.WorkTasks
{
    public partial class AddEditWorkTasks
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid WorkTaskId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.WorkTask workTask { get; set; } = new();
        [Inject] public IWorkTaskService _workTaskService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (WorkTaskId != Guid.Empty)
            {
                workTask = (await _workTaskService.GetById(WorkTaskId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (WorkTaskId == Guid.Empty)
            {
                result = await _workTaskService.Insert(workTask);
            }
            else
            {
                result = await _workTaskService.Update(workTask);
            }
            ResultChechk(result);
        }

        private void ResultChechk(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
                if (_mudDialog == null)
                {
                    _navigationManager.NavigateTo("/WorkTasks");
                }
                else
                {
                    _mudDialog.Close();
                }
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        public async void Delete()
        {
            ResultChechk(await _workTaskService.Delete(workTask.WorkTaskId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/WorkTasks");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
