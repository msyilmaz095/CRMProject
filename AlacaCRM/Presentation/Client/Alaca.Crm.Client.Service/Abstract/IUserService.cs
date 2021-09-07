using Alaca.Core.Entities;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IUserService : IBaseService<User, Guid>
    {
        public Task<IResultData<User>> GetByEmployeeId(Guid EmployeeId);
        public Task<IResultData<viewUser[]>> GetAllviewUser();
        public Task<IResultData<viewUserLoginInfo[]>> GetAllUserLoginInfo();
    }
}
