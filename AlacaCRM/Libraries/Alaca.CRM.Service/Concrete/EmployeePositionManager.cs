using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class EmployeePositionManager : IEmployeePositionService
    {
        IEmployeePositionDal _employeePositionDal;
        public EmployeePositionManager(IEmployeePositionDal employeePositionDal)
        {
            _employeePositionDal = employeePositionDal;
        }
        public async Task<IResult> Add(EmployeePosition data)
        {
            await _employeePositionDal.Insert(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<EmployeePosition>>> GetAllList()
        {
            var data = await _employeePositionDal.GetAllList();
            return new SuccessResultData<List<EmployeePosition>>(data);
        }

        public async Task<IResultData<EmployeePosition>> GetById(Guid Id)
        {
            return new SuccessResultData<EmployeePosition>(await _employeePositionDal.Get(p => p.EmployeePositionId == Id));
        }

        public async Task<IResult> Remove(EmployeePosition data)
        {
            await _employeePositionDal.Delete(data);
            return new SuccessResult();
        }

        public async Task<IResult> Update(EmployeePosition data)
        {
            await _employeePositionDal.Update(data);
            return new SuccessResult();
        }
    }
}
