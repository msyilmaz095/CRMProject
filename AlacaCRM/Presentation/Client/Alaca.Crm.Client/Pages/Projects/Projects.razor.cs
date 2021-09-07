using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Projects
{
    public partial class Projects
    {
        [Inject] public IProjectService _projectService { get; set; }
        viewProject[] projects;
        protected override async Task OnInitializedAsync()
        {
            projects = (await _projectService.GetviewProjects()).Data;
        }

        public void NewProject()
        {
            InvokeModal(Guid.Empty);
        }
        public void RowClick(viewProject row)
        {
            InvokeModal(row.ProjectId);
        }

        private void InvokeModal(Guid id)
        {
            _navigationManager.NavigateTo("/AddEditProject/" + id);
            /*var parameters = new DialogParameters();
            if (id != Guid.Empty)
            {
                var project = (await _projectService.GetById(id)).Data;
                if (project != null)
                {
                    parameters.Add(nameof(AddEditProject.project), project);
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true, FullScreen = true };
            var dialog = _dialogService.Show<AddEditProject>("Proje", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                projects = (await _projectService.GetviewProjects()).Data;
            }*/
        }

    }
}
