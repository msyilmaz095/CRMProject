using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IUserRoleMenuDal : IEntityRepository<UserRoleMenu>
    {
        public Task<List<viewUserRoleMenu>> GetViewUserRoleMenus(Guid UserRoleId);
        public Task<HashSet<Menu>> GetByUserRoleIdMenus(Guid UserRoleId);
    }
}
