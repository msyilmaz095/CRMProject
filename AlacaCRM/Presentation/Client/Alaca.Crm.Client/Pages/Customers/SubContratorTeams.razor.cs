using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using MudBlazor;
using Alaca.Entities.Concrete;

namespace Alaca.Crm.Client.Pages.Customers
{
    public partial class SubContratorTeams
    {
        [Parameter] public Guid CustomerId { get; set; }
        [Inject] public ISubContratorTeamService _subContratorTeamService { get; set; }
        [Inject] public ICityService _cityService { get; set; }
        SubContratorTeam[] subContratorTeams;
        City[] cities;
        protected override async Task OnInitializedAsync()
        {
            cities = (await _cityService.GetAll()).Data;
            await RefreshSubContratorTeam();
        }

        private async Task RefreshSubContratorTeam()
        {
            subContratorTeams = (await _subContratorTeamService.GetByCustomerIdSubContratorTeam(CustomerId)).Data;
        }

        protected void NewSubContrator()
        {
            ShowAddEdit(Guid.Empty);
        }
        protected void RowClick(SubContratorTeam row)
        {
            ShowAddEdit(row.SubContratorTeamId);
        }

        private async void ShowAddEdit(Guid SubContratorTeamId)
        {
            var parameters = new DialogParameters();
            if (SubContratorTeamId != Guid.Empty)
            {
                parameters.Add(nameof(AddEditSubContratorTeam.SubContratorTeamId), SubContratorTeamId);
                parameters.Add(nameof(AddEditSubContratorTeam.CustomerId), CustomerId);
            }
            var result = await _dialogService.Show<AddEditSubContratorTeam>("Taşeron", parameters, new MudBlazor.DialogOptions() { CloseButton = true, Position = MudBlazor.DialogPosition.Center }).Result;
            if (!result.Cancelled)
            {
                await RefreshSubContratorTeam();
                StateHasChanged();
            }
        }
    }
}
