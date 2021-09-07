using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IActivityService : IBaseService<Activity, Guid>
    {
        Task<IResultData<viewActivity[]>> GetviewActivities();
        Task<IResultData<viewActivity[]>> GetByDateBetweenviewActivities(DateTime StartDate, DateTime FinishDate, Guid AssignedToEmployee);
        Task<IResultData<viewActivity[]>> GetByCustomerIdviewActivities(Guid? id);
        Task<IResultData<viewActivity[]>> GetByProjectIdviewActivities(Guid? ProjectId);
    }
}
