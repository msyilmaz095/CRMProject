
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using Alaca.Entities.Dto;
using System.Net.Http.Json;

namespace Alaca.Crm.Client.Service.Services
{
    public class ProjectService : IProjectService
    {
        HttpClient _httpClient;
        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Project)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Project[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetAll");
            return await response.ToResultAsync<Project[]>();
        }

        public async Task<IResultData<Project[]>> GetByCustomerIdProject(Guid CustomerId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetByCustomerIdProject?CustomerId={CustomerId}");
            return await response.ToResultAsync<Project[]>();
        }

        public async Task<IResultData<viewProject[]>> GetByDateTimeBetweenviewProjects(DateTime StartDate, DateTime EndDate)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetByDateTimeBetweenviewProjects?StartDate={string.Format("{0:yyyy-MM-dd}",StartDate)}&EndDate={string.Format("{0:yyyy-MM-dd HH:mm}", EndDate)}");
            return await response.ToResultAsync<viewProject[]>();
        }

        public async Task<IResultData<viewProject[]>> GetOrderDescTop10viewProjects()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetOrderDescTop10viewProjects");
            return await response.ToResultAsync<viewProject[]>();
        }

        public async Task<IResultData<Project>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetById?id={id}");
            return await response.ToResultAsync<Project>();
        }

        public async Task<IResultData<viewProject[]>> GetviewProjects()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Project)}/GetviewProjects");
            return await response.ToResultAsync<viewProject[]>();
        }

        public async Task<IResult> Insert(Project data)
        {
            Console.WriteLine($"api/{nameof(Project)}/insert");
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Project)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Project data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Project)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

