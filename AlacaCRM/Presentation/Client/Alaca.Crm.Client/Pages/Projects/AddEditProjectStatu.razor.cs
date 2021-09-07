using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class AddEditProjectStatu
    {
        private FluentValidationValidator _fluentValidationValidator;
        [CascadingParameter] public MudDialogInstance dialogInstance { get; set; }
        [Parameter] public byte ProjectStatuId { get; set; }
        [Inject] public IProjectStatuService _projectStatuService { get; set; }
        protected ProjectStatu projectStatu = new ProjectStatu();
        protected override async Task OnInitializedAsync()
        {
            if (ProjectStatuId!=0)
            {
                projectStatu = (await _projectStatuService.GetById(ProjectStatuId)).Data;
            }
        }

        protected async void Save()
        {
            IResult result;
            if (projectStatu.ProjectStatuId == 0)
            {
                result = await _projectStatuService.Insert(projectStatu);
            }
            else
            {
                result = await _projectStatuService.Update(projectStatu);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                dialogInstance.Close();
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            StateHasChanged();
        }

        protected async void Delete()
        {
            var result = await _projectStatuService.Delete(projectStatu.ProjectStatuId);
            await Result(result);
        }
    }
}
