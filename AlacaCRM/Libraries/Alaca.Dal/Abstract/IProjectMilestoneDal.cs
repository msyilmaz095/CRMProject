using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IProjectMilestoneDal : IEntityRepository<ProjectMilestone>
    {

        Task<List<viewProjectMilestone>> GetviewProjectMilestones();
        Task<List<viewProjectMilestone>> GetWhereviewProjectMilestones(Expression<Func<viewProjectMilestone, bool>> Filter = null);
    }
}
