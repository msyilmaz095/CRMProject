using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.ExpenseCard
{
    public partial class ExpenseCards
    {
        protected Alaca.Entities.Concrete.ExpenseCard[] expenseCards;
        [Inject] protected IExpenseCardService _expenseCardService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            expenseCards = (await _expenseCardService.GetAll()).Data;
        }

        protected void NavigateToExpenseCard(Guid ExpenseCardId)
        {
            _navigationManager.NavigateTo("/AddEditExpenseCards/" + ExpenseCardId);
        }
        protected async void PopupShow(Guid ExpenseCardId)
        {
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add(nameof(AddEditExpenseCard.ExpenseCardId), ExpenseCardId);
           var popupResult= await _dialogService.Show<AddEditExpenseCard>("Masraf", dialogParameters, new MudBlazor.DialogOptions() { CloseButton=true,Position=DialogPosition.Center }).Result;
            if (!popupResult.Cancelled)
            {
                expenseCards = (await _expenseCardService.GetAll()).Data;
                StateHasChanged();
            }
        }

        protected void NewExpenseCard()
        {
            //NavigateToExpenseCard(Guid.Empty);
            PopupShow(Guid.Empty);
        }
        protected void RowClick(Alaca.Entities.Concrete.ExpenseCard expenseCard)
        {
            ///NavigateToExpenseCard(expenseCard.ExpenseCardId);
            PopupShow(expenseCard.ExpenseCardId);
        }
    }
}
