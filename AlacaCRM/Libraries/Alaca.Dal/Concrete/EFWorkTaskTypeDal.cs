using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFWorkTaskTypeDal : EFEntityRepository<WorkTaskType, Alaca_CRMContext>, IWorkTaskTypeDal
    {
        public EFWorkTaskTypeDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
