using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ContactTypeManager : IContactTypeService
    {
        IContactTypeDal _contactTypeDal;
        public ContactTypeManager(IContactTypeDal contactTypeDal)
        {
            _contactTypeDal = contactTypeDal;
        }
        public async Task<IResult> Add(ContactType data)
        {
            await _contactTypeDal.Insert(data);
            return new SuccessResult("İletişim Türü Eklendi.", data.ContactTypeId);
        }

        public async Task<IResultData<List<ContactType>>> GetAllList()
        {
            var data = await _contactTypeDal.GetAllList();
            return new SuccessResultData<List<ContactType>>(data);
        }

        public async Task<IResultData<ContactType>> GetById(Guid Id)
        {
            return new SuccessResultData<ContactType>(await _contactTypeDal.Get(p => p.ContactTypeId == Id));
        }

        public async Task<IResult> Remove(ContactType data)
        {
            await _contactTypeDal.Delete(data);
            return new SuccessResult("İletişim Türü Silindi.", data.ContactTypeId);
        }

        public async Task<IResult> Update(ContactType data)
        {
            await _contactTypeDal.Update(data);
            return new SuccessResult("İletişim Türü Güncellendi.", data.ContactTypeId);
        }
    }
}
