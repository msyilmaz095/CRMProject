using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface ISalesOfferService : IBaseService<SalesOffer, Guid>
    {
        Task<IResultData<viewSalesOffer[]>> GetOrderDescTop10viewSalesOffers();
        Task<IResultData<viewSalesOffer[]>> GetviewSalesOffers();
        Task<IResultData<viewSalesOffer[]>> GetByProjectIdSalesOffers(Guid ProjectId);
        Task<IResult> SalesOfferInsert(SalesOffer data, List<SalesOfferLine> salesOfferLines);
        Task<IResult> SalesOfferUpdate(SalesOffer data, List<SalesOfferLine> salesOfferLines);
        Task<IResultData<viewSalesOffer[]>> GetByDateTimeBetweenviewSalesOffers(DateTime StartDate, DateTime EndDate);
    }
}
