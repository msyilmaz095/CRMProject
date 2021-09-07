using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _userRoleDal;
        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }
        public async Task<IResult> Add(UserRole data)
        {
            await _userRoleDal.Insert(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<UserRole>>> GetAllList()
        {
            var data = await _userRoleDal.GetAllList();
            return new SuccessResultData<List<UserRole>>(data);
        }

        public async Task<IResultData<UserRole>> GetById(Guid Id)
        {
            return new SuccessResultData<UserRole>(await _userRoleDal.Get(p => p.UserRoleId == Id));
        }

        public async Task<IResult> Remove(UserRole data)
        {
            await _userRoleDal.Delete(data);
            return new SuccessResult();
        }

        public async Task<IResult> Update(UserRole data)
        {
            await _userRoleDal.Update(data);
            return new SuccessResult();
        }
    }
}
