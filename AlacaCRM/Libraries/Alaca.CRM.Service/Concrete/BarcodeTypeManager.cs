using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class BarcodeTypeManager : IBarcodeTypeService
    {
        IBarcodeTypeDal _barcodeTypeDal;
        public BarcodeTypeManager(IBarcodeTypeDal barcodeTypeDal)
        {
            _barcodeTypeDal = barcodeTypeDal;
        }
        public async Task<IResult> Add(BarcodeType data)
        {
            await _barcodeTypeDal.Insert(data);
            return new SuccessResult("Barkod Türü Eklendi.", data.BarcodeTypeId);
        }

        public async Task<IResultData<List<BarcodeType>>> GetAllList()
        {
            var data = await _barcodeTypeDal.GetAllList();
            return new SuccessResultData<List<BarcodeType>>(data);
        }

        public async Task<IResultData<BarcodeType>> GetById(int Id)
        {
            return new SuccessResultData<BarcodeType>(await _barcodeTypeDal.Get(p => p.BarcodeTypeId == Id));
        }

        public async Task<IResult> Remove(BarcodeType data)
        {
            await _barcodeTypeDal.Delete(data);
            return new SuccessResult("Barkod Türü Silindi.", data.BarcodeTypeId);
        }

        public async Task<IResult> Update(BarcodeType data)
        {
            await _barcodeTypeDal.Update(data);
            return new SuccessResult("Barkod Türü Güncellendi.",data.BarcodeTypeId);
        }
    }
}
