
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using System.Net.Http.Json;

namespace Alaca.Crm.Client.Service.Services
{
    public class ProjectStatuService : IProjectStatuService
    {
        HttpClient _httpClient;
        public ProjectStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(byte id)
        {
            var response = await _httpClient.DeleteAsync($"api/ProjectStatu/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ProjectStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/ProjectStatu/GetAll");
            return await response.ToResultAsync<ProjectStatu[]>();
        }

        public async Task<IResultData<ProjectStatu>> GetById(byte id)
        {
            var response = await _httpClient.GetAsync($"api/ProjectStatu/GetById?id={id}");
            return await response.ToResultAsync<ProjectStatu>();
        }

        public async Task<IResult> Insert(ProjectStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ProjectStatu/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ProjectStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ProjectStatu/update", data);
            return await response.ToResultAsync();
        }
    }
}

