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
    public class WorkTaskTypeManager : IWorkTaskTypeService
    {
        IWorkTaskTypeDal _workTaskTypeDal;
        public WorkTaskTypeManager(IWorkTaskTypeDal workTaskType)
        {
            _workTaskTypeDal = workTaskType;
        }

        [Validation(typeof(WorkTaskTypeValidator))]
        public async Task<IResult> Add(WorkTaskType data)
        {
            await _workTaskTypeDal.Insert(data);
            return new SuccessResult("İş Emri Tİpi Eklendi.", data.WorkTaskTypeId);
        }

        public async Task<IResultData<List<WorkTaskType>>> GetAllList()
        {
            var data = await _workTaskTypeDal.GetAllList();
            return new SuccessResultData<List<WorkTaskType>>(data);
        }

        public async Task<IResultData<WorkTaskType>> GetById(Guid Id)
        {
            return new SuccessResultData<WorkTaskType>(await _workTaskTypeDal.Get(p => p.WorkTaskTypeId == Id));
        }

        public async Task<IResult> Remove(WorkTaskType data)
        {
            await _workTaskTypeDal.Delete(data);
            return new SuccessResult("İş Emri Tİpi Silindi.", data.WorkTaskTypeId);
        }

        [Validation(typeof(WorkTaskTypeValidator))]
        public async Task<IResult> Update(WorkTaskType data)
        {
            await _workTaskTypeDal.Update(data);
            return new SuccessResult("İş Emri Tİpi Güncellendi.", data.WorkTaskTypeId);
        }
    }
}
