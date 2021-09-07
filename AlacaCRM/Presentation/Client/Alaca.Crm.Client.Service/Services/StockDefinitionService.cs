
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
    public class StockUnitDefinitionService : IStockUnitDefinitionService
    {
        HttpClient _httpClient;
        public StockUnitDefinitionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(StockUnitDefinition)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockUnitDefinition[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockUnitDefinition)}/GetAll");
            return await response.ToResultAsync<StockUnitDefinition[]>();
        }

        public async Task<IResultData<StockUnitDefinition>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockUnitDefinition)}/GetById?id={id}");
            return await response.ToResultAsync<StockUnitDefinition>();
        }

        public async Task<IResult> Insert(StockUnitDefinition data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockUnitDefinition)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockUnitDefinition data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockUnitDefinition)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

