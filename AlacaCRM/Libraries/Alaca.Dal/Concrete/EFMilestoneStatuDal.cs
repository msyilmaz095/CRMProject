using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFMilestoneStatuDal : EFEntityRepository<MilestoneStatu, Alaca_CRMContext>, IMilestoneStatuDal
    {
        public EFMilestoneStatuDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
