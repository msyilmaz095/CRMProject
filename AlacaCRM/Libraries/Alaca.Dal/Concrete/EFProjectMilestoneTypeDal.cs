using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFProjectMilestoneTypeDal : EFEntityRepository<ProjectMilestoneType, Alaca_CRMContext>, IProjectMilestoneTypeDal
    {
        public EFProjectMilestoneTypeDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
