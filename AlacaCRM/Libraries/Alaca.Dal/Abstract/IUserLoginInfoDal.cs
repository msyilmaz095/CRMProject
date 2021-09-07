using Alaca.Core.DataAccess;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IUserLoginInfoDal : IEntityRepository<UserLoginInfo>
    {
        public Task<List<viewUserLoginInfo>> GetAllviewUsrLoginInfo();
    }
}
