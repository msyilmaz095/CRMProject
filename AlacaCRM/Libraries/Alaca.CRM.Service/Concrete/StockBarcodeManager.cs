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
    public class StockBarcodeManager : IStockBarcodeService
    {
        IStockBarcodeDal _stockBarcodeDal;
        public StockBarcodeManager(IStockBarcodeDal stockBarcodeDal)
        {
            _stockBarcodeDal = stockBarcodeDal;
        }

        [Validation(typeof(StockValidator))]
        public async Task<IResult> Add(StockBarcode data)
        {
            await _stockBarcodeDal.Insert(data);
            return new SuccessResult(data.StockBarcodeId);
        }

        public async Task<IResultData<List<StockBarcode>>> GetAllList()
        {
            var data = await _stockBarcodeDal.GetAllList();
            return new SuccessResultData<List<StockBarcode>>(data);
        }

        public async Task<IResultData<StockBarcode>> GetById(Guid Id)
        {
            return new SuccessResultData<StockBarcode>(await _stockBarcodeDal.Get(p => p.StockBarcodeId == Id));
        }

        public async Task<IResultData<List<StockBarcode>>> GetByStockIdStockBarcode(Guid? StockId)
        {
            return new SuccessResultData<List<StockBarcode>>(await _stockBarcodeDal.GetWhere(p => p.StockId == StockId));
        }

        public async Task<IResult> Remove(StockBarcode data)
        {
            await _stockBarcodeDal.Delete(data);
            return new SuccessResult(data.StockBarcodeId);
        }

        public async Task<IResult> Update(StockBarcode data)
        {
            await _stockBarcodeDal.Update(data);
            return new SuccessResult(data.StockBarcodeId);
        }
    }
}
