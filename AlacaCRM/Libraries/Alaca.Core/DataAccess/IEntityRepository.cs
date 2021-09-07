using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.DataAccess
{
    public interface IEntityRepository<TEntity>: IRepository
        where TEntity : class
    {
        Task<int> Insert(TEntity data);

        Task<int> Delete(TEntity data);

        Task<int> Update(TEntity data);

        Task<List<TEntity>> GetAllList();

        Task<TEntity> Get(Expression<Func<TEntity, bool>> Filter = null);

        Task<List<TEntity>> GetWhere(Expression<Func<TEntity, bool>> Filter = null);

        //Task<int> SaveAsync();
    }
    public interface IRepository
    { }
}
