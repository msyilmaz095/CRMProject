
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
    public class ActivityTypeService : IActivityTypeService
    {
        HttpClient _httpClient;
        public ActivityTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ActivityType/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ActivityType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/ActivityType/GetAll");
            return await response.ToResultAsync<ActivityType[]>();
        }

        public async Task<IResultData<ActivityType>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/ActivityType/GetById?id={id}");
            return await response.ToResultAsync<ActivityType>();
        }

        public async Task<IResult> Insert(ActivityType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ActivityType/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ActivityType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ActivityType/update", data);
            return await response.ToResultAsync();
        }
    }
}
