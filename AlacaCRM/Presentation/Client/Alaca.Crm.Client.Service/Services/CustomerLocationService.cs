
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;
using System;
using System.Collections.Generic;

namespace Alaca.Crm.Client.Service.Services
{
    public class CustomerLocationService : ICustomerLocationService
    {
        HttpClient _httpClient;
        public CustomerLocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResultData<CustomerLocation[]>> GetLocationByCustomerIdAll(Guid? id)
        {
            var response = await _httpClient.GetAsync($"api/CustomerLocation/GetLocationByCustomerIdAll?id={id}");
            return await response.ToResultAsync<CustomerLocation[]>();
        }
        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/CustomerLocation/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<CustomerLocation[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/CustomerLocation/GetAll");
            return await response.ToResultAsync<CustomerLocation[]>();
        }

        public async Task<IResultData<CustomerLocation>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/CustomerLocation/GetById?id={id}");
            return await response.ToResultAsync<CustomerLocation>();
        }


        public async Task<IResult> Insert(CustomerLocation data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerLocation/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(CustomerLocation data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerLocation/update", data);
            return await response.ToResultAsync();
        }
    }
}
