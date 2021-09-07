
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
    public class StockService : IStockService
    {
        HttpClient _httpClient;
        public StockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Stock)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Stock[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Stock)}/GetAll");
            return await response.ToResultAsync<Stock[]>();
        }

        public async Task<IResultData<Stock>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Stock)}/GetById?id={id}");
            return await response.ToResultAsync<Stock>();
        }

        public async Task<IResult> Insert(Stock data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Stock)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Stock data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Stock)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

