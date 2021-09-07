using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class StockUnitManager : IStockUnitService
    {
        IStockUnitDal _stockUnitDal;
        public StockUnitManager(IStockUnitDal stockUnitDal)
        {
            _stockUnitDal = stockUnitDal;
        }

        public async Task<IResult> Add(StockUnit data)
        {
            await _stockUnitDal.Insert(data);
            return new SuccessResult("Yeni Stok Birimi Eklendi.", data.StockId);
        }

        public async Task<IResultData<List<StockUnit>>> GetAllList()
        {
            var data = await _stockUnitDal.GetAllList();
            return new SuccessResultData<List<StockUnit>>(data);
        }

        public async Task<IResultData<StockUnit>> GetById(Guid Id)
        {
            return new SuccessResultData<StockUnit>(await _stockUnitDal.Get(p => p.StockUnitId == Id));
        }

        public async Task<IResultData<List<StockUnit>>> GetByStockIdStockUnit(Guid? StockId)
        {
            var data = await _stockUnitDal.GetWhere(p => p.StockId == StockId);
            return new SuccessResultData<List<StockUnit>>(data);
        }

        public async Task<IResult> Remove(StockUnit data)
        {
            await _stockUnitDal.Delete(data);
            return new SuccessResult("Stok Birimi Silindi.", data.StockUnitId);
        }

        public async Task<IResult> Update(StockUnit data)
        {
            await _stockUnitDal.Update(data);
            return new SuccessResult("Stok Birimi Güncellendi.", data.StockUnitId);
        }
    }
}
