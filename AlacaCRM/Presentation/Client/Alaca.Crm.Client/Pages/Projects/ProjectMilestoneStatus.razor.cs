using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class ProjectMilestoneStatus
    {
        [Inject] public IProjectMilestoneStatuService _projectMilestoneStatuService { get; set; }
        protected ProjectMilestoneStatu projectMilestoneStatu = new ProjectMilestoneStatu();
        protected ProjectMilestoneStatu[] projectMilestoneStatus;
        private bool visible;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            projectMilestoneStatus = (await _projectMilestoneStatuService.GetAll()).Data;
        }

        protected void NewMilestoneStatus()
        {
            SetprojectMilestoneStatu(new ProjectMilestoneStatu());
        }

        private void SetprojectMilestoneStatu(ProjectMilestoneStatu data)
        {
            projectMilestoneStatu = data;
            visible = true;
        }

        protected async void Save()
        {
            IResult result;
            if (projectMilestoneStatu.ProjectMilestoneStatuId == 0)
            {
                result = await _projectMilestoneStatuService.Insert(projectMilestoneStatu);
            }
            else
            {
                result = await _projectMilestoneStatuService.Update(projectMilestoneStatu);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (result.Success)
            {
                await GetAll();
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                visible = false;
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            StateHasChanged();
        }

        protected async void Delete()
        {
            var result = await _projectMilestoneStatuService.Delete(projectMilestoneStatu.ProjectMilestoneStatuId);
            await Result(result);
        }

        void RowClick(ProjectMilestoneStatu row)
        {
            SetprojectMilestoneStatu(row);
        }
    }
}
