using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using AnyClone.Extensions;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.SalesOffers
{
    public partial class AddEditSalesOffer
    {
        protected Blazorise.Modal modalRef;
        [Inject] public IProjectService _projectService { get; set; }
        [Inject] public ISalesOfferService _salesOfferService { get; set; }
        [Inject] public ISalesOfferLineService _salesOfferLineService { get; set; }
        [Inject] public ICustomerService _customerService { get; set; }
        [Inject] public IContactService _contactService { get; set; }
        [Inject] public IEmployeeService _employeeService { get; set; }
        [Inject] public ICurrencyService _currencyService { get; set; }
        [Inject] public IPaymentMethodService _paymentMethodService { get; set; }
        [Inject] public ISalesOfferStatuService _salesOfferStatuService { get; set; }
        [Inject] public IStockService _stockService { get; set; }
        [Inject] public IStockUnitService _stockUnitService { get; set; }
        [Inject] public IExpenseCardService _expenseCardService { get; set; }
        [Inject] public IServiceCardService _serviceCardService { get; set; }
        [Parameter] public Guid SalesOfferId { get; set; }
        SalesOffer salesOffer = new SalesOffer();
        SalesOfferLine salesOfferLine = new SalesOfferLine() { LineType = 1 };
        List<SalesOfferLine> salesOfferLines = new List<SalesOfferLine>();
        Entities.Concrete.ExpenseCard[] expenseCards;
        Entities.Concrete.ServiceCard[] serviceCards;
        public double GetDiscountTotal
        {
            get
            {
                return salesOfferLine.DiscountAmount + ((salesOfferLine.Amount * salesOfferLine.Price * salesOfferLine.DiscountRate) / 100);
            }
        }
        public List<SalesOfferLine> GetSalesOfferLines
        {
            get
            {
                var lst = salesOfferLines.Where(p => p.CRUDOperation < 4).ToList();
                return lst;
            }
        }
        [CascadingParameter] private MudDialogInstance mudDialog { get; set; }
        Customer[] customers;
        Employee[] employees;
        Stock[] stocks;
        Currency[] currencies;
        SalesOfferStatu[] salesOfferStatus;
        StockUnit[] stockUnits;
        PaymentMethod[] paymentMethods;
        Contact[] contacts;
        Project[] projects;
        protected override async Task OnInitializedAsync()
        {
            expenseCards = (await _expenseCardService.GetAll()).Data;
            serviceCards = (await _serviceCardService.GetAll()).Data;
            salesOfferStatus = (await _salesOfferStatuService.GetAll()).Data;
            stocks = (await _stockService.GetAll()).Data;
            paymentMethods = (await _paymentMethodService.GetAll()).Data;
            currencies = (await _currencyService.GetAll()).Data;
            customers = (await _customerService.GetAll()).Data;
            employees = (await _employeeService.GetAll()).Data;
            contacts = (await _contactService.GetAll()).Data;
            if (SalesOfferId != Guid.Empty)
            {
                salesOffer = (await _salesOfferService.GetById(SalesOfferId)).Data;
                salesOfferLines = (await _salesOfferLineService.GetBySalesOfferIdLines(SalesOfferId)).Data.ToList();
                await GetCustomerContact(salesOffer.CustomerId);
                await GetByCustomerIdProject(salesOffer.CustomerId);
            }
        }

        protected void RowClick(SalesOfferLine row)
        {
            salesOfferLine = row.Clone() as SalesOfferLine;
            modalRef.Show();
        }

        protected void NewLine()
        {
            salesOfferLine = new SalesOfferLine() { LineType = 1 };
            salesOfferLine.CurrencyId = salesOffer.CurrencyId;
            modalRef.Show();
        }

        protected async void OnValidSubmit()
        {
            IResult result;
            if (salesOffer.SalesOfferId == Guid.Empty)
                result = await _salesOfferService.SalesOfferInsert(salesOffer, salesOfferLines);
            else
                result = await _salesOfferService.SalesOfferUpdate(salesOffer, salesOfferLines);
            SalesOfferResult(result);
        }

        private void SalesOfferResult(IResult result)
        {
            if (result.Success)
            {
                _snackBar.Add(result.Message, Severity.Success);
                Close();
            }
            else
            {
                _snackBar.Add(result.Message, Severity.Error);
            }
        }

        private void Close()
        {
            if (mudDialog != null)
                mudDialog.Close();
            else
                _navigationManager.NavigateTo("/SalesOffers");
        }

        protected async void Delete()
        {
            SalesOfferResult(await _salesOfferService.Delete(salesOffer.SalesOfferId));
        }

        protected void Cancel()
        {
            if (mudDialog != null)
                mudDialog.Cancel();
            else
                _navigationManager.NavigateTo("/SalesOffers");
        }

        protected async Task<IEnumerable<Guid>> SearchCustomer(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
                return customers.Select(col => col.CustomerId);
            var lst = customers.Where(x => x.CustomerName.Contains(value)).Select(col => col.CustomerId);
            return lst;
        }

        protected async Task GetCustomerContact(Guid CustomerId)
        {
            contacts = (await _contactService.GetContactByCustomerIdAll(CustomerId)).Data.ToArray();
        }
        protected async Task GetByCustomerIdProject(Guid CustomerId)
        {
            projects = (await _projectService.GetByCustomerIdProject(CustomerId)).Data.ToArray();
        }

        protected string ToStringFuncCustomer(Guid CustomerId)
        {
            if (CustomerId == Guid.Empty)
            {
                return "";
            }
            return customers.FirstOrDefault(p => p.CustomerId == CustomerId).CustomerName;
        }
        protected async void CustomerOnValueChange(Guid CustomerId)
        {
            salesOffer.CustomerId = CustomerId;
            await GetCustomerContact(CustomerId);
            await GetByCustomerIdProject(CustomerId);
        }

        protected string ToStringFuncStock(Guid? id)
        {
            GetStockUnits(id);
            return stocks.FirstOrDefault(p => p.StockId == id).StockName;
        }

        protected async void GetStockUnits(Guid? id)
        {
            stockUnits = (await _stockUnitService.GetByStockIdStockUnit(id)).Data;
        }

        protected async Task<IEnumerable<Guid?>> SearchStock(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new Guid?[0];
            var lst = stocks.Where(x => x.StockName.Contains(value)).Select(col => (Guid?)col.StockId);
            return lst;
        }

        protected void OnValidSubmitLine()
        {
            salesOfferLine.Total = salesOfferLine.Price * salesOfferLine.Amount;
            salesOfferLine.DiscountTotal = GetDiscountTotal;
            if (salesOfferLine.SaleOfferLineId == Guid.Empty)
            {
                salesOfferLine.CRUDOperation = 1;
                salesOfferLine.SaleOfferLineId = Guid.NewGuid();
                salesOfferLines.Add(salesOfferLine);
            }
            else
            {
                salesOfferLines.Remove(salesOfferLines.FirstOrDefault(p => p.SaleOfferLineId == salesOfferLine.SaleOfferLineId));
                salesOfferLines.Add(salesOfferLine);
            }
            modalRef.Hide();
        }

        protected void DeleteLine()
        {
            salesOfferLines.FirstOrDefault(p => p.SaleOfferLineId == salesOfferLine.SaleOfferLineId).CRUDOperation = 4;
            modalRef.Hide();
        }

        protected async void ReviseOffer()
        {
            var copySalesOffer = (SalesOffer)salesOffer.Clone();
            copySalesOffer.SalesOfferId = Guid.Empty;
            copySalesOffer.ReviseNumber++;
            copySalesOffer.IsSelectedOffer = true;
            copySalesOffer.IsActive = true;
            var copySalesOfferLine = salesOfferLines.Clone();
            copySalesOfferLine.ForEach(p => p.CRUDOperation = 1);
            copySalesOfferLine.ForEach(p => p.SaleOfferLineId = Guid.Empty);
            var result = await _salesOfferService.SalesOfferInsert(copySalesOffer, copySalesOfferLine);
            _navigationManager.NavigateTo("/AddEditSalesOffer?OfferId=" + result.RecordId);
        }

        protected void CopyOffer()
        {

        }
    }
}
