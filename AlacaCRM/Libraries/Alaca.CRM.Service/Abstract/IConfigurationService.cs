using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IConfigurationService : IBaseService<Configuration, Guid>
    {
        public Task<IResultData<Configuration>> GetById2(string Id);
    }
}
