using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using System.Collections.Generic;
using Alaca.Entities.Dto;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IActivityDal : IEntityRepository<Activity>
    {
        public Task<List<viewActivity>> GetViewActivities();
        public Task<List<viewActivity>> GetWhereviewActivities(Expression<Func<viewActivity, bool>> Filter = null);
    }
}
