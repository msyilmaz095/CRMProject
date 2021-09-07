using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFCustomerLocationDal : EFEntityRepository<CustomerLocation, Alaca_CRMContext>, ICustomerLocationDal
    {
        public EFCustomerLocationDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public override async Task<List<CustomerLocation>> GetWhere(Expression<Func<CustomerLocation, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                return await context.CustomerLocations.Include(i => i.City).Include(i => i.Zone).Include(i => i.District).Include(i => i.LocationType).Where(Filter).ToListAsync();
            }
        }

        public override async Task<List<CustomerLocation>> GetAllList()
        {
            using (var context = new Alaca_CRMContext())
            {
                return  await context.CustomerLocations.Include(i => i.City).Include(i => i.Zone).Include(i => i.District).Include(i => i.LocationType).ToListAsync();
            }
        }

        public override async Task<CustomerLocation> Get(Expression<Func<CustomerLocation, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                return await context.CustomerLocations.Include(i => i.City).Include(i => i.Zone).Include(i => i.District).Include(i => i.LocationType).FirstOrDefaultAsync(Filter);
            }
        }
    }
}
