using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Aop.Autofac;
using Alaca.Core.Utilities.Extension;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Alaca.Validations.FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Alaca.CRM.Service.Concrete
{
    public class ActivityManager : IActivityService
    {
        IActivityDal _activityDal;
        IHttpContextAccessor _httpContextAccessor;
        public ActivityManager(IActivityDal activityDal, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _activityDal = activityDal;
        }

        [Validation(typeof(ActivityValitador))]
        public async Task<IResult> Add(Activity data)
        {
            data.AssignedTo = _httpContextAccessor.GetClaimNameIdentifier();
            await _activityDal.Insert(data);
            return new SuccessResult("Aktivite Eklendi.", data.ActivityId);
        }

        public async Task<IResultData<List<Activity>>> GetAllList()
        {
            var data = await _activityDal.GetAllList();
            return new SuccessResultData<List<Activity>>(data);
        }

        public async Task<IResultData<List<viewActivity>>> GetByCustomerIdviewActivities(Guid CustomerId)
        {
            var data = await _activityDal.GetWhereviewActivities(p => p.CustomerId == CustomerId);
            return new SuccessResultData<List<viewActivity>>(data);
        }

        public async Task<IResultData<List<viewActivity>>> GetByDateBetweenviewActivities(DateTime StartDate, DateTime FinishDate, Guid AssignedToEmployee)
        {
            var data = await _activityDal.GetWhereviewActivities(p => p.StartDate >= StartDate && p.StartDate <= FinishDate
            && (p.AssignedTo == AssignedToEmployee || p.EmployeeId == AssignedToEmployee || AssignedToEmployee == Guid.Empty));
            return new SuccessResultData<List<viewActivity>>(data);
        }

        public async Task<IResultData<Activity>> GetById(Guid Id)
        {
            return new SuccessResultData<Activity>(await _activityDal.Get(p => p.ActivityId == Id));
        }

        public async Task<IResultData<List<viewActivity>>> GetByProjectIdviewActivities(Guid ProjectId)
        {
            var data = await _activityDal.GetWhereviewActivities(p => p.ProjectId == ProjectId);
            return new SuccessResultData<List<viewActivity>>(data);
        }

        public async Task<IResultData<List<viewActivity>>> GetviewActivities()
        {
            var data = await _activityDal.GetViewActivities();
            return new SuccessResultData<List<viewActivity>>(data);
        }

        public async Task<IResult> Remove(Activity data)
        {
            await _activityDal.Delete(data);
            return new SuccessResult("Aktivite Silindi.", data.ActivityId);
        }

        [Validation(typeof(ActivityValitador))]
        public async Task<IResult> Update(Activity data)
        {
            await _activityDal.Update(data);
            return new SuccessResult("Aktivite Güncellendi.", data.ActivityId);
        }
    }
}
