using Alaca.Core.Entities;
using Alaca.Core.Utilities.Authentication;
using Alaca.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alaca.Entities.Dto;
using Alaca.Entities.Concrete;
using Alaca.Core.Utilities.Security.Jwt;

namespace Alaca.CRM.Service.Abstract
{
    public interface IUserService : IBaseService<User, Guid>
    {
        Task<IResultData<AccessToken>> CreateAccessToken(User user);
        Task<IResultData<List<viewUser>>> GetviewUsers();
        Task<IResultData<User>> Login(Login login);
        Task<IResultData<User>> GetByEmployeeId(Guid EmployeeId);
    }
}
