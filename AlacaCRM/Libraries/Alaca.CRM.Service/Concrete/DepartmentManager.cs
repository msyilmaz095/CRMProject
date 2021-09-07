using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Core.Entities;
using Alaca.Core.Utilities.Authentication;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public async Task<IResult> Add(Department data)
        {
            await _departmentDal.Insert(data);
            return new SuccessResult("Departman Eklendi.");
        }

        public async Task<IResultData<List<Department>>> GetAllList()
        {
            var data = await _departmentDal.GetAllList();
            return new SuccessResultData<List<Department>>(data);
        }

        public async Task<IResultData<Department>> GetById(Guid Id)
        {
            return new SuccessResultData<Department>(await _departmentDal.Get(p => p.DepartmentId == Id));
        }

        public async Task<IResult> Remove(Department data)
        {
            await _departmentDal.Delete(data);
            return new SuccessResult("Departman Silindi.");
        }

        public async Task<IResult> Update(Department data)
        {
            await _departmentDal.Update(data);
            return new SuccessResult("Departman Güncellendi.");
        }
    }
}
