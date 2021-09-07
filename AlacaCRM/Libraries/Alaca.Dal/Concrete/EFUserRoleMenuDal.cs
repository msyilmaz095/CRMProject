using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFUserRoleMenuDal : EFEntityRepository<UserRoleMenu, Alaca_CRMContext>, IUserRoleMenuDal
    {
        public EFUserRoleMenuDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public Task<List<viewUserRoleMenu>> GetViewUserRoleMenus(Guid UserRoleId)
        {
            using (var context = new Alaca_CRMContext())
            {
                var query = from menu in context.Menus
                            join userrolemenu in context.UserRoleMenus on
                            new { MenuId = menu.MenuId, UserRoleId = UserRoleId } equals new { MenuId = userrolemenu.MenuId, UserRoleId = userrolemenu.UserRoleId }
                            //menu.MenuId equals userrolemenu.MenuId //&& user
                            into usermenurolegroup
                            from menuuserrole in usermenurolegroup.DefaultIfEmpty()
                            select new viewUserRoleMenu()
                            {
                                UserRoleMenuId = menuuserrole.UserRoleMenuId,
                                UserRoleId = menuuserrole.UserRoleId,
                                MenuId = menu.MenuId,
                                IsActive = menuuserrole == null ? false : true,
                                Description = menu.Description,
                                MenuName = menu.MenuName
                            };
                return Task.FromResult(query.ToList());
            }
        }

        public Task<HashSet<Menu>> GetByUserRoleIdMenus(Guid UserRoleId)
        {
            using (var context = new Alaca_CRMContext())
            {
                return Task.FromResult(context.UserRoleMenus.Where(p => p.UserRoleId == UserRoleId).Include(p=>p.Menu.MenuItem).Select(x => x.Menu).ToHashSet());
            }
        }
    }
}
