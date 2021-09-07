using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFSalesOfferDal : EFEntityRepository<SalesOffer, Alaca_CRMContext>, ISalesOfferDal
    {
        public EFSalesOfferDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        public Task<List<viewSalesOffer>> GetOrderDescTop10viewSalesOffers()
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).OrderByDescending(p=>p.SalesOfferDate).Take(10).ToList());
            }
        }

        public Task<List<viewSalesOffer>> GetviewSalesOffers()
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).ToList());
            }
        }

        public Task<List<viewSalesOffer>> GetwhereviewSalesOffer(Expression<Func<viewSalesOffer, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).Where(Filter).ToList());
            }
        }
        private IQueryable<viewSalesOffer> GetviewSalesOfferIQueryable(Alaca_CRMContext contex)
        {
            var query = from salesoffer in contex.SalesOffers
                        join customer in contex.Customers on salesoffer.CustomerId equals customer.CustomerId into offercustomerInto
                        from offercustomer in offercustomerInto.DefaultIfEmpty()
                        join contact in contex.Contacts on salesoffer.CustomerContactId equals contact.ContactId into offercontactInto
                        from offercontact in offercontactInto.DefaultIfEmpty()
                        join currency in contex.Currencies on salesoffer.CurrencyId equals currency.CurrencyId into offercurrencyInto
                        from offercurrency in offercurrencyInto.DefaultIfEmpty()
                        join paymentmethod in contex.PaymentMethods on salesoffer.PaymentMethodId equals paymentmethod.PaymentMethodId into offerpaymentmethodInto
                        from offerpaymentmethod in offerpaymentmethodInto.DefaultIfEmpty()
                        join employees in contex.Employees on salesoffer.AssignedTo equals employees.EmployeeId into offeremployeesInto
                        from offerAssignedTo in offeremployeesInto.DefaultIfEmpty()
                        select new viewSalesOffer()
                        {
                            AssignedTo = salesoffer.AssignedTo,
                            CreateDate = salesoffer.CreateDate,
                            PaymentMethodId = salesoffer.PaymentMethodId,
                            CreateUser = salesoffer.CreateUser,
                            CurrencyId = salesoffer.CurrencyId,
                            CurrencyValue = salesoffer.CurrencyValue,
                            CustomerContactId = salesoffer.CustomerContactId,
                            CustomerId = salesoffer.CustomerId,
                            Description = salesoffer.Description,
                            UpdateDate = salesoffer.UpdateDate,
                            UpdateUser = salesoffer.UpdateUser,
                            IsActive = salesoffer.IsActive,
                            ProjectId = salesoffer.ProjectId,
                            IsSelectedOffer = salesoffer.IsSelectedOffer,
                            SalesOfferId = salesoffer.SalesOfferId,
                            SalesOfferTotal = salesoffer.SalesOfferTotal,
                            SalesOfferTaxTotal = salesoffer.SalesOfferTaxTotal,
                            SalesOfferStatuId = salesoffer.SalesOfferStatuId,
                            SalesOfferNumber = salesoffer.SalesOfferNumber,
                            SalesOfferDate = salesoffer.SalesOfferDate,
                            SalesOfferFinishDate = salesoffer.SalesOfferFinishDate,
                            AssignedToName = offerAssignedTo.Name + " " + offerAssignedTo.Surname,
                            CurrencyName = offercurrency.CurrencyName,
                            CustomerContactName = offercontact.Name + " " + offercontact.SureName,
                            CustomerName = offercustomer.CustomerName,
                            PaymentMethodName = offerpaymentmethod.PaymentMethodName
                        };
            return query;
        }
    }
}
