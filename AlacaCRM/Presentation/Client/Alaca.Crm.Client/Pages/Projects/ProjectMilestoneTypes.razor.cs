using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class ProjectMilestoneTypes
    {
        [Inject] public IProjectMilestoneTypeService _projectMilestoneTypeService { get; set; }
        protected ProjectMilestoneType[] projectMilestoneTypes;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            projectMilestoneTypes = (await _projectMilestoneTypeService.GetAll()).Data;
        }

        protected void NewMilestoneType()
        {
            SetprojectMilestoneType(new ProjectMilestoneType());
        }

        private async void SetprojectMilestoneType(ProjectMilestoneType data)
        {
            DialogParameters parameters = new DialogParameters();
            parameters.Add("ProjectMilestoneTypeId", data.ProjectMilestoneTypeId);
            var result= await _dialogService.Show<AddEditMilestoneTypes>("", parameters).Result;
            if (!result.Cancelled)
            {
                await GetAll();
                StateHasChanged();
            }
        }      

        void RowClick(ProjectMilestoneType row)
        {
            SetprojectMilestoneType(row);
        }
    }
}