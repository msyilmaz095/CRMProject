using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface ICurrencyValueService : IBaseService<CurrencyValue, Guid>
    {
        public Task<IResultData<List<viewCurrencyValue>>> GetviewCurrencyValue();
    }
}
