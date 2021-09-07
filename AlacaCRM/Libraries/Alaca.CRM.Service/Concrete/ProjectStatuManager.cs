using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectStatuManager : IProjectStatuService
    {
        IProjectStatuDal _projectStatuDal;
        public ProjectStatuManager(IProjectStatuDal projectStatuDal)
        {
            _projectStatuDal = projectStatuDal;
        }
        public async Task<IResult> Add(ProjectStatu data)
        {
            await _projectStatuDal.Insert(data);
            return new SuccessResult("Proje Durum Kaydedildi.",data.ProjectStatuId);
        }

        public async Task<IResultData<List<ProjectStatu>>> GetAllList()
        {
            var data = await _projectStatuDal.GetAllList();
            return new SuccessResultData<List<ProjectStatu>>(data);
        }

        public async Task<IResultData<ProjectStatu>> GetById(byte Id)
        {
            return new SuccessResultData<ProjectStatu>(await _projectStatuDal.Get(p => p.ProjectStatuId == Id));
        }

        public async Task<IResult> Remove(ProjectStatu data)
        {
            await _projectStatuDal.Delete(data);
            return new SuccessResult("Proje Durum Silindi.", data.ProjectStatuId);
        }

        public async Task<IResult> Update(ProjectStatu data)
        {
            await _projectStatuDal.Update(data);
            return new SuccessResult("Proje Durum Güncellendi.", data.ProjectStatuId);
        }
    }
}
