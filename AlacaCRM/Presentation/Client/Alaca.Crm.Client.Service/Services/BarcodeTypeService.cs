
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
    public class BarcodeTypeService : IBarcodeTypeService
    {
        HttpClient _httpClient;
        public BarcodeTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/BarcodeType/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<BarcodeType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/BarcodeType/GetAll");
            return await response.ToResultAsync<BarcodeType[]>();
        }

        public async Task<IResultData<BarcodeType>> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/BarcodeType/GetById?id={id}");
            return await response.ToResultAsync<BarcodeType>();
        }

        public async Task<IResult> Insert(BarcodeType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/BarcodeType/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(BarcodeType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/BarcodeType/update", data);
            return await response.ToResultAsync();
        }
    }
}

