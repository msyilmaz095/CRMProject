
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
    public class StockGroupService : IStockGroupService
    {
        HttpClient _httpClient;
        public StockGroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(StockGroup)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockGroup[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockGroup)}/GetAll");
            return await response.ToResultAsync<StockGroup[]>();
        }

        public async Task<IResultData<StockGroup>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockGroup)}/GetById?id={id}");
            return await response.ToResultAsync<StockGroup>();
        }

        public async Task<IResult> Insert(StockGroup data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockGroup)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockGroup data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockGroup)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

