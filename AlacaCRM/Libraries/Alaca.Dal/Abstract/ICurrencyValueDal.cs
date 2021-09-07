using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Abstract
{
    public interface ICurrencyValueDal : IEntityRepository<CurrencyValue>
    {
        public Task<List<viewCurrencyValue>> GetviewCurrencyValue();
    }
}
