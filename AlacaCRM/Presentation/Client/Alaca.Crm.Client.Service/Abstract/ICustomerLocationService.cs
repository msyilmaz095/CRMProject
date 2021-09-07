using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface ICustomerLocationService : IBaseService<CustomerLocation, Guid>
    {
        Task<IResultData<CustomerLocation[]>> GetLocationByCustomerIdAll(Guid? id);
    }
}
