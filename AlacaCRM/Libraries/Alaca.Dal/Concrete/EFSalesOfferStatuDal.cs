using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFSalesOfferStatuDal : EFEntityRepository<SalesOfferStatu, Alaca_CRMContext>, ISalesOfferStatuDal
    {
        public EFSalesOfferStatuDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
