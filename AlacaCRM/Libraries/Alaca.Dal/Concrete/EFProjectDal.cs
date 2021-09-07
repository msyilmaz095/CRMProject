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
    public class EFProjectDal : EFEntityRepository<Project, Alaca_CRMContext>, IProjectDal
    {
        public EFProjectDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        public Task<List<viewProject>> GetOrderDescTop10viewProjects()
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).OrderByDescending(p => p.ProjectDate).Take(10).ToList());
            }
        }

        public Task<List<viewProject>> GetviewProjects()
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).ToList());
            }
        }

        public Task<List<viewProject>> GetwhereviewProject(Expression<Func<viewProject, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(GetviewSalesOfferIQueryable(context).Where(Filter).ToList());
            }
        }
        private IQueryable<viewProject> GetviewSalesOfferIQueryable(Alaca_CRMContext contex)
        {
            var query = from projects in contex.Projects
                        join customer in contex.Customers on projects.CustomerId equals customer.CustomerId into projectcustomerInto
                        from projectcustomer in projectcustomerInto.DefaultIfEmpty()
                        join contact in contex.Contacts on projects.CustomerContactId equals contact.ContactId into projectcontactInto
                        from projectcontact in projectcontactInto.DefaultIfEmpty()
                        join currency in contex.Currencies on projects.CurrencyId equals currency.CurrencyId into projectcurrencyInto
                        from projectcurrency in projectcurrencyInto.DefaultIfEmpty()
                        join paymentmethod in contex.PaymentMethods on projects.PaymentMethodId equals paymentmethod.PaymentMethodId into projectpaymentmethodInto
                        from projectpaymentmethod in projectpaymentmethodInto.DefaultIfEmpty()
                        join employees in contex.Employees on projects.AssignedTo equals employees.EmployeeId into projectemployeesInto
                        from projectAssignedTo in projectemployeesInto.DefaultIfEmpty()
                        join projectstatu in contex.ProjectStatus on projects.ProjectStatuId equals projectstatu.ProjectStatuId into projectstatuInto
                        from projectstatu in projectstatuInto.DefaultIfEmpty()
                        select new viewProject()
                        {
                            AssignedTo = projects.AssignedTo,
                            CreateDate = projects.CreateDate,
                            PaymentMethodId = projects.PaymentMethodId,
                            CreateUser = projects.CreateUser,
                            CurrencyId = projects.CurrencyId,
                            CurrencyValue = projects.CurrencyValue,
                            CustomerContactId = projects.CustomerContactId,
                            CustomerId = projects.CustomerId,
                            ProjectDescription = projects.ProjectDescription,
                            ProjectTitle = projects.ProjectTitle,
                            UpdateDate = projects.UpdateDate,
                            UpdateUser = projects.UpdateUser,
                            IsActive = projects.IsActive,
                            AssignedToName = projectAssignedTo.Name + " " + projectAssignedTo.Surname,
                            CurrencyName = projectcurrency.CurrencyName,
                            CustomerContactName = projectcontact.Name + " " + projectcontact.SureName,
                            CustomerName = projectcustomer.CustomerName,
                            PaymentMethodName = projectpaymentmethod.PaymentMethodName,
                            ProjectStatuId = projects.ProjectStatuId,
                            ProjectDate = projects.ProjectDate,
                            ProjectFinishDate = projects.ProjectFinishDate,
                            ProjectNumber = projects.ProjectNumber,
                            ProjectStatuName = projectstatu.ProjectStatuName,
                            ProjectId = projects.ProjectId,
                            ProjectStartDate = projects.ProjectStartDate
                        };
            return query;
        }
    }
}
