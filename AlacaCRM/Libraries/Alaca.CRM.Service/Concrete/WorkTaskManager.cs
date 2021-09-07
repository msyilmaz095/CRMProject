using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.Validations.FluentValidation;
using Alaca.Core.Aop.Autofac;

namespace Alaca.CRM.Service.Concrete
{
    public class WorkTaskManager : IWorkTaskService
    {
        IWorkTaskDal _workTaskDal;
        public WorkTaskManager(IWorkTaskDal workTask)
        {
            _workTaskDal = workTask;
        }

        [Validation(typeof(WorkTaskValidator))]
        public async Task<IResult> Add(WorkTask data)
        {
            await _workTaskDal.Insert(data);
            return new SuccessResult("İş Emri Eklendi.", data.WorkTaskId);
        }

        public async Task<IResultData<List<WorkTask>>> GetAllList()
        {
            var data = await _workTaskDal.GetAllList();
            return new SuccessResultData<List<WorkTask>>(data);
        }

        public async Task<IResultData<WorkTask>> GetById(Guid Id)
        {
            return new SuccessResultData<WorkTask>(await _workTaskDal.Get(p => p.WorkTaskId == Id));
        }

        public async Task<IResult> Remove(WorkTask data)
        {
            await _workTaskDal.Delete(data);
            return new SuccessResult("İş Emri Silindi.", data.WorkTaskId);
        }

        [Validation(typeof(WorkTaskValidator))]
        public async Task<IResult> Update(WorkTask data)
        {
            await _workTaskDal.Update(data);
            return new SuccessResult("İş Emri Güncellendi.", data.WorkTaskId);
        }
    }
}
