
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
    public class StockUnitService : IStockUnitService
    {
        HttpClient _httpClient;
        public StockUnitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(StockUnit)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockUnit[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockUnit)}/GetAll");
            return await response.ToResultAsync<StockUnit[]>();
        }

        public async Task<IResultData<StockUnit>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockUnit)}/GetById?id={id}");
            return await response.ToResultAsync<StockUnit>();
        }

        public async Task<IResultData<StockUnit[]>> GetByStockIdStockUnit(Guid? StockId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockUnit)}/GetByStockIdStockUnit?StockId={StockId}");
            return await response.ToResultAsync<StockUnit[]>();
        }

        public async Task<IResult> Insert(StockUnit data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockUnit)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockUnit data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockUnit)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

