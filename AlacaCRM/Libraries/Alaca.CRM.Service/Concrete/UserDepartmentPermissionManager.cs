using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class UserDepartmentPermissionManager : IUserDepartmentPermissionService
    {
        IUserDepartmentPermissionDal _userDepartmentPermissionDal;
        public UserDepartmentPermissionManager(IUserDepartmentPermissionDal userDepartmentPermissionDal)
        {
            _userDepartmentPermissionDal = userDepartmentPermissionDal;
        }
        public async Task<IResult> Add(UserDepartmentPermission data)
        {
            await _userDepartmentPermissionDal.Insert(data);
            return new SuccessResult(data.UserDepartmentPermissionId);
        }

        public async Task<bool> CheckByUserDepartmentControl(Guid UserId, Guid DepartmentId)
        {
            var userDepartman = await _userDepartmentPermissionDal.Get(p => p.DepartmentId == DepartmentId && p.UserId == UserId);
            return userDepartman != null ? true : false;
        }

        public async Task<IResultData<List<UserDepartmentPermission>>> GetAllList()
        {
            var data = await _userDepartmentPermissionDal.GetAllList();
            return new SuccessResultData<List<UserDepartmentPermission>>(data);
        }

        public async Task<IResultData<UserDepartmentPermission>> GetById(Guid Id)
        {
            return new SuccessResultData<UserDepartmentPermission>(await _userDepartmentPermissionDal.Get(p => p.UserDepartmentPermissionId == Id));
        }

        public async Task<IResultData<List<UserDepartmentPermission>>> GetByUserIdUserDepartment(Guid UserId)
        {
            var data = (await _userDepartmentPermissionDal.GetWhere(p => p.UserId == UserId));
            return new SuccessResultData<List<UserDepartmentPermission>>(data);
        }

        public async Task<IResult> Remove(UserDepartmentPermission data)
        {
            await _userDepartmentPermissionDal.Delete(data);
            return new SuccessResult(data.UserDepartmentPermissionId);
        }

        public async Task<IResult> Update(UserDepartmentPermission data)
        {
            await _userDepartmentPermissionDal.Update(data);
            return new SuccessResult(data.UserDepartmentPermissionId);
        }
    }
}
