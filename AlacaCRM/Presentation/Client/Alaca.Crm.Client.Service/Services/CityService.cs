
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
    public class CityService : ICityService
    {
        HttpClient _httpClient;
        public CityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/City/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<City[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/City/GetAll");
            return await response.ToResultAsync<City[]>();
        }

        public async Task<IResultData<City>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/City/GetById?id={id}");
            return await response.ToResultAsync<City>();
        }

        public async Task<IResult> Insert(City data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/City/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(City data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/City/update", data);
            return await response.ToResultAsync();
        }
    }
}

