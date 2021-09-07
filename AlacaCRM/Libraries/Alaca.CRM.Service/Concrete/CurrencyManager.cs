using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class CurrencyManager : ICurrencyService
    {
        ICurrencyDal _currencyDal;
        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
        public async Task<IResult> Add(Currency data)
        {
            await _currencyDal.Insert(data);
            return new SuccessResult("Para Birimi Eklendi.");
        }

        public async Task<IResultData<List<Currency>>> GetAllList()
        {
            var data = await _currencyDal.GetAllList();
            return new SuccessResultData<List<Currency>>(data);
        }

        public async Task<IResultData<Currency>> GetById(Guid Id)
        {
            return new SuccessResultData<Currency>(await _currencyDal.Get(p => p.CurrencyId == Id));
        }

        public async Task<IResult> Remove(Currency data)
        {
            await _currencyDal.Delete(data);
            return new SuccessResult("Para Birimi Silindi.");
        }

        public async Task<IResult> Update(Currency data)
        {
            await _currencyDal.Update(data);
            return new SuccessResult("Para Birimi Güncellendi.");
        }
    }
}
