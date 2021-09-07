
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
    public class StoreService : IStoreService
    {
        HttpClient _httpClient;
        public StoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Store)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Store[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Store)}/GetAll");
            return await response.ToResultAsync<Store[]>();
        }

        public async Task<IResultData<Store>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Store)}/GetById?id={id}");
            return await response.ToResultAsync<Store>();
        }

        public async Task<IResult> Insert(Store data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Store)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Store data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Store)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

