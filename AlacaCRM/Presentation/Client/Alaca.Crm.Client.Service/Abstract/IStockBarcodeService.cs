using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IStockBarcodeService : IBaseService<StockBarcode, Guid>
    {
        Task<IResultData<StockBarcode[]>> GetByStockIdStockBarcode(Guid? StockId);
    }
}
