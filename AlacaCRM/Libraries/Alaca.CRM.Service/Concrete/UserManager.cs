using Alaca.Core.DataAccess;
using Alaca.Core.Entities;
using Alaca.Core.Utilities.Authentication;
using Alaca.Core.Utilities.Result;
using Alaca.Core.Utilities.Security.Jwt;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Alaca.CRM.Service.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IUserDepartmentPermissionService _userDepartmentPermissionService;
        IUserRoleMenuService _userRoleMenuService;
        private ITokenHelper _tokenHelper;
        public UserManager(IUserDal userDal, IUserDepartmentPermissionService userDepartmentPermissionService,
            ITokenHelper tokenHelper, IUserRoleMenuService userRoleMenuService)
        {
            _userRoleMenuService = userRoleMenuService;
            _tokenHelper = tokenHelper;
            _userDal = userDal;
            _userDepartmentPermissionService = userDepartmentPermissionService;
        }

        public async Task<IResult> Add(User data)
        {
            await _userDal.Insert(data);
            await SaveUserDepartment(data.UserId, data.UserDepartmentPermissions.ToList());
            return new SuccessResult("Kullanıcı Eklendi.");
        }

        public async Task<IResultData<List<User>>> GetAllList()
        {
            var data = await _userDal.GetAllList();
            return new SuccessResultData<List<User>>(data.Count.ToString(), data);
        }

        public async Task<IResultData<User>> GetByEmployeeId(Guid EmployeeId)
        {
            return new SuccessResultData<User>(await _userDal.Get(p => p.EmployeeId == EmployeeId));
        }

        public async Task<IResultData<User>> GetById(Guid Id)
        {
            return new SuccessResultData<User>(await _userDal.Get(p => p.UserId == Id));
        }

        public async Task<IResultData<List<viewUser>>> GetviewUsers()
        {
            var data = await _userDal.GetViewUsers();
            return new SuccessResultData<List<viewUser>>(data);
        }

        public async Task<IResultData<User>> Login(Login login)
        {
            var data = await _userDal.Get(p => p.Email == login.Email && p.Password == login.Password);
            if (data == null)
            {
                return new FailedResultData<User>();
            }
            data.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            return new SuccessResultData<User>(data);
        }

        public async Task<IResult> Remove(User data)
        {
            int Sonuc = await _userDal.Delete(data);
            if (Sonuc > 0)
            {
                return new SuccessResult("Kullanıcı Silindi.");
            }
            else
            {
                return new FailedResult("Kullanıcı Silinemedi.");
            }
        }

        public async Task<IResult> Update(User data)
        {
            int Sonuc = await _userDal.Update(data);
            if (Sonuc > 0)
            {
                await SaveUserDepartment(data.UserId, data.UserDepartmentPermissions.ToList());
                return new SuccessResult("Kullanıcı Güncellendi.");
            }
            else
            {
                return new FailedResult("Kullanıcı Güncellenemedi.");
            }
        }

        public async Task<IResult> SaveUserDepartment(Guid UserId, List<UserDepartmentPermission> userDepartmentPermissions)
        {
            //userDepartmentPermissions gelen liste User Kaydında yada güncellemesinde Kullanıcıların yetkili olduğu departmanları gönderir
            foreach (var item in userDepartmentPermissions)
            {
                item.UserId = UserId;
                //Burada UserId ve DepatmentId ye göre kontrol yapılır yok ise kayıt yapılır var ise güncelleme yapmasına gerek yoktur
                if (!await _userDepartmentPermissionService.CheckByUserDepartmentControl(UserId, (Guid)item.DepartmentId))
                    await _userDepartmentPermissionService.Add(item);
            }
            #region UserDepartmentDeleteCheck
            //Bu kod bloğunda UserDepartment tablosunda olup userDepartmentPermissions listesinde yoksa silinecek satırlar
            var lstUserDepartment = await _userDepartmentPermissionService.GetByUserIdUserDepartment(UserId);
            var userDepartments = userDepartmentPermissions.Select(col => col.DepartmentId);
            foreach (var item in lstUserDepartment.Data.Where(p => !userDepartments.Contains(p.DepartmentId)))
            {
                await _userDepartmentPermissionService.Remove(item);
            }
            #endregion       
            return new SuccessResult();
        }

        public async Task<IResultData<AccessToken>> CreateAccessToken(User user)
        {
            var claims = await _userRoleMenuService.GetByUserRoleIdMenus((Guid)user.UserRoleId);
            var menus = claims.Data.Cast<MenuBase>().ToList();
            var accessToken = _tokenHelper.CreateToken(user, menus);
            return new SuccessResultData<AccessToken>("", accessToken);
        }
    }
}
