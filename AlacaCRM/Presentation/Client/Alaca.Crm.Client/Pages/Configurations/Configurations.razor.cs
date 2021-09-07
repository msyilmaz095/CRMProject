using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Configurations
{
    public partial class Configurations
    {
        protected Blazorise.Modal modalRef;
        protected FluentValidationValidator _fluentValidationValidator;
        [Inject] IConfigurationService _configurationService { get; set; }
        protected Configuration[] ConfigurationList;
        protected Configuration configuration;
        protected override async Task OnInitializedAsync()
        {
            ConfigurationList = (await _configurationService.GetAll()).Data;
        }

        protected void New()
        {
            configuration = new Configuration();
            Show();
        }

        protected void RowClick(Configuration row)
        {
            configuration = row;
            Show();
        }
        protected async Task Delete()
        {
            var result = await _configurationService.Delete(configuration.ConfigurationCode);
            await Result(result);
        }

        protected void Show()
        {
            modalRef.Show();
        }
        protected void Close()
        {
            modalRef.Hide();
        }

        protected async Task OnValidSubmit()
        {
            IResult result = null;
            var configurationCheck = await _configurationService.GetById(configuration.ConfigurationCode);
            if (configurationCheck.Data == null)
            {
                result = await _configurationService.Insert(configuration);
            }
            else
            {
                result = await _configurationService.Update(configuration);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (!result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                ConfigurationList = (await _configurationService.GetAll()).Data;
                Close();
            }
        }
    }
}
