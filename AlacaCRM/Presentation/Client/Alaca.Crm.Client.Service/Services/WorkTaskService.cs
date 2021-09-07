
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
    public class WorkTaskService : IWorkTaskService
    {
        HttpClient _httpClient;
        public WorkTaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(WorkTask)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<WorkTask[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(WorkTask)}/GetAll");
            return await response.ToResultAsync<WorkTask[]>();
        }

        public async Task<IResultData<WorkTask>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(WorkTask)}/GetById?id={id}");
            return await response.ToResultAsync<WorkTask>();
        }

        public async Task<IResult> Insert(WorkTask data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(WorkTask)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(WorkTask data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(WorkTask)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

