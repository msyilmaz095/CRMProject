using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFUserDepartmentPermissionDal : EFEntityRepository<UserDepartmentPermission, Alaca_CRMContext>, IUserDepartmentPermissionDal
    {
        public EFUserDepartmentPermissionDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
