
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
    public class ProjectDocumentService : IProjectDocumentService
    {
        HttpClient _httpClient;
        public ProjectDocumentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ProjectDocument/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ProjectDocument[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/ProjectDocument/GetAll");
            return await response.ToResultAsync<ProjectDocument[]>();
        }

        public async Task<IResultData<ProjectDocument>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/ProjectDocument/GetById?id={id}");
            return await response.ToResultAsync<ProjectDocument>();
        }

        public async Task<IResult> Insert(ProjectDocument data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ProjectDocument/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ProjectDocument data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ProjectDocument/update", data);
            return await response.ToResultAsync();
        }
    }
}

