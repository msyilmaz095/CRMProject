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
    public class EFContactDal : EFEntityRepository<Contact, Alaca_CRMContext>, IContactDal
    {
        public EFContactDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public override async Task<List<Contact>> GetWhere(Expression<Func<Contact, bool>> Filter = null)
        {
            using (Alaca_CRMContext context = new Alaca_CRMContext())
            {
                return await context.Contacts.Include(i => i.ContactType).Include(i => i.ContactStatu).Include(i => i.Department).Include(i => i.Position).Include(i => i.CustomerLocation).Where(Filter).ToListAsync();
            }
        }

        public override async Task<List<Contact>> GetAllList()
        {
            using (Alaca_CRMContext context = new Alaca_CRMContext())
            {
                return await context.Contacts.Include(i => i.ContactType).Include(i => i.ContactStatu).Include(i => i.Department).Include(i => i.Position).Include(i => i.CustomerLocation).ToListAsync();
            }
        }

        public override async Task<Contact> Get(Expression<Func<Contact, bool>> Filter = null)
        {
            using (Alaca_CRMContext context = new Alaca_CRMContext())
            {
                return await context.Contacts.Include(i => i.ContactType).Include(i => i.ContactStatu).Include(i => i.Department).Include(i => i.Position).Include(i => i.CustomerLocation).FirstOrDefaultAsync(Filter);
            }
        }
    }
}
