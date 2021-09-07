using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectMilestoneTypeManager : IProjectMilestoneTypeService
    {
        IProjectMilestoneTypeDal _projectMilestoneTypeDal;
        public ProjectMilestoneTypeManager(IProjectMilestoneTypeDal projectMilestoneTypeDal)
        {
            _projectMilestoneTypeDal = projectMilestoneTypeDal;
        }
        public async Task<IResult> Add(ProjectMilestoneType data)
        {
            await _projectMilestoneTypeDal.Insert(data);
            return new SuccessResult("Proje Süreç Türü Kaydedildi.", data.ProjectMilestoneTypeId);
        }

        public async Task<IResultData<List<ProjectMilestoneType>>> GetAllList()
        {
            var data = await _projectMilestoneTypeDal.GetAllList();
            return new SuccessResultData<List<ProjectMilestoneType>>(data);
        }

        public async Task<IResultData<ProjectMilestoneType>> GetById(byte Id)
        {
            return new SuccessResultData<ProjectMilestoneType>(await _projectMilestoneTypeDal.Get(p => p.ProjectMilestoneTypeId == Id));
        }

        public async Task<IResult> Remove(ProjectMilestoneType data)
        {
            await _projectMilestoneTypeDal.Delete(data);
            return new SuccessResult("Proje Süreç Türü Silindi.",data.ProjectMilestoneTypeId);
        }

        public async Task<IResult> Update(ProjectMilestoneType data)
        {
            await _projectMilestoneTypeDal.Update(data);
            return new SuccessResult("Proje Süreç Türü Güncellendi.", data.ProjectMilestoneTypeId);
        }
    }
}
