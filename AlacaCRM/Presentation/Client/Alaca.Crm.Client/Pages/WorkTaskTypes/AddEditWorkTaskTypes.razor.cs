using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.WorkTaskTypes
{
    public partial class AddEditWorkTaskTypes
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid WorkTaskTypeId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.WorkTaskType workTaskType { get; set; } = new();
        [Inject] public IWorkTaskTypeService _workTaskTypeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (WorkTaskTypeId != Guid.Empty)
            {
                workTaskType = (await _workTaskTypeService.GetById(WorkTaskTypeId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (WorkTaskTypeId == Guid.Empty)
            {
                result = await _workTaskTypeService.Insert(workTaskType);
            }
            else
            {
                result = await _workTaskTypeService.Update(workTaskType);
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
                    _navigationManager.NavigateTo("/WorkTaskTypes");
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
            ResultChechk(await _workTaskTypeService.Delete(workTaskType.WorkTaskTypeId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/WorkTaskTypes");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
