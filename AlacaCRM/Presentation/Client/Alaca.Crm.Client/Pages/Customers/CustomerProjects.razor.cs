using Alaca.Crm.Client.Pages.Projects;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Customers
{
    public partial class CustomerProjects
    {
        [Parameter] public Guid CustomerId { get; set; }
        [Inject] public IProjectService _projectService { get; set; }
        viewProject[] projects;
        protected override async Task OnInitializedAsync()
        {
            projects = (await _projectService.GetviewProjects()).Data;
        }

        public async void NewProject()
        {
            await InvokeModal(Guid.Empty);
        }
        public async void RowClick(viewProject row)
        {
            await InvokeModal(row.ProjectId);
        }

        private async Task InvokeModal(Guid id)
        {
            var parameters = new DialogParameters();
            if (id != Guid.Empty)
            {
                parameters.Add(nameof(AddEditProject.ProjectId), id);
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true, FullScreen = true };
            var dialog = _dialogService.Show<AddEditProject>("Proje", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                projects = (await _projectService.GetviewProjects()).Data;
            }
        }
    }
}
