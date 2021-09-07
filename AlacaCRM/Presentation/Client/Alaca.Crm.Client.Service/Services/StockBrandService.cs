
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
    public class StockBrandService : IStockBrandService
    {
        HttpClient _httpClient;
        public StockBrandService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/StockBrand/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockBrand[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/StockBrand/GetAll");
            return await response.ToResultAsync<StockBrand[]>();
        }

        public async Task<IResultData<StockBrand>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/StockBrand/GetById?id={id}");
            return await response.ToResultAsync<StockBrand>();
        }

        public async Task<IResult> Insert(StockBrand data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/StockBrand/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockBrand data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/StockBrand/update", data);
            return await response.ToResultAsync();
        }
    }
}

