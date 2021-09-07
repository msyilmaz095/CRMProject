using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFUserRoleDal : EFEntityRepository<UserRole, Alaca_CRMContext>, IUserRoleDal
    {
        public EFUserRoleDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
