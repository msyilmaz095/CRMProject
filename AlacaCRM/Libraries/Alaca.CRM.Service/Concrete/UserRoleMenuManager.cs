using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Linq;
using System;

namespace Alaca.CRM.Service.Concrete
{
    public class UserRoleMenuManager : IUserRoleMenuService
    {
        IUserRoleMenuDal _userRoleMenuDal;
        public UserRoleMenuManager(IUserRoleMenuDal userRoleMenuDal)
        {
            _userRoleMenuDal = userRoleMenuDal;
        }
        public async Task<IResult> Add(UserRoleMenu data)
        {
            await _userRoleMenuDal.Insert(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<UserRoleMenu>>> GetAllList()
        {
            var data = await _userRoleMenuDal.GetAllList();
            return new SuccessResultData<List<UserRoleMenu>>(data);
        }

        public async Task<IResultData<UserRoleMenu>> GetById(Guid Id)
        {
            return new SuccessResultData<UserRoleMenu>(await _userRoleMenuDal.Get(p => p.UserRoleMenuId == Id));
        }

        public async Task<IResult> Remove(UserRoleMenu data)
        {
            await _userRoleMenuDal.Delete(data);
            return new SuccessResult();
        }

        public async Task<IResult> SetUserRoleMenu(Guid UserRoleId, HashSet<Menu> lstMenu)
        {
            var lstIds = lstMenu.Select(col => col.MenuId).ToList();
            foreach (var item in await _userRoleMenuDal.GetWhere(p => p.UserRoleId == UserRoleId && !lstIds.Contains(p.MenuId)))
            {
                await _userRoleMenuDal.Delete(item);
            }
            foreach (var item in lstMenu)
            {
                var menu = await _userRoleMenuDal.Get(p => p.UserRoleId == UserRoleId && p.MenuId == item.MenuId);
                if (menu == null)
                    await _userRoleMenuDal.Insert(new UserRoleMenu() { MenuId = item.MenuId, UserRoleId = UserRoleId });
            }
            return new SuccessResult();
        }

        public async Task<IResult> Update(UserRoleMenu data)
        {
            await _userRoleMenuDal.Update(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<viewUserRoleMenu>>> GetViewUserRoleMenus(Guid UserRoleId)
        {

            return new SuccessResultData<List<viewUserRoleMenu>>(await _userRoleMenuDal.GetViewUserRoleMenus(UserRoleId));
        }

        public async Task<IResultData<HashSet<Menu>>> GetByUserRoleIdMenus(Guid UserRoleId)
        {
            var lstMenu = (await _userRoleMenuDal.GetByUserRoleIdMenus(UserRoleId)).Where(p => p.MenuItem != null).GroupBy(p => p.MenuItem).Select(col => col.Key).ToHashSet();
            return new SuccessResultData<HashSet<Menu>>(lstMenu);
        }
    }
}
