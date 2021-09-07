using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFSubContratorTeamDal : EFEntityRepository<SubContratorTeam, Alaca_CRMContext>, ISubContratorTeamDal
    {
        public EFSubContratorTeamDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
