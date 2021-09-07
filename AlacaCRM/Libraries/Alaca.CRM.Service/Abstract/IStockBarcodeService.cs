using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IStockBarcodeService : IBaseService<StockBarcode, Guid>
    {
        Task<IResultData<List<StockBarcode>>> GetByStockIdStockBarcode(Guid? StockId);
    }
}
