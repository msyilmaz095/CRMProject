using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class CustomerGroupManager : ICustomerGroupService
    {
        ICustomerGroupDal _customerGroupDal;
        public CustomerGroupManager(ICustomerGroupDal customerGroupDal)
        {
            _customerGroupDal = customerGroupDal;
        }
        public async Task<IResult> Add(CustomerGroup data)
        {
            await _customerGroupDal.Insert(data);
            return new SuccessResult("Müşteri Grubu Eklendi.",data.CustomerGroupId);
        }

        public async Task<IResultData<List<CustomerGroup>>> GetAllList()
        {
            return new SuccessResultData<List<CustomerGroup>>(await _customerGroupDal.GetAllList());
        }

        public async Task<IResultData<CustomerGroup>> GetById(Guid Id)
        {
            return new SuccessResultData<CustomerGroup>(await _customerGroupDal.Get(p => p.CustomerGroupId == Id));
        }

        public async Task<IResult> Remove(CustomerGroup data)
        {
            await _customerGroupDal.Delete(data);
            return new SuccessResult("Müşteri Grubu Silindi.", data.CustomerGroupId);
        }

        public async Task<IResult> Update(CustomerGroup data)
        {
            await _customerGroupDal.Update(data);
            return new SuccessResult("Müşteri Grubu Güncellendi.", data.CustomerGroupId);
        }
    }
}
