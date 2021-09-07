using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Aop.Autofac;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Validations.FluentValidation;

namespace Alaca.CRM.Service.Concrete
{
    public class StockStatuManager : IStockStatuService
    {
        IStockStatuDal _stockStatuDal;
        public StockStatuManager(IStockStatuDal stockStatuDal)
        {
            _stockStatuDal = stockStatuDal;
        }

        [Validation(typeof(StockStatuValidator))]
        public async Task<IResult> Add(StockStatu data)
        {
            await _stockStatuDal.Insert(data);
            return new SuccessResult("Stok Durum Eklendi.", data.StockStatuId);
        }

        public async Task<IResultData<List<StockStatu>>> GetAllList()
        {
            var data = await _stockStatuDal.GetAllList();
            return new SuccessResultData<List<StockStatu>>(data);
        }

        public async Task<IResultData<StockStatu>> GetById(Guid Id)
        {
            return new SuccessResultData<StockStatu>(await _stockStatuDal.Get(p => p.StockStatuId == Id));
        }

        public async Task<IResult> Remove(StockStatu data)
        {
            await _stockStatuDal.Delete(data);
            return new SuccessResult("Stok Durum Silindi.", data.StockStatuId);
        }

        public async Task<IResult> Update(StockStatu data)
        {
            await _stockStatuDal.Update(data);
            return new SuccessResult("Stok Durum Güncellendi.", data.StockStatuId);
        }
    }
}
