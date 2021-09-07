using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ContactStatuManager : IContactStatuService
    {
        IContactStatuDal _contactStatuDal;
        public ContactStatuManager(IContactStatuDal contactStatuDal)
        {
            _contactStatuDal = contactStatuDal;
        }
        public async Task<IResult> Add(ContactStatu data)
        {
            await _contactStatuDal.Insert(data);
            return new SuccessResult("İletişim Durumu Eklendi.", data.ContactStatuId);
        }

        public async Task<IResultData<List<ContactStatu>>> GetAllList()
        {
            var data = await _contactStatuDal.GetAllList();
            return new SuccessResultData<List<ContactStatu>>(data);
        }

        public async Task<IResultData<ContactStatu>> GetById(Guid Id)
        {
            return new SuccessResultData<ContactStatu>(await _contactStatuDal.Get(p => p.ContactStatuId == Id));
        }

        public async Task<IResult> Remove(ContactStatu data)
        {
            await _contactStatuDal.Delete(data);
            return new SuccessResult("İletişim Durumu Silindi.", data.ContactStatuId);
        }

        public async Task<IResult> Update(ContactStatu data)
        {
            await _contactStatuDal.Update(data);
            return new SuccessResult("İletişim Durumu Güncellendi.", data.ContactStatuId);
        }
    }
}
