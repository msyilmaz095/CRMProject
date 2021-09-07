using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IActivityService : IBaseService<Activity, Guid>
    {
        public Task<IResultData<List<viewActivity>>> GetviewActivities();
        public Task<IResultData<List<viewActivity>>> GetByDateBetweenviewActivities(DateTime StartDate, DateTime FinishDate, Guid AssignedToEmployee);
        public Task<IResultData<List<viewActivity>>> GetByCustomerIdviewActivities(Guid CustomerId);
        public Task<IResultData<List<viewActivity>>> GetByProjectIdviewActivities(Guid ProjectId);
    }
}
