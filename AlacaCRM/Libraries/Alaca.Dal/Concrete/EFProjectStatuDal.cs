using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFProjectStatuDal : EFEntityRepository<ProjectStatu, Alaca_CRMContext>, IProjectStatuDal
    {
        public EFProjectStatuDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
