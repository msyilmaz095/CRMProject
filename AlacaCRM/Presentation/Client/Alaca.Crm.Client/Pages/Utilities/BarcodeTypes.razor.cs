using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Utilities
{
    public partial class BarcodeTypes
    {
        Blazorise.Modal modalRef;
        private FluentValidationValidator _fluentValidationValidator;
        [Inject] public IBarcodeTypeService _barcodeTypeService { get; set; }
        BarcodeType barcodeType = new BarcodeType();
        BarcodeType[] barcodeTypes;
        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        private async Task GetAll()
        {
            barcodeTypes = (await _barcodeTypeService.GetAll()).Data;
        }

        protected void NewBarcodeType()
        {
            barcodeType = new BarcodeType();
            modalRef.Show();
        }


        protected void RowClick(BarcodeType row)
        {
            barcodeType = row;
            ShowModel();
        }

        protected void ShowModel()
        {
            modalRef.Show();
        }
        protected void CloseModel()
        {
            modalRef.Hide();
        }
        protected async Task Save()
        {
            IResult result = null;
            if (barcodeType.BarcodeTypeId == 0)
            {
                result = await _barcodeTypeService.Insert(barcodeType);
            }
            else
            {
                result = await _barcodeTypeService.Update(barcodeType);
            }
            await Result(result);
        }

        protected async Task Delete()
        {
            var result = await _barcodeTypeService.Delete(barcodeType.BarcodeTypeId);
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
                modalRef.Hide();
                await GetAll();
            }
        }
    }
}
