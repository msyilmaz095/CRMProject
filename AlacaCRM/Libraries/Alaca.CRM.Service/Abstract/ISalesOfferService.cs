using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface ISalesOfferService : IBaseService<SalesOffer, Guid>
    {
        Task<IResultData<List<viewSalesOffer>>> GetOrderDescTop10viewSalesOffers();
        Task<IResultData<List<viewSalesOffer>>> GetviewSalesOffers();
        Task<IResultData<List<viewSalesOffer>>> GetByDateBetweenviewSalesOffers(DateTime StartDate, DateTime EndDate);
        Task<IResultData<List<viewSalesOffer>>> GetByProjectIdSalesOffers(Guid ProjectId);
        Task<IResult> AddSalesOffer(SalesOffer data, List<SalesOfferLine> salesOfferLines);
        Task<IResult> UpdateSalesOffer(SalesOffer data, List<SalesOfferLine> salesOfferLines);
    }
}
