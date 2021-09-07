using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IConfigurationService : IBaseService<Configuration, Guid>
    {
        public Task<IResultData<Configuration>> GetById(string id);
        public Task<IResult> Delete(string id);
    }
}
