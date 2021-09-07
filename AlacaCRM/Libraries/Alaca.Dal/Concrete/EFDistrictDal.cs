using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFDistrictDal : EFEntityRepository<District, Alaca_CRMContext>, IDistrictDal
    {
        public EFDistrictDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public override async Task<District> Get(Expression<Func<District, bool>> Filter = null)
        {
            using (var context=new Alaca_CRMContext())
            {
                return await context.Districts.FirstOrDefaultAsync(Filter);
            }
        }
        public override async Task<List<District>> GetAllList()
        {
            using (var context = new Alaca_CRMContext())
            {
                return await context.Districts.Include(i => i.City).ToListAsync();
            }
        }
    }
}
