
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
    public class StockStatuService : IStockStatuService
    {
        HttpClient _httpClient;
        public StockStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(StockStatu)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockStatu)}/GetAll");
            return await response.ToResultAsync<StockStatu[]>();
        }

        public async Task<IResultData<StockStatu>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockStatu)}/GetById?id={id}");
            return await response.ToResultAsync<StockStatu>();
        }

        public async Task<IResult> Insert(StockStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockStatu)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockStatu)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

