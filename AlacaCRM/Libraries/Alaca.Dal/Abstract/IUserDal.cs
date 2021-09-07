using Alaca.Core.DataAccess;
using Alaca.Core.Entities;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Entities.Dto;

namespace Alaca.Crm.Dal.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        Task<List<viewUser>> GetViewUsers();
    }
}
