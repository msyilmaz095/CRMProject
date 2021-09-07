using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFSalesOfferLineDal : EFEntityRepository<SalesOfferLine, Alaca_CRMContext>, ISalesOfferLineDal
    {
        public EFSalesOfferLineDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
