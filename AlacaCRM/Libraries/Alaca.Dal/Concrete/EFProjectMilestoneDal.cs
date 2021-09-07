using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFProjectMilestoneDal : EFEntityRepository<ProjectMilestone, Alaca_CRMContext>, IProjectMilestoneDal
    {
        public EFProjectMilestoneDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        public Task<List<viewProjectMilestone>> GetviewProjectMilestones()
        {
            using (Alaca_CRMContext db=new())
            {
                var query = viewProjectMilestoneQuery(db);
                return Task.FromResult(query.ToList());
            }            
        }

        private IQueryable<viewProjectMilestone> viewProjectMilestoneQuery(Alaca_CRMContext db)
        {
            return from pm in db.ProjectMilestones
                   join pms in db.ProjectMilestoneStatus on pm.ProjectMilestoneStatuId equals pms.ProjectMilestoneStatuId into projectMilestoneStatuGroup
                   from projectMilestoneStatu in projectMilestoneStatuGroup.DefaultIfEmpty()
                   join pmt in db.ProjectMilestoneTypes on pm.ProjectMilestoneTypeId equals pmt.ProjectMilestoneTypeId into projectMilestoneTypeGroup
                   from projectMilestoneType in projectMilestoneTypeGroup.DefaultIfEmpty()
                   join emp in db.Employees on pm.AssignedTo equals emp.EmployeeId into projectMilestoneAssignedToGroup
                   from AssignedTo in projectMilestoneAssignedToGroup.DefaultIfEmpty()
                   join sbt in db.SubContratorTeams on pm.SubcontratorTeamId equals sbt.SubContratorTeamId into subContratorTeamGroup
                   from subContratorTeam in subContratorTeamGroup.DefaultIfEmpty()
                   select new viewProjectMilestone()
                   {
                       AssignedTo = pm.AssignedTo,
                       AssignedToName = AssignedTo.Name + " " + AssignedTo.Surname,
                       SubContratorId = pm.SubContratorId,
                       CreateDate = pm.CreateDate,
                       CreateUser = pm.CreateUser,
                       Description = pm.Description,
                       MilestoneActualFinishDate = pm.MilestoneActualFinishDate,
                       MilestoneActualStartDate = pm.MilestoneActualStartDate,
                       MilestoneTargetFinishDate = pm.MilestoneTargetFinishDate,
                       MilestoneTargetStartDate = pm.MilestoneTargetStartDate,
                       ProjectId = pm.ProjectId,
                       ProjectMilestoneId = pm.ProjectMilestoneId,
                       ProjectMilestoneName = pm.ProjectMilestoneName,
                       ProjectMilestoneStatuId = pm.ProjectMilestoneStatuId,
                       ProjectMilestoneStatuName = projectMilestoneStatu.ProjectMilestoneStatuName,
                       ProjectMilestoneTypeId = pm.ProjectMilestoneTypeId,
                       ProjectMilestoneTypeName = projectMilestoneType.ProjectMilestoneTypeName,
                       SubcontratorTeamId = pm.SubcontratorTeamId,
                       UpdateDate = pm.UpdateDate,
                       UpdateUser = pm.UpdateUser,
                       SubContratorTeamName = subContratorTeam.SubcontratorTeamName,
                   };
        }

        public Task<List<viewProjectMilestone>> GetWhereviewProjectMilestones(Expression<Func<viewProjectMilestone, bool>> Filter = null)
        {
            using (Alaca_CRMContext db = new())
            {
                var query = viewProjectMilestoneQuery(db);
                return Task.FromResult(query.Where(Filter).ToList());
            }
        }
    }
}
