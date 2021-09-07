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
    public class EFActivityDal : EFEntityRepository<Activity, Alaca_CRMContext>, IActivityDal
    {
        public EFActivityDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public Task<List<viewActivity>> GetWhereviewActivities(Expression<Func<viewActivity, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                List<viewActivity> query = GetviewActivityIQueryable(context).Where(Filter).ToList();
                return Task.FromResult(query);
            }
        }

        public Task<List<viewActivity>> GetViewActivities()
        {
            using (var context = new Alaca_CRMContext())
            {
                var query = GetviewActivityIQueryable(context).ToList();
                return Task.FromResult(query);
            }
        }
        private IQueryable<viewActivity> GetviewActivityIQueryable(Alaca_CRMContext db)
        {
            return (from activity in db.Activities
                    join employee in db.Employees on activity.EmployeeId equals employee.EmployeeId into ActivityEmployeeGroup
                    from ActivityEmployee in ActivityEmployeeGroup.DefaultIfEmpty()
                    join customer in db.Customers on activity.CustomerId equals customer.CustomerId into ActivityCustomerGroup
                    from ActivityCustomer in ActivityCustomerGroup.DefaultIfEmpty()
                    join activityType in db.ActivityTypes on activity.ActivityTypeId equals activityType.ActivityTypeId into ActivityTypeGroup
                    from ActivityType in ActivityTypeGroup.DefaultIfEmpty()
                    join contact in db.Contacts on activity.ContactId equals contact.ContactId into ActivityContactGroup
                    from ActivityContact in ActivityContactGroup.DefaultIfEmpty()
                    join createUser in db.Users on activity.CreateUser equals createUser.UserId into createUserGroup
                    from ActivityCreateUser in createUserGroup.DefaultIfEmpty()
                    join updateUser in db.Users on activity.UpdateUser equals updateUser.UserId into UpdateUserGroup
                    from ActivityUpdateUser in UpdateUserGroup.DefaultIfEmpty()
                    join project in db.Projects on activity.ProjectId equals project.ProjectId into activityProject
                    from ActivityProject in activityProject.DefaultIfEmpty()
                    select new viewActivity()
                    {
                        ContactId = activity.ContactId,
                        ContactName = ActivityContact.Name + " " + ActivityContact.SureName,
                        ActivityTypeId = activity.ActivityTypeId,
                        ActivityTypeName = ActivityType.ActivityTypeName,
                        ActivityId = activity.ActivityId,
                        CreateDate = activity.CreateDate,
                        CreateUser = activity.CreateUser,
                        CustomerId = activity.CustomerId,
                        CustomerName = ActivityCustomer.CustomerName,
                        EmployeeId = activity.EmployeeId,
                        Explanation = activity.Explanation,
                        FinishDate = activity.FinishDate,
                        Location = activity.Location,
                        NextActivityDate = activity.NextActivityDate,
                        EmployeeName = ActivityEmployee.Name + " " + ActivityEmployee.Surname,
                        ProjectId = activity.ProjectId,
                        ProjectName = ActivityProject.ProjectTitle,
                        StartDate = activity.StartDate,
                        UpdateDate = activity.UpdateDate,
                        UpdateUser = activity.UpdateUser,
                        AssignedTo = activity.AssignedTo,
                        CreateUserName = ActivityCreateUser.UserName,
                        UpdateUserName = ActivityUpdateUser.UserName,
                        Subject = activity.Subject,
                        ActivityDate=activity.ActivityDate
                    });
        }
    }
}
