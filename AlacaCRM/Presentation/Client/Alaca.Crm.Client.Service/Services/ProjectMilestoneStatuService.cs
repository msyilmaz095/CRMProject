
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;

namespace Alaca.Crm.Client.Service.Services
{
    public class ProjectMilestoneStatuService : IProjectMilestoneStatuService
    {
        HttpClient _httpClient;
        public ProjectMilestoneStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(byte id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(ProjectMilestoneStatu)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ProjectMilestoneStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestoneStatu)}/GetAll");
            return await response.ToResultAsync<ProjectMilestoneStatu[]>();
        }

        public async Task<IResultData<ProjectMilestoneStatu>> GetById(byte id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestoneStatu)}/GetById?id={id}");
            return await response.ToResultAsync<ProjectMilestoneStatu>();
        }

        public async Task<IResult> Insert(ProjectMilestoneStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestoneStatu)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ProjectMilestoneStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestoneStatu)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

