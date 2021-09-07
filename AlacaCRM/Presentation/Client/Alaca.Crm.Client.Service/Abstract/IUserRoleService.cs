using Alaca.Core.Entities;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IUserRoleService : IBaseService<UserRole, Guid>
    {
        Task<IResultData<HashSet<Menu>>> GetByUserRoleIdMenus(Guid UserRoleId);
        Task<IResultData<viewUserRoleMenu[]>> GetAllUserRoleMenu(Guid UserId);
        Task<IResult> Insert(UserRole data, HashSet<Menu> lstMenu);
        Task<IResult> Update(UserRole data, HashSet<Menu> lstMenu);
    }
}
