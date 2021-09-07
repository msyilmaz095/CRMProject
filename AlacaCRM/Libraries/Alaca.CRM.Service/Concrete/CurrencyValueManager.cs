using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;

namespace Alaca.CRM.Service.Concrete
{
    public class CurrencyValueManager : ICurrencyValueService
    {
        ICurrencyValueDal _currencyValueDal;
        public CurrencyValueManager(ICurrencyValueDal currencyValueDal)
        {
            _currencyValueDal = currencyValueDal;
        }
        public async Task<IResult> Add(CurrencyValue data)
        {
            await _currencyValueDal.Insert(data);
            return new SuccessResult("Kur Eklendi.");
        }

        public async Task<IResultData<List<CurrencyValue>>> GetAllList()
        {
            var data = await _currencyValueDal.GetAllList();
            return new SuccessResultData<List<CurrencyValue>>(data);
        }

        public async Task<IResultData<CurrencyValue>> GetById(Guid Id)
        {
            return new SuccessResultData<CurrencyValue>(await _currencyValueDal.Get(p => p.CurrencyValuesId == Id));
        }

        public async Task<IResultData<List<viewCurrencyValue>>> GetviewCurrencyValue()
        {
            return new SuccessResultData<List<viewCurrencyValue>>(await _currencyValueDal.GetviewCurrencyValue());
        }

        public async Task<IResult> Remove(CurrencyValue data)
        {
            await _currencyValueDal.Delete(data);
            return new SuccessResult("Kur Silindi.");
        }

        public async Task<IResult> Update(CurrencyValue data)
        {
            await _currencyValueDal.Update(data);
            return new SuccessResult("Kur Güncellendi.");
        }
    }
}
