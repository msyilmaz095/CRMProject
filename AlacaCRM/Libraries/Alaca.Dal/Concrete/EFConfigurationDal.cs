using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFConfigurationDal : EFEntityRepository<Configuration, Alaca_CRMContext>, IConfigurationDal
    {
        public EFConfigurationDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
