using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFCurrencyValueDal : EFEntityRepository<CurrencyValue, Alaca_CRMContext>, ICurrencyValueDal
    {
        public EFCurrencyValueDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public Task<List<viewCurrencyValue>> GetviewCurrencyValue()
        {
            using (var context = new Alaca_CRMContext())
            {
                var query = from currencyValue in context.CurrencyValues
                            join currency in context.Currencies on currencyValue.CurrencyId equals currency.CurrencyId
                            select new viewCurrencyValue()
                            {
                                CurrencyId = currency.CurrencyId,
                                CurrencyName = currency.CurrencyName,
                                CurrencyValuesId = currencyValue.CurrencyValuesId,
                                Date=currencyValue.Date,
                                Parity=currencyValue.Parity,
                            };
                return Task.FromResult(query.ToList());
            }
        }
    }
}
