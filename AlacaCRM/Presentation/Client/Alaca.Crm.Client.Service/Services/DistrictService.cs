
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class DistrictService : IDistrictService
    {
        HttpClient _httpClient;
        public DistrictService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/District/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<District[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/District/GetAll");
            return await response.ToResultAsync<District[]>();
        }

        public async Task<IResultData<District>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/District/GetById?id={id}");
            return await response.ToResultAsync<District>();
        }

        public async Task<IResult> Insert(District data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/District/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(District data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/District/update", data);
            return await response.ToResultAsync();
        }
    }
}
