using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface ISalesOfferLineService : IBaseService<SalesOfferLine, Guid>
    {
        Task<IResultData<SalesOfferLine[]>> GetBySalesOfferIdLines(Guid SalesOfferId);
    }
}
