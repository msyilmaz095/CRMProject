using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;

namespace Alaca.CRM.Service.Concrete
{
    public class CustomerRelationManager : ICustomerRelationService
    {
        ICustomerRelationDal _customerRelationDal;
        public CustomerRelationManager(ICustomerRelationDal customerRelationDal)
        {
            _customerRelationDal = customerRelationDal;
        }
        public async Task<IResult> Add(CustomerRelation data)
        {
            await _customerRelationDal.Insert(data);
            return new SuccessResult("Müşteri İlişki Türü Eklendi.", data.CustomerRelationId);
        }

        public async Task<IResultData<List<CustomerRelation>>> GetAllList()
        {
            var data = await _customerRelationDal.GetAllList();
            return new SuccessResultData<List<CustomerRelation>>(data);
        }

        public async Task<IResultData<CustomerRelation>> GetById(Guid Id)
        {
            return new SuccessResultData<CustomerRelation>(await _customerRelationDal.Get(p => p.CustomerRelationId == Id));
        }

        public async Task<IResult> Remove(CustomerRelation data)
        {
            await _customerRelationDal.Delete(data);
            return new SuccessResult("Müşteri İlişki Türü Silindi.", data.CustomerRelationId);
        }

        public async Task<IResult> Update(CustomerRelation data)
        {
            await _customerRelationDal.Update(data);
            return new SuccessResult("Müşteri İlişki Türü Güncellendi.", data.CustomerRelationId);
        }
    }
}
