using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Alaca.Core.Entities;
using Alaca.Core.Utilities.Extension;

namespace Alaca.Core.DataAccess.EntityFramework
{

    public class EFEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        IHttpContextAccessor _httpContextAccessor;
        public EFEntityRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> Delete(TEntity data)
        {
            using (TContext _context = new TContext())
            {
                _context.Set<TEntity>().Remove(data);
                return await _context.SaveChangesAsync();
            }
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (TContext _context = new TContext())
            {
                return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(Filter);
            }
        }

        public virtual async Task<List<TEntity>> GetAllList()
        {
            using (TContext _context = new TContext())
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
        }

        public virtual async Task<List<TEntity>> GetWhere(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (TContext _context = new TContext())
            {
                return await _context.Set<TEntity>().Where(Filter).ToListAsync();
            }
        }

        public async Task<int> Insert(TEntity data)
        {
            using (TContext _context = new TContext())
            {
                ((IBaseEntity)data).CreateUser = _httpContextAccessor.GetClaimNameIdentifier();
                await _context.Set<TEntity>().AddAsync(data);
                return await _context.SaveChangesAsync();
            }
        }

        //public async Task<int> SaveAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}

        public async Task<int> Update(TEntity data)
        {
            using (TContext _context = new TContext())
            {
                ((IBaseEntity)data).UpdateDate = DateTime.Now;
                ((IBaseEntity)data).UpdateUser = _httpContextAccessor.GetClaimNameIdentifier();
                _context.Entry<TEntity>(data).State = EntityState.Modified;
                return await _context.SaveChangesAsync();
            }         
        }
    }
}
