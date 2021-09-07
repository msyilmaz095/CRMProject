using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IContactService : IBaseService<Contact, Guid>
    {
        Task<IResultData<List<Contact>>> GetContactByCustomerIdAll(Guid id);
    }
}
