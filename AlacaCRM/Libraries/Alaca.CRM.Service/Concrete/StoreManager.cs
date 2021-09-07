using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.Validations.FluentValidation;
using Alaca.Core.Aop.Autofac;

namespace Alaca.CRM.Service.Concrete
{
    public class StoreManager : IStoreService
    {
        IStoreDal _storeDal;
        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        [Validation(typeof(StoreValidator))]
        public async Task<IResult> Add(Store data)
        {
            await _storeDal.Insert(data);
            return new SuccessResult("Depo Eklendi.", data.StoreId);
        }

        public async Task<IResultData<List<Store>>> GetAllList()
        {
            var data = await _storeDal.GetAllList();
            return new SuccessResultData<List<Store>>(data);
        }

        public async Task<IResultData<Store>> GetById(Guid Id)
        {
            return new SuccessResultData<Store>(await _storeDal.Get(p => p.StoreId == Id));
        }

        public async Task<IResult> Remove(Store data)
        {
            await _storeDal.Delete(data);
            return new SuccessResult("Depo Silindi.", data.StoreId);
        }

        [Validation(typeof(StoreValidator))]
        public async Task<IResult> Update(Store data)
        {
            await _storeDal.Update(data);
            return new SuccessResult("Depo Güncellendi.", data.StoreId);
        }
    }
}
