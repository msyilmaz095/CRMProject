
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
    public class StockBarcodeService : IStockBarcodeService
    {
        HttpClient _httpClient;
        public StockBarcodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(StockBarcode)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<StockBarcode[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockBarcode)}/GetAll");
            return await response.ToResultAsync<StockBarcode[]>();
        }

        public async Task<IResultData<StockBarcode>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockBarcode)}/GetById?id={id}");
            return await response.ToResultAsync<StockBarcode>();
        }

        public async Task<IResultData<StockBarcode[]>> GetByStockIdStockBarcode(Guid? StockId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(StockBarcode)}/GetByStockIdStockBarcode?StockId={StockId}");
            return await response.ToResultAsync<StockBarcode[]>();
        }

        public async Task<IResult> Insert(StockBarcode data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockBarcode)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(StockBarcode data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(StockBarcode)}/update", data);
            return await response.ToResultAsync();
        }

    }
}

