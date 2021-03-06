using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFStockBarcodeDal : EFEntityRepository<StockBarcode, Alaca_CRMContext>, IStockBarcodeDal
    {
        public EFStockBarcodeDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
