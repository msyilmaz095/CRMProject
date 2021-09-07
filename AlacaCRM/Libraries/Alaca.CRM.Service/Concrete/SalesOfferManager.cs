using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Alaca.CRM.Service.Concrete
{
    public class SalesOfferManager : ISalesOfferService
    {
        ISalesOfferDal _salesOfferDal;
        ISalesOfferLineService _salesOfferLineService;
        public SalesOfferManager(ISalesOfferDal salesOfferDal, ISalesOfferLineService salesOfferLineService)
        {
            _salesOfferLineService = salesOfferLineService;
            _salesOfferDal = salesOfferDal;
        }
        public async Task<IResult> Add(SalesOffer data)
        {
            await _salesOfferDal.Insert(data);
            return new SuccessResult(data.SalesOfferId);
        }

        public async Task<IResult> AddSalesOffer(SalesOffer data, List<SalesOfferLine> salesOfferLines)
        {
            var check = SalesOfferCheck(salesOfferLines);
            if (!check.Success)
            {
                return check;
            }
            data.SalesOfferTotal = salesOfferLines.Sum(p => p.Price * p.Amount);
            await _salesOfferDal.Insert(data);
            await SaveSalesOfferLine(data, salesOfferLines);
            return new SuccessResult("Teklif Kaydı Başarılı.", data.SalesOfferId);
        }

        public IResult SalesOfferCheck(List<SalesOfferLine> salesOfferLines)
        {
            if (salesOfferLines == null || salesOfferLines.Count == 0)
            {
                return new FailedResult("Teklif için satır girilmediğinden kayıt işlemi başarısız!");
            }
            return new SuccessResult();
        }

        private async Task SaveSalesOfferLine(SalesOffer data, List<SalesOfferLine> salesOfferLines)
        {
            foreach (var item in salesOfferLines)
            {
                item.Total = item.Price * item.Amount;
                switch (item.CRUDOperation)
                {
                    case 1:
                        item.SaleOfferId = data.SalesOfferId;
                        await _salesOfferLineService.Add(item);
                        break;
                    case 2:
                        await _salesOfferLineService.Update(item);
                        break;
                    case 3:
                        await _salesOfferLineService.Update(item);
                        break;
                    case 4:
                        await _salesOfferLineService.Remove(item);
                        break;
                    default:
                        break;
                }
            }
        }

        public async Task<IResultData<List<SalesOffer>>> GetAllList()
        {
            return new SuccessResultData<List<SalesOffer>>(await _salesOfferDal.GetAllList());
        }

        public async Task<IResultData<SalesOffer>> GetById(Guid Id)
        {
            return new SuccessResultData<SalesOffer>(await _salesOfferDal.Get(p => p.SalesOfferId == Id));
        }

        public async Task<IResultData<List<viewSalesOffer>>> GetviewSalesOffers()
        {
            return new SuccessResultData<List<viewSalesOffer>>(await _salesOfferDal.GetviewSalesOffers());
        }

        public async Task<IResult> Remove(SalesOffer data)
        {
            await _salesOfferDal.Delete(data);
            return new SuccessResult("Teklif Kaydı Silindi.", data.SalesOfferId);
        }

        public async Task<IResult> Update(SalesOffer data)
        {
            await _salesOfferDal.Update(data);
            return new SuccessResult(data.SalesOfferId);
        }

        public async Task<IResult> UpdateSalesOffer(SalesOffer data, List<SalesOfferLine> salesOfferLines)
        {
            var check = SalesOfferCheck(salesOfferLines);
            if (!check.Success)
            {
                return check;
            }
            data.SalesOfferTotal = salesOfferLines.Sum(p => p.Price * p.Amount);
            await _salesOfferDal.Update(data);
            await SaveSalesOfferLine(data, salesOfferLines);
            return new SuccessResult("Teklif Kaydı Güncellendi.", data.SalesOfferId);
        }

        public async Task<IResultData<List<viewSalesOffer>>> GetByProjectIdSalesOffers(Guid ProjectId)
        {
            return new SuccessResultData<List<viewSalesOffer>>(await _salesOfferDal.GetwhereviewSalesOffer(p => p.ProjectId == ProjectId));
        }

        public async Task<IResultData<List<viewSalesOffer>>> GetByDateBetweenviewSalesOffers(DateTime StartDate, DateTime EndDate)
        {
            return new SuccessResultData<List<viewSalesOffer>>(await _salesOfferDal.GetwhereviewSalesOffer(p => p.SalesOfferDate >= StartDate && p.SalesOfferDate <= EndDate));
        }

        public async Task<IResultData<List<viewSalesOffer>>> GetOrderDescTop10viewSalesOffers()
        {
            return new SuccessResultData<List<viewSalesOffer>>(await _salesOfferDal.GetOrderDescTop10viewSalesOffers());
        }
    }
}