using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.SalesOffers
{
    public partial class SalesOfferStatus
    {
        Blazorise.Modal modalRef;
        [Inject] public ISalesOfferStatuService _salesOfferStatuService { get; set; }
        SalesOfferStatu salesOfferStatu = new SalesOfferStatu();
        SalesOfferStatu[] salesOfferStatus;
        protected override async Task OnInitializedAsync()
        {
            salesOfferStatus = (await _salesOfferStatuService.GetAll()).Data;
        }

        protected void NewBarcodeType()
        {
            salesOfferStatu = new SalesOfferStatu();
            modalRef.Show();
        }


        protected void RowClick(SalesOfferStatu row)
        {
            salesOfferStatu = row;
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
        protected async void Save()
        {
            IResult result = null;
            if (salesOfferStatu.SalesOfferStatuId == 0)
            {
                result = await _salesOfferStatuService.Insert(salesOfferStatu);
            }
            else
            {
                result = await _salesOfferStatuService.Update(salesOfferStatu);
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
                await Refresh();
            }
        }

        protected async void Delete()
        {
            var result = await _salesOfferStatuService.Delete((byte)salesOfferStatu.SalesOfferStatuId);
            await Result(result);
        }

        private async Task Refresh()
        {
            CloseModel();
            salesOfferStatus = (await _salesOfferStatuService.GetAll()).Data;
            StateHasChanged();
        }
    }
}
