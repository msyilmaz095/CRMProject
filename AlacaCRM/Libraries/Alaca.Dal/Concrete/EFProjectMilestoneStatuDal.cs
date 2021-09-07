using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFProjectMilestoneStatuDal : EFEntityRepository<ProjectMilestoneStatu, Alaca_CRMContext>, IProjectMilestoneStatuDal
    {
        public EFProjectMilestoneStatuDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
