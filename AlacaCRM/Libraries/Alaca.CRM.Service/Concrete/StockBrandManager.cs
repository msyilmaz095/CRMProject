using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class StockBrandManager : IStockBrandService
    {
        IStockBrandDal _stockBrandDal;
        public StockBrandManager(IStockBrandDal stockBrandDal)
        {
            _stockBrandDal = stockBrandDal;
        }
        public async Task<IResult> Add(StockBrand data)
        {
            await _stockBrandDal.Insert(data);
            return new SuccessResult("Marka Eklendi.", data.StockBrandId);
        }

        public async Task<IResultData<List<StockBrand>>> GetAllList()
        {
            var data = await _stockBrandDal.GetAllList();
            return new SuccessResultData<List<StockBrand>>(data);
        }

        public async Task<IResultData<StockBrand>> GetById(Guid Id)
        {
            return new SuccessResultData<StockBrand>(await _stockBrandDal.Get(p => p.StockBrandId == Id));
        }

        public async Task<IResult> Remove(StockBrand data)
        {
            await _stockBrandDal.Delete(data);
            return new SuccessResult("Marka Silindi.", data.StockBrandId);
        }

        public async Task<IResult> Update(StockBrand data)
        {
            await _stockBrandDal.Update(data);
            return new SuccessResult("Marka Güncellendi.", data.StockBrandId);
        }
    }
}
