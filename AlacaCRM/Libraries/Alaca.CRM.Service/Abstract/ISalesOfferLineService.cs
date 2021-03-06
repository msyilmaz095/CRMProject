using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface ISalesOfferLineService : IBaseService<SalesOfferLine, Guid>
    {
        Task<IResultData<List<SalesOfferLine>>> GetBySalesOfferIdLines(Guid SaleOfferId);
    }
}
