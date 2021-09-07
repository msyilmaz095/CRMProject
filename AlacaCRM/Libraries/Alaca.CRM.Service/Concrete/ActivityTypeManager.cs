using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ActivityTypeManager : IActivityTypeService
    {
        IActivityTypeDal _activityTypeDal;
        public ActivityTypeManager(IActivityTypeDal activityTypeDal)
        {
            _activityTypeDal = activityTypeDal;
        }
        public async Task<IResult> Add(ActivityType data)
        {
            await _activityTypeDal.Insert(data);
            return new SuccessResult("Aktivite Türü Eklendi.", data.ActivityTypeId);
        }

        public async Task<IResultData<List<ActivityType>>> GetAllList()
        {
            var data = await _activityTypeDal.GetAllList();
            return new SuccessResultData<List<ActivityType>>(data);
        }

        public async Task<IResultData<ActivityType>> GetById(Guid Id)
        {
            return new SuccessResultData<ActivityType>(await _activityTypeDal.Get(p => p.ActivityTypeId == Id));
        }

        public async Task<IResult> Remove(ActivityType data)
        {
            await _activityTypeDal.Delete(data);
            return new SuccessResult("Aktivite Türü Silindi.", data.ActivityTypeId);
        }

        public async Task<IResult> Update(ActivityType data)
        {
            await _activityTypeDal.Update(data);
            return new SuccessResult("Aktivite Türü Güncellendi.", data.ActivityTypeId);
        }
    }
}
