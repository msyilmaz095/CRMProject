using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using System.Collections.Generic;
using Alaca.Entities.Dto;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IProjectDal : IEntityRepository<Project>
    {
        public Task<List<viewProject>> GetviewProjects();
        public Task<List<viewProject>> GetOrderDescTop10viewProjects();
        public Task<List<viewProject>> GetwhereviewProject(Expression<Func<viewProject, bool>> Filter = null);
    }
}
