using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IProjectMilestoneService : IBaseService<ProjectMilestone, Guid>
    {
        Task<IResultData<List<viewProjectMilestone>>> GetByProjectIdProjectMilestone(Guid ProjectId);
    }
}
