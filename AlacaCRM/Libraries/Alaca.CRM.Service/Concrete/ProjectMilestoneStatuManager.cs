using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectMilestoneStatuManager : IProjectMilestoneStatuService
    {
        IProjectMilestoneStatuDal _projectMilestoneStatuDal;
        public ProjectMilestoneStatuManager(IProjectMilestoneStatuDal projectMilestoneStatuDal)
        {
            _projectMilestoneStatuDal = projectMilestoneStatuDal;
        }
        public async Task<IResult> Add(ProjectMilestoneStatu data)
        {
            await _projectMilestoneStatuDal.Insert(data);
            return new SuccessResult("Proje Süreç Statu Kaydı Başarılı.",data.ProjectMilestoneStatuId);
        }

        public async Task<IResultData<List<ProjectMilestoneStatu>>> GetAllList()
        {
            var data = await _projectMilestoneStatuDal.GetAllList();
            return new SuccessResultData<List<ProjectMilestoneStatu>>(data);
        }

        public async Task<IResultData<ProjectMilestoneStatu>> GetById(byte Id)
        {
            return new SuccessResultData<ProjectMilestoneStatu>(await _projectMilestoneStatuDal.Get(p => p.ProjectMilestoneStatuId == Id));
        }

        public async Task<IResult> Remove(ProjectMilestoneStatu data)
        {
            await _projectMilestoneStatuDal.Delete(data);
            return new SuccessResult("Proje Süreç Statu Kaydı Silindi.", data.ProjectMilestoneStatuId);
        }

        public async Task<IResult> Update(ProjectMilestoneStatu data)
        {
            await _projectMilestoneStatuDal.Update(data);
            return new SuccessResult("Proje Süreç Statu Kaydı Güncellendi.", data.ProjectMilestoneStatuId);
        }
    }
}
