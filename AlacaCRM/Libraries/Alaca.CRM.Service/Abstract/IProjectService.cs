using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IProjectService : IBaseService<Project, Guid>
    {
        Task<IResultData<List<viewProject>>> GetviewProjects();
        Task<IResultData<List<viewProject>>> GetOrderDescTop10viewProjects();
        Task<IResultData<List<viewProject>>> GetByDateTimeBetweenviewProjects(DateTime StartDate, DateTime EndDate);
        Task<IResultData<List<Project>>> GetByCustomerIdProject(Guid CustomerId);
    }
}
