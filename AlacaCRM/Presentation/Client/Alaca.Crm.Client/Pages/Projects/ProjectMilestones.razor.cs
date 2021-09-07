using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using MudBlazor;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class ProjectMilestones
    {
        [Parameter] public Guid ProjectId { get; set; }

        [Inject] protected IProjectMilestoneService _projectMilestoneService { get; set; }
        protected viewProjectMilestone[] viewProjectMilestones;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            viewProjectMilestones = (await _projectMilestoneService.GetByProjectIdProjectMilestone(ProjectId)).Data;
        }

        protected void NewProjectMilestone()
        {
            ShowDialog(Guid.Empty);
        }

        protected void RowClick(ProjectMilestone data)
        {
            ShowDialog(data.ProjectMilestoneId);
        }

        private async void ShowDialog(Guid ProjectMilestoneId)
        {
            DialogParameters parameters = new DialogParameters();
            parameters.Add("ProjectId", ProjectId);
            parameters.Add("ProjectMilestoneId", ProjectMilestoneId);
            var dialog = _dialogService.Show<AddEditProjectMilestone>("", parameters);
            if (!(await dialog.Result).Cancelled)
            {
                await GetAll();
                StateHasChanged();
            }
        }
    }
}
