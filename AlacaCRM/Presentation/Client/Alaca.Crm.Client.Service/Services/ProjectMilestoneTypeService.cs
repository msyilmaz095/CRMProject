
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;

namespace Alaca.Crm.Client.Service.Services
{
    public class ProjectMilestoneTypeService : IProjectMilestoneTypeService
    {
        HttpClient _httpClient;
        public ProjectMilestoneTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(byte id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(ProjectMilestoneType)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ProjectMilestoneType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestoneType)}/GetAll");
            return await response.ToResultAsync<ProjectMilestoneType[]>();
        }

        public async Task<IResultData<ProjectMilestoneType>> GetById(byte id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestoneType)}/GetById?id={id}");
            return await response.ToResultAsync<ProjectMilestoneType>();
        }

        public async Task<IResult> Insert(ProjectMilestoneType data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestoneType)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ProjectMilestoneType data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestoneType)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

