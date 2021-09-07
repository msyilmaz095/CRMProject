using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFActivityTypeDal : EFEntityRepository<ActivityType, Alaca_CRMContext>, IActivityTypeDal
    {
        public EFActivityTypeDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        //public override Task<List<ActivityType>> GetAllList()
        //{
        //    from activiteType in _context.ActivityTypes
        //    join createuser in _context.Users on activiteType.CreateUser equals createuser.UserId
        //    join updateuser in _context.Users on activiteType.UpdateUser equals updateuser.UserId
        //    select new ActivityType { ActivityTypeId=activiteType.ActivityTypeId,
        //    ActivityTypeName=activiteType.ActivityTypeName,
        //    CreateDate=activiteType.CreateDate,
        //    CreateUser=activiteType.CreateUser,
        //    IsActive=activiteType.IsActive,
        //    }
        //    return base.GetAllList();
        //}
    }
}
