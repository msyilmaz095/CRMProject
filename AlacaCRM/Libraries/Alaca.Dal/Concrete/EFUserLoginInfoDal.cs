using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFUserLoginInfoDal : EFEntityRepository<UserLoginInfo, Alaca_CRMContext>, IUserLoginInfoDal
    {
        public EFUserLoginInfoDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public Task<List<viewUserLoginInfo>> GetAllviewUsrLoginInfo()
        {
            using (var context = new Alaca_CRMContext())
            {
                var query = from loginInfo in context.UserLoginInfos
                            join user in context.Users on loginInfo.UserId equals user.UserId
                            select new viewUserLoginInfo()
                            {
                                CreateDate = loginInfo.CreateDate,
                                UserName = user.UserName,
                                UserId = user.UserId,
                                Ipaddress = loginInfo.Ipaddress,
                                Languages = loginInfo.Languages,
                                LogId = loginInfo.LogId,
                                UserAgent = loginInfo.UserAgent
                            };
                return Task.FromResult(query.ToList());
            }
        }
    }
}
