using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IStockUnitService : IBaseService<StockUnit, Guid>
    {
        Task<IResultData<StockUnit[]>> GetByStockIdStockUnit(Guid? StockId);
    }
}
