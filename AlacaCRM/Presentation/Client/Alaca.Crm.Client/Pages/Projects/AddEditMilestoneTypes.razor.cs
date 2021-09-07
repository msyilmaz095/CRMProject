using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;


namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class AddEditMilestoneTypes
    {
        private FluentValidationValidator _fluentValidationValidator;
        [CascadingParameter] public MudBlazor.MudDialogInstance _mudDialogInstance { get; set; }
        [Parameter] public byte ProjectMilestoneTypeId { get; set; }
        [Inject] public IProjectMilestoneTypeService _projectMilestoneTypeService { get; set; }
        protected ProjectMilestoneType projectMilestoneType = new ProjectMilestoneType();
        protected override async Task OnInitializedAsync()
        {
            if (ProjectMilestoneTypeId != 0)
            {
                projectMilestoneType = (await _projectMilestoneTypeService.GetById(ProjectMilestoneTypeId)).Data;
            }
        }
        protected async void Save()
        {
            IResult result;
            if (projectMilestoneType.ProjectMilestoneTypeId == 0)
            {
                result = await _projectMilestoneTypeService.Insert(projectMilestoneType);
            }
            else
            {
                result = await _projectMilestoneTypeService.Update(projectMilestoneType);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                _mudDialogInstance.Close();
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            StateHasChanged();
        }

        protected async void Delete()
        {
            var result = await _projectMilestoneTypeService.Delete(projectMilestoneType.ProjectMilestoneTypeId);
            await Result(result);
        }
    }
}
