using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface ICustomerLocationService : IBaseService<CustomerLocation, Guid>
    {
        public Task<IResultData<List<CustomerLocation>>> GetLocationByCustomerIdAll(Guid Id);
    }
}
