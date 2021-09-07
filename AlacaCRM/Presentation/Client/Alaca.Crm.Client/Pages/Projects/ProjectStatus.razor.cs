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
    public partial class ProjectStatus
    {
        [Inject] public IProjectStatuService _projectStatuService { get; set; }
        protected ProjectStatu[] projectStatus;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            projectStatus = (await _projectStatuService.GetAll()).Data;
        }

        protected void NewProjectStatu()
        {
            SetProjectStatu(new ProjectStatu());
        }

        private async void SetProjectStatu(ProjectStatu data)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditProjectStatu.ProjectStatuId), data.ProjectStatuId);
            var result = await _dialogService.Show<AddEditProjectStatu>("Proje Durumları", dialogParameters).Result;
            if (!result.Cancelled)
            {
                await GetAll();
                StateHasChanged();
            }
        }


        void RowClick(ProjectStatu row)
        {
            SetProjectStatu(row);
        }
    }
}
