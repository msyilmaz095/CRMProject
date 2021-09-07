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
    public class FactoryManager : IFactoryService
    {
        IFactoryDal _factoryDal;
        public FactoryManager(IFactoryDal factoryDal)
        {
            _factoryDal = factoryDal;
        }

        [Validation(typeof(FactoryValidator))]
        public async Task<IResult> Add(Factory data)
        {
            await _factoryDal.Insert(data);
            return new SuccessResult("Fabrika Eklendi.", data.FactoryId);
        }

        public async Task<IResultData<List<Factory>>> GetAllList()
        {
            var data = await _factoryDal.GetAllList();
            return new SuccessResultData<List<Factory>>(data);
        }

        public async Task<IResultData<Factory>> GetById(Guid Id)
        {
            return new SuccessResultData<Factory>(await _factoryDal.Get(p => p.FactoryId == Id));
        }

        public async Task<IResult> Remove(Factory data)
        {
            await _factoryDal.Delete(data);
            return new SuccessResult("Fabrika Silindi.", data.FactoryId);
        }

        [Validation(typeof(FactoryValidator))]
        public async Task<IResult> Update(Factory data)
        {
            await _factoryDal.Update(data);
            return new SuccessResult("Fabrika Güncellendi.", data.FactoryId);
        }
    }
}
