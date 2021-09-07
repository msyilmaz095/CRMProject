using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Entities;
using Alaca.CRM.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;

namespace Alaca.CRM.Service.Concrete
{
    public class ConfigurationManager : IConfigurationService
    {
        IConfigurationDal _configurationDal;
        public ConfigurationManager(IConfigurationDal configurationDal)
        {
            _configurationDal = configurationDal;
        }

        public async Task<IResult> Add(Configuration data)
        {
            await _configurationDal.Insert(data);
            return new SuccessResult("Parametre Eklendi.");
        }

        public async Task<IResultData<List<Configuration>>> GetAllList()
        {
            var data = await _configurationDal.GetAllList();
            return new SuccessResultData<List<Configuration>>(data);
        }

        public Task<IResultData<Configuration>> GetById(Guid Id)
        {
            return Task.FromResult<IResultData<Configuration>>(new FailedResultData<Configuration>("Bu özellik desteklenmiyor!!!"));
        }

        public async Task<IResultData<Configuration>> GetById2(string Id)
        {
            return new SuccessResultData<Configuration>(await _configurationDal.Get(p => p.ConfigurationCode == Id));
        }


        public async Task<IResult> Remove(Configuration data)
        {
            await _configurationDal.Delete(data);
            return new SuccessResult("Parametre Silindi.");
        }

        public async Task<IResult> Update(Configuration data)
        {
            await _configurationDal.Update(data);
            return new SuccessResult("Parametre Güncellendi.");
        }
    }
}
