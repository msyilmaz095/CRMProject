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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        [Validation(typeof(ContactValitador))]
        public async Task<IResult> Add(Contact data)
        {
            await _contactDal.Insert(data);
            return new SuccessResult(data.ContactId);
        }

        public async Task<IResultData<List<Contact>>> GetAllList()
        {
            var data = await _contactDal.GetAllList();
            return new SuccessResultData<List<Contact>>(data);
        }

        public async Task<IResultData<Contact>> GetById(Guid Id)
        {
            return new SuccessResultData<Contact>(await _contactDal.Get(p => p.ContactId == Id));
        }

        public async Task<IResultData<List<Contact>>> GetContactByCustomerIdAll(Guid Id)
        {
            return new SuccessResultData<List<Contact>>(await _contactDal.GetWhere(p => p.CustomerId == Id));
        }

        public async Task<IResult> Remove(Contact data)
        {
            await _contactDal.Delete(data);
            return new SuccessResult(data.ContactId);
        }

        [Validation(typeof(ContactValitador))]
        public async Task<IResult> Update(Contact data)
        {
            await _contactDal.Update(data);
            return new SuccessResult(data.ContactId);
        }
    }
}
