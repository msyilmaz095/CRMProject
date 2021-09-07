
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
    public class WorkTaskTypeService : IWorkTaskTypeService
    {
        HttpClient _httpClient;
        public WorkTaskTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(WorkTaskType)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<WorkTaskType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(WorkTaskType)}/GetAll");
            return await response.ToResultAsync<WorkTaskType[]>();
        }

        public async Task<IResultData<WorkTaskType>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(WorkTaskType)}/GetById?id={id}");
            return await response.ToResultAsync<WorkTaskType>();
        }

        public async Task<IResult> Insert(WorkTaskType data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(WorkTaskType)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(WorkTaskType data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(WorkTaskType)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

