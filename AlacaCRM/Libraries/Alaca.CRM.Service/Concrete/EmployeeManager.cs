using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Alaca.CRM.Service.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public async Task<IResult> Add(Employee data)
        {
            await _employeeDal.Insert(data);
            return new SuccessResult("Personel Eklendi.", data.EmployeeId);
        }

        public async Task<IResultData<List<Employee>>> GetAllList()
        {
            var data = await _employeeDal.GetAllList();
            return new SuccessResultData<List<Employee>>(data);
        }

        public async Task<IResultData<Employee>> GetById(Guid Id)
        {
            var data = await _employeeDal.Get(p => p.EmployeeId == Id);
            return new SuccessResultData<Employee>(data);
        }

        public async Task<IResult> Remove(Employee data)
        {
            await _employeeDal.Delete(data);
            return new SuccessResult("Personel Silindi.");
        }

        public async Task<IResult> Update(Employee data)
        {
            await _employeeDal.Update(data);
            return new SuccessResult("Personel Güncellendi.");
        }
    }
}
