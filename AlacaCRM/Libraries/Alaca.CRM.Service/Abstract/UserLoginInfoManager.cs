using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;

namespace Alaca.CRM.Service.Abstract
{
    public class UserLoginInfoManager : IUserLoginInfoService
    {
        IUserLoginInfoDal _userLoginInfoDal;
        public UserLoginInfoManager(IUserLoginInfoDal userLoginInfoDal)
        {
            _userLoginInfoDal = userLoginInfoDal;
        }
        public async Task<IResult> Add(UserLoginInfo data)
        {
            await _userLoginInfoDal.Insert(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<UserLoginInfo>>> GetAllList()
        {
            var data = await _userLoginInfoDal.GetAllList();
            return new SuccessResultData<List<UserLoginInfo>>(data);
        }

        public async Task<IResultData<List<viewUserLoginInfo>>> GetAllviewUsrLoginInfo()
        {
            var data = await _userLoginInfoDal.GetAllviewUsrLoginInfo();
            return new SuccessResultData<List<viewUserLoginInfo>>(data);
        }

        public async Task<IResultData<UserLoginInfo>> GetById(Guid Id)
        {
            return new SuccessResultData<UserLoginInfo>(await _userLoginInfoDal.Get(p => p.LogId == Id));
        }

        public async Task<IResult> Remove(UserLoginInfo data)
        {
            await _userLoginInfoDal.Delete(data);
            return new SuccessResult();
        }

        public async Task<IResult> Update(UserLoginInfo data)
        {
            await _userLoginInfoDal.Update(data);
            return new SuccessResult();
        }
    }
}
