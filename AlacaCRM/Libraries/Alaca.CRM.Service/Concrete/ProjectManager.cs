using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public async Task<IResult> Add(Project data)
        {
            await _projectDal.Insert(data);
            return new SuccessResult("Proje Kaydedildi.", data.ProjectId);
        }

        public async Task<IResultData<List<Project>>> GetAllList()
        {
            return new SuccessResultData<List<Project>>(await _projectDal.GetAllList());
        }

        public async Task<IResultData<List<Project>>> GetByCustomerIdProject(Guid CustomerId)
        {
            return new SuccessResultData<List<Project>>(await _projectDal.GetWhere(p => p.CustomerId == CustomerId));
        }

        public async Task<IResultData<Project>> GetById(Guid Id)
        {
            return new SuccessResultData<Project>(await _projectDal.Get(p => p.ProjectId == Id));
        }

        public async Task<IResultData<List<viewProject>>> GetByDateTimeBetweenviewProjects(DateTime StartDate, DateTime EndDate)
        {
            return new SuccessResultData<List<viewProject>>(await _projectDal.GetwhereviewProject(p => p.ProjectDate >= StartDate && p.ProjectDate <= EndDate));
        }

        public async Task<IResultData<List<viewProject>>> GetviewProjects()
        {
            return new SuccessResultData<List<viewProject>>(await _projectDal.GetviewProjects());
        }
        //public async Task<IResultData<List<viewProject>>> GetOrderDescTop10viewProjects()
        //{
        //    return new SuccessResultData<List<viewProject>>(await _projectDal.GetwhereviewProject(p>));
        //}

        public async Task<IResult> Remove(Project data)
        {
            await _projectDal.Delete(data);
            return new SuccessResult("Proje Silindi", data.ProjectId);
        }

        public async Task<IResult> Update(Project data)
        {
            await _projectDal.Update(data);
            return new SuccessResult("Proje Güncellendi", data.ProjectId);
        }

        public async Task<IResultData<List<viewProject>>> GetOrderDescTop10viewProjects()
        {
            return new SuccessResultData<List<viewProject>>(await _projectDal.GetOrderDescTop10viewProjects());
        }
    }
}
