using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface ISubContratorTeamService : IBaseService<SubContratorTeam, Guid>
    {
        Task<IResultData<List<SubContratorTeam>>> GetByCustomerIdSubContratorTeam(Guid CustomerId);
    }
}
