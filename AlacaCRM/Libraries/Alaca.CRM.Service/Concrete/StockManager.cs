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
    public class StockManager : IStockService
    {
        IStockDal _stockDal;
        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        [Validation(typeof(StockValidator))]
        public async Task<IResult> Add(Stock data)
        {
            await _stockDal.Insert(data);
            return new SuccessResult("Stok Eklendi.", data.StockId);
        }

        public async Task<IResultData<List<Stock>>> GetAllList()
        {
            var data = await _stockDal.GetAllList();
            return new SuccessResultData<List<Stock>>(data);
        }

        public async Task<IResultData<Stock>> GetById(Guid Id)
        {
            return new SuccessResultData<Stock>(await _stockDal.Get(p => p.StockId == Id));
        }

        public async Task<IResult> Remove(Stock data)
        {
            await _stockDal.Delete(data);
            return new SuccessResult("Stok Silindi.", data.StockId);
        }

        public async Task<IResult> Update(Stock data)
        {
            await _stockDal.Update(data);
            return new SuccessResult("Stok Güncellendi.", data.StockId);
        }
    }
}
