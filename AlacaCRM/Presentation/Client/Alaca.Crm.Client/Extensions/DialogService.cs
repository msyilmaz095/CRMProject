using Alaca.Crm.Client.Pages.Activities;
using Alaca.Crm.Client.Pages.SalesOffers;
using Alaca.Crm.Client.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Extensions
{
    public static class DialogExtensions
    {
        public static async Task<DialogResult> ShowDialogAlert(this IDialogService _dialogService, string Title, string Content, string icon)
        {
            var parameters = new DialogParameters();
            parameters.Add("Content", Content);
            parameters.Add("icon", icon);
            parameters.Add("color", Color.Dark.GetHashCode());
            return await _dialogService.Show<DialogAlert>(Title, parameters).Result;
        }
        public static async Task<DialogResult> ShowDialogAlert(this IDialogService _dialogService, string Title, string Content, string icon, Color color)
        {
            var parameters = new DialogParameters();
            parameters.Add("Content", Content);
            parameters.Add("icon", icon);
            parameters.Add("color", color.GetHashCode());
            return await _dialogService.Show<DialogAlert>(Title, parameters).Result;
        }
        public static async Task<DialogResult> ShowDialogAlertSuccess(this IDialogService _dialogService, string Title, string Content)
        {
            var parameters = new DialogParameters();
            parameters.Add("Content", Content);
            parameters.Add("icon", "fas fa-check");
            parameters.Add("color", Color.Success.GetHashCode());
            return await _dialogService.Show<DialogAlert>(Title, parameters).Result;
        }
        public static async Task<DialogResult> ShowDialogAlertError(this IDialogService _dialogService, string Title, string Content)
        {
            var parameters = new DialogParameters();
            parameters.Add("Content", Content);
            parameters.Add("icon", "fas fa-times");
            parameters.Add("color", Color.Error.GetHashCode());
            return await _dialogService.Show<DialogAlert>(Title, parameters).Result;
        }

        public static async Task<bool> ShowActivityPopupIsCancelled(this IDialogService _dialogService, Guid ActivityId, Guid? CustomerId, Guid? ProjectId)
        {
            var parameters = new DialogParameters();
            if (ActivityId != Guid.Empty)
                parameters.Add(nameof(ActivityPage.ActivityId), ActivityId);
            if (CustomerId != Guid.Empty)
                parameters.Add(nameof(ActivityPage.CustomerId), CustomerId);
            if (ProjectId != Guid.Empty)
                parameters.Add(nameof(ActivityPage.ProjectId), ProjectId);

            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<ActivityPage>("Aktivite", parameters, options);
            var result = await dialog.Result;
            return result.Cancelled;
        }

        public static async Task<bool> ShowSalesOfferPopupIsCancelled(this IDialogService _dialogService, Guid SallesOfferId)
        {
            var parameters = new DialogParameters();
            if (SallesOfferId != Guid.Empty)
            {
                parameters.Add(nameof(AddEditSalesOffer.SalesOfferId), SallesOfferId);
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Large, FullWidth = true, DisableBackdropClick = true, NoHeader = true };
            var dialog = _dialogService.Show<AddEditSalesOffer>("Teklif", parameters, options);
            var result = await dialog.Result;
            return result.Cancelled;
        }
    }
}
