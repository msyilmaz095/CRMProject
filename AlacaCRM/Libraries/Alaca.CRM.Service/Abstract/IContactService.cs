using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IContactService : IBaseService<Contact, Guid>
    {
        public Task<IResultData<List<Contact>>> GetContactByCustomerIdAll(Guid Id);
    }
}
