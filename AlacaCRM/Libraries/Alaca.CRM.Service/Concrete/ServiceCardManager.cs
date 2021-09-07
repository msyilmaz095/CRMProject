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
    public class ServiceCardManager : IServiceCardService
    {
        IServiceCardDal _ServiceCardDal;
        public ServiceCardManager(IServiceCardDal ServiceCardDal)
        {
            _ServiceCardDal = ServiceCardDal;
        }

        [Validation(typeof(ServiceCardValidator))]
        public async Task<IResult> Add(ServiceCard data)
        {
            await _ServiceCardDal.Insert(data);
            return new SuccessResult("Hizmet Eklendi.", data.ServiceCardId);
        }

        public async Task<IResultData<List<ServiceCard>>> GetAllList()
        {
            var data = await _ServiceCardDal.GetAllList();
            return new SuccessResultData<List<ServiceCard>>(data);
        }

        public async Task<IResultData<ServiceCard>> GetById(Guid Id)
        {
            return new SuccessResultData<ServiceCard>(await _ServiceCardDal.Get(p => p.ServiceCardId == Id));
        }

        public async Task<IResult> Remove(ServiceCard data)
        {
            await _ServiceCardDal.Delete(data);
            return new SuccessResult("Hizmet Silindi.", data.ServiceCardId);
        }

        [Validation(typeof(ServiceCardValidator))]
        public async Task<IResult> Update(ServiceCard data)
        {
            await _ServiceCardDal.Update(data);
            return new SuccessResult("Hizmet Güncellendi.", data.ServiceCardId);
        }
    }
}
