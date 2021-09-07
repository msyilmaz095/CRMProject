using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ProjectDocumentManager : IProjectDocumentService
    {
        IProjectDocumentDal _projectDocumentDal;
        public ProjectDocumentManager(IProjectDocumentDal ProjectDocumentDal)
        {
            _projectDocumentDal = ProjectDocumentDal;
        }
        public async Task<IResult> Add(ProjectDocument data)
        {
            await _projectDocumentDal.Insert(data);
            return new SuccessResult(data.ProjectDocumentId);
        }

        public async Task<IResultData<List<ProjectDocument>>> GetAllList()
        {
            var data = await _projectDocumentDal.GetAllList();
            return new SuccessResultData<List<ProjectDocument>>(data);
        }

        public async Task<IResultData<ProjectDocument>> GetById(Guid Id)
        {
            return new SuccessResultData<ProjectDocument>(await _projectDocumentDal.Get(p => p.ProjectDocumentId == Id));
        }

        public async Task<IResult> Remove(ProjectDocument data)
        {
            await _projectDocumentDal.Delete(data);
            return new SuccessResult(data.ProjectDocumentId);
        }

        public async Task<IResult> Update(ProjectDocument data)
        {
            await _projectDocumentDal.Update(data);
            return new SuccessResult(data.ProjectDocumentId);
        }
    }
}
