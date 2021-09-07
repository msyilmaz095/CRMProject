using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class StockUnitDefinitionManager : IStockUnitDefinitionService
    {
        IStockUnitDefinitionDal _stockUnitDefinitionDal;
        public StockUnitDefinitionManager(IStockUnitDefinitionDal stockUnitDefinitionDal)
        {
            _stockUnitDefinitionDal = stockUnitDefinitionDal;
        }
        public async Task<IResult> Add(StockUnitDefinition data)
        {
            await _stockUnitDefinitionDal.Insert(data);
            return new SuccessResult("Stok Ana Birim Eklendi.",data.StockUnitDefinitionId);
        }

        public async Task<IResultData<List<StockUnitDefinition>>> GetAllList()
        {
            var data = await _stockUnitDefinitionDal.GetAllList();
            return new SuccessResultData<List<StockUnitDefinition>>(data);
        }

        public async Task<IResultData<StockUnitDefinition>> GetById(Guid Id)
        {
            return new SuccessResultData<StockUnitDefinition>(await _stockUnitDefinitionDal.Get(p => p.StockUnitDefinitionId == Id));
        }

        public async Task<IResult> Remove(StockUnitDefinition data)
        {
            await _stockUnitDefinitionDal.Delete(data);
            return new SuccessResult("Stok Ana Birim Silindi.", data.StockUnitDefinitionId);
        }

        public async Task<IResult> Update(StockUnitDefinition data)
        {
            await _stockUnitDefinitionDal.Update(data);
            return new SuccessResult("Stok Ana Birim Güncellendi.", data.StockUnitDefinitionId);
        }
    }
}
