using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface ISubContratorTeamService : IBaseService<SubContratorTeam, Guid>
    {
        Task<IResultData<SubContratorTeam[]>> GetByCustomerIdSubContratorTeam(Guid CustomerId);
    }
}
