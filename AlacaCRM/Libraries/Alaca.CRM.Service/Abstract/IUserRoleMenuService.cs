using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IUserRoleMenuService : IBaseService<UserRoleMenu, Guid>
    {
        Task<IResultData<List<viewUserRoleMenu>>> GetViewUserRoleMenus(Guid UserRoleId);
        Task<IResultData<HashSet<Menu>>> GetByUserRoleIdMenus(Guid UserRoleId);
        Task<IResult> SetUserRoleMenu(Guid UserRoleId, HashSet<Menu> lstMenu);
    }
}
