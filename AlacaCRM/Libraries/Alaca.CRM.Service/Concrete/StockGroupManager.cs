using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class StockGroupManager : IStockGroupService
    {
        IStockGroupDal _stockGroupDal;
        public StockGroupManager(IStockGroupDal stockGroupDal)
        {
            _stockGroupDal = stockGroupDal;
        }
        public async Task<IResult> Add(StockGroup data)
        {
            await _stockGroupDal.Insert(data);
            return new SuccessResult("Yeni Stok Grubu Eklendi.", data.StockGroupId);
        }

        public async Task<IResultData<List<StockGroup>>> GetAllList()
        {
            var data = await _stockGroupDal.GetAllList();
            return new SuccessResultData<List<StockGroup>>(data);
        }

        public async Task<IResultData<StockGroup>> GetById(Guid Id)
        {
            return new SuccessResultData<StockGroup>(await _stockGroupDal.Get(p => p.StockGroupId == Id));
        }

        public async Task<IResult> Remove(StockGroup data)
        {
            await _stockGroupDal.Delete(data);
            return new SuccessResult("Stok Grubu Silindi.",data.StockGroupId);
        }

        public async Task<IResult> Update(StockGroup data)
        {
            await _stockGroupDal.Update(data);
            return new SuccessResult("Stok Grubu Güncellendi.",data.StockGroupId);
        }
    }
}
