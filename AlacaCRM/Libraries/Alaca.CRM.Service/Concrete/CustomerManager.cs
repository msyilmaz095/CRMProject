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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [Validation(typeof(CustomerValitador))]
        public async Task<IResult> Add(Customer data)
        {
            await _customerDal.Insert(data);
            return new SuccessResult("Müşteri Eklendi.", data.CustomerId);
        }

        public async Task<IResultData<List<Customer>>> GetAllList()
        {
            var data = await _customerDal.GetAllList();
            return new SuccessResultData<List<Customer>>(data);
        }

        public async Task<IResultData<Customer>> GetById(Guid Id)
        {
            return new SuccessResultData<Customer>(await _customerDal.Get(p => p.CustomerId == Id));
        }

        public async Task<IResult> Remove(Customer data)
        {
            await _customerDal.Delete(data);
            return new SuccessResult("Müşteri Silindi.", data.CustomerId);
        }

        [Validation(typeof(CustomerValitador))]
        public async Task<IResult> Update(Customer data)
        {
            await _customerDal.Update(data);
            return new SuccessResult("Müşteri Güncellendi.", data.CustomerId);
        }
    }
}
