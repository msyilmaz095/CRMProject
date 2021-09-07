using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectMilestoneManager : IProjectMilestoneService
    {
        IProjectMilestoneDal _projectMilestoneDal;
        public ProjectMilestoneManager(IProjectMilestoneDal ProjectMilestoneDal)
        {
            _projectMilestoneDal = ProjectMilestoneDal;
        }
        public async Task<IResult> Add(ProjectMilestone data)
        {
            await _projectMilestoneDal.Insert(data);
            return new SuccessResult("Proje Süreç Kaydedildi.",data.ProjectMilestoneId);
        }

        public async Task<IResultData<List<ProjectMilestone>>> GetAllList()
        {
            var data = await _projectMilestoneDal.GetAllList();
            return new SuccessResultData<List<ProjectMilestone>>(data);
        }

        public async Task<IResultData<ProjectMilestone>> GetById(Guid Id)
        {
            return new SuccessResultData<ProjectMilestone>(await _projectMilestoneDal.Get(p => p.ProjectMilestoneId == Id));
        }

        public async Task<IResultData<List<viewProjectMilestone>>> GetByProjectIdProjectMilestone(Guid ProjectId)
        {
            var data = await _projectMilestoneDal.GetWhereviewProjectMilestones(p=>p.ProjectId==ProjectId);
            return new SuccessResultData<List<viewProjectMilestone>>(data);
        }

        public async Task<IResult> Remove(ProjectMilestone data)
        {
            await _projectMilestoneDal.Delete(data);
            return new SuccessResult("Proje Süreç Silindi.", data.ProjectMilestoneId);
        }

        public async Task<IResult> Update(ProjectMilestone data)
        {
            await _projectMilestoneDal.Update(data);
            return new SuccessResult("Proje Süreç Güncellendi.", data.ProjectMilestoneId);
        }
    }
}
