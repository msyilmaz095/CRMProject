
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using Microsoft.AspNetCore.Components;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class CurrencyService : ICurrencyService
    {
        HttpClient _httpClient;
        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Currency/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Currency[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Currency/GetAll");
            return await response.ToResultAsync<Currency[]>();
        }

        public async Task<IResultData<Currency>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Currency/GetById?id={id}");
            return await response.ToResultAsync<Currency>();
        }

        public async Task<IResult> Insert(Currency data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Currency/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Currency data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Currency/update", data);
            return await response.ToResultAsync();
        }
    }
}
