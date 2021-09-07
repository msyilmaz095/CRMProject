using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.ExpenseCard
{
    public partial class AddEditExpenseCard
    {
        [CascadingParameter] public MudDialogInstance _mudDialog { get; set; }
        [Parameter] public Guid ExpenseCardId { get; set; }
        private FluentValidationValidator _fluentValidationValidator;

        public Entities.Concrete.ExpenseCard expenseCard { get; set; } = new();
        [Inject] public IExpenseCardService _expenseCardService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (ExpenseCardId != Guid.Empty)
            {
                expenseCard = (await _expenseCardService.GetById(ExpenseCardId)).Data;
            }
        }

        public async void OnValidSubmit()
        {
            IResult result = null;
            if (ExpenseCardId == Guid.Empty)
            {
                result = await _expenseCardService.Insert(expenseCard);
            }
            else
            {
                result = await _expenseCardService.Update(expenseCard);
            }
            ResultChechk(result);
        }

        private void ResultChechk(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
                if (_mudDialog == null)
                {
                    _navigationManager.NavigateTo("/ExpenseCards");
                }
                else
                {
                    _mudDialog.Close();
                }
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        public async void Delete()
        {
            ResultChechk(await _expenseCardService.Delete(expenseCard.ExpenseCardId));
        }
        public async void Cancel()
        {
            if (_mudDialog == null)
            {
                _navigationManager.NavigateTo("/ExpenseCards");
            }
            else
            {
                _mudDialog.Cancel();
            }
        }
    }
}
