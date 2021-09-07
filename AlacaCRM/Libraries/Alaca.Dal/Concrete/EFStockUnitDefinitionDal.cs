using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFStockUnitDefinitionDal : EFEntityRepository<StockUnitDefinition, Alaca_CRMContext>, IStockUnitDefinitionDal
    {
        public EFStockUnitDefinitionDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
