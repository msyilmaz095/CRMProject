using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IUserDepartmentPermissionService : IBaseService<UserDepartmentPermission, Guid>
    {
        public Task<bool> CheckByUserDepartmentControl(Guid UserId, Guid DepartmentId);
        public Task<IResultData<List<UserDepartmentPermission>>> GetByUserIdUserDepartment(Guid UserId);
    }
}
