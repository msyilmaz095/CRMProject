using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Concrete
{
    public class SalesOfferLineManager : ISalesOfferLineService
    {
        ISalesOfferLineDal _salesOfferLineDal;
        public SalesOfferLineManager(ISalesOfferLineDal salesOfferLineDal)
        {
            _salesOfferLineDal = salesOfferLineDal;
        }
        public async Task<IResult> Add(SalesOfferLine data)
        {
            await _salesOfferLineDal.Insert(data);
            return new SuccessResult(data.SaleOfferLineId);
        }

        public async Task<IResultData<List<SalesOfferLine>>> GetAllList()
        {
            return new SuccessResultData<List<SalesOfferLine>>(await _salesOfferLineDal.GetAllList());
        }

        public async Task<IResultData<SalesOfferLine>> GetById(Guid Id)
        {
            return new SuccessResultData<SalesOfferLine>(await _salesOfferLineDal.Get(p => p.SaleOfferLineId == Id));
        }
        public async Task<IResultData<List<SalesOfferLine>>> GetBySalesOfferIdLines(Guid SaleOfferId)
        {
            return new SuccessResultData<List<SalesOfferLine>>(await _salesOfferLineDal.GetWhere(p => p.SaleOfferId == SaleOfferId));
        }

        public async Task<IResult> Remove(SalesOfferLine data)
        {
            await _salesOfferLineDal.Delete(data);
            return new SuccessResult(data.SaleOfferLineId);
        }

        public async Task<IResult> Update(SalesOfferLine data)
        {
            await _salesOfferLineDal.Update(data);
            return new SuccessResult(data.SaleOfferLineId);
        }
    }
}