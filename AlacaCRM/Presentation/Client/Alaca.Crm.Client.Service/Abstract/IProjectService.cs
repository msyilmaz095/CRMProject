using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IProjectService : IBaseService<Project, Guid>
    {
        Task<IResultData<viewProject[]>> GetOrderDescTop10viewProjects();
        Task<IResultData<viewProject[]>> GetviewProjects();
        Task<IResultData<Project[]>> GetByCustomerIdProject(Guid CustomerId);
        Task<IResultData<viewProject[]>> GetByDateTimeBetweenviewProjects(DateTime StartDate, DateTime EndDate);
    }
}
