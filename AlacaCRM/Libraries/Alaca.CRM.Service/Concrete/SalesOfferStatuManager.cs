using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.Crm.Dal.Concrete;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Concrete
{
    public class SalesOfferStatuManager : ISalesOfferStatuService
    {
        ISalesOfferStatuDal _salesOfferStatuDal;
        public SalesOfferStatuManager(ISalesOfferStatuDal salesOfferStatuDal)
        {
            _salesOfferStatuDal = salesOfferStatuDal;
        }
        public async Task<IResult> Add(SalesOfferStatu data)
        {
            await _salesOfferStatuDal.Insert(data);
            return new SuccessResult(data.SalesOfferStatuId);
        }

        public async Task<IResultData<List<SalesOfferStatu>>> GetAllList()
        {
            return new SuccessResultData<List<SalesOfferStatu>>(await _salesOfferStatuDal.GetAllList());
        }

        public async Task<IResultData<SalesOfferStatu>> GetById(byte Id)
        {
            return new SuccessResultData<SalesOfferStatu>(await _salesOfferStatuDal.Get(p=>p.SalesOfferStatuId==Id));
        }

        public async Task<IResult> Remove(SalesOfferStatu data)
        {
            await _salesOfferStatuDal.Delete(data);
            return new SuccessResult(data.SalesOfferStatuId);
        }

        public async Task<IResult> Update(SalesOfferStatu data)
        {
            await _salesOfferStatuDal.Update(data);
            return new SuccessResult(data.SalesOfferStatuId);
        }
    }
}