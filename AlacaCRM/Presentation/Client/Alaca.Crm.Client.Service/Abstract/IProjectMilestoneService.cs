using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Threading.Tasks;
using Smart.Blazor;
using Alaca.Core.Entities;
using System.Collections.Generic;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IProjectMilestoneService : IBaseService<ProjectMilestone, Guid>
    {
        Task<List<GanttDataRecord>> GetByGanttDataRecord();
        Task<IResultData<viewProjectMilestone[]>> GetByProjectIdProjectMilestone(Guid ProjectId);
    }
}
