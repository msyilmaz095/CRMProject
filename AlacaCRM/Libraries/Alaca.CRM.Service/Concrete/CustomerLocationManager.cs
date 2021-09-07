using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.Core.Aop.Autofac;
using Alaca.Validations.FluentValidation;

namespace Alaca.CRM.Service.Concrete
{
    public class CustomerLocationManager : ICustomerLocationService
    {
        ICustomerLocationDal _customerLocationDal;
        public CustomerLocationManager(ICustomerLocationDal customerLocationDal)
        {
            _customerLocationDal = customerLocationDal;
        }

        [Validation(typeof(CustomerLocationValitador))]
        public async Task<IResult> Add(CustomerLocation data)
        {
            await _customerLocationDal.Insert(data);
            return new SuccessResult("Müşteri Lokasyon Eklendi.", data.CustomerLocationId);
        }

        public async Task<IResultData<List<CustomerLocation>>> GetAllList()
        {
            var data = await _customerLocationDal.GetAllList();
            return new SuccessResultData<List<CustomerLocation>>(data);
        }

        public async Task<IResultData<CustomerLocation>> GetById(Guid Id)
        {
            return new SuccessResultData<CustomerLocation>(await _customerLocationDal.Get(p => p.CustomerLocationId == Id));
        }

        public async Task<IResultData<List<CustomerLocation>>> GetLocationByCustomerIdAll(Guid Id)
        {
            return new SuccessResultData<List<CustomerLocation>>(await _customerLocationDal.GetWhere(p => p.CustomerId == Id));
        }

        public async Task<IResult> Remove(CustomerLocation data)
        {
            await _customerLocationDal.Delete(data);
            return new SuccessResult("Müşteri Lokasyon Silindi.", data.CustomerLocationId);
        }

        [Validation(typeof(CustomerLocationValitador))]
        public async Task<IResult> Update(CustomerLocation data)
        {
            await _customerLocationDal.Update(data);
            return new SuccessResult("Müşteri Lokasyon Güncellendi.", data.CustomerLocationId);
        }
    }
}
