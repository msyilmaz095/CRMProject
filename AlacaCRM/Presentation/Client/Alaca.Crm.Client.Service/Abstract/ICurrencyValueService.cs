using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface ICurrencyValueService : IBaseService<CurrencyValue, Guid>
    {
        public Task<IResultData<viewCurrencyValue[]>> GetviewCurrencyValue();
    }
}
