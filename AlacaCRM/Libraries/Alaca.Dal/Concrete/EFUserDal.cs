using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFUserDal : EFEntityRepository<User, Alaca_CRMContext>, IUserDal
    {
        public EFUserDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public override Task<User> Get(Expression<Func<User, bool>> Filter = null)
        {
            using (var context = new Alaca_CRMContext())
            {
                var data = context.Users.Include(p => p.UserDepartmentPermissions).Where(Filter).FirstOrDefault();
                return Task.FromResult<User>(data);
            }
        }
        public Task<List<viewUser>> GetViewUsers()
        {
            using (var context = new Alaca_CRMContext())
            {
                var query = (from user in context.Users
                             join role in context.UserRoles on user.UserRoleId equals role.UserRoleId into userrolegroup
                             from userrole in userrolegroup.DefaultIfEmpty()
                             join company in context.Companies on user.CompanyId equals company.CompanyId into usercompanygroup
                             from usercompany in usercompanygroup.DefaultIfEmpty()
                             select new viewUser()
                             {
                                 CompanyId = user.CompanyId,
                                 UserRoleId = user.UserRoleId,
                                 CompanyName = usercompany.CompanyName,
                                 Email = user.Email,
                                 CreateDate = user.CreateDate,
                                 CreateUser = user.CreateUser,
                                 MobilePhone = user.MobilePhone,
                                 Password = user.Password,
                                 UpdateDate = user.UpdateDate,
                                 UpdateUser = user.UpdateUser,
                                 UserCode = user.UserCode,
                                 UserId = user.UserId,
                                 UserName = user.UserName,
                                 UserRoleName = userrole.UserRoleName,
                                 UserStatusId = user.UserStatusId,
                                 UserStatusName = user.UserStatusId == 1 ? "Aktif" : "Pasif"
                             }).ToList();
                return Task.FromResult<List<viewUser>>(query);
            }
        }

    }
}
