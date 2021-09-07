
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
    public class CustomerService : ICustomerService
    {
        HttpClient _httpClient;
        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Customer/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Customer[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Customer/GetAll");
            return await response.ToResultAsync<Customer[]>();
        }

        public async Task<IResultData<Customer>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Customer/GetById?id={id}");
            return await response.ToResultAsync<Customer>();
        }

        public async Task<IResultData<List<CustomerLocation>>> GetLocationByCustomerIdAll(Guid id)
        {
            //_httpClient.DefaultRequestHeaders.
            var response = await _httpClient.GetAsync("api/Customer/GetLocationByCustomerIdAll");
            return await response.ToResultAsync<List<CustomerLocation>>();
        }

        public async Task<IResult> Insert(Customer data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Customer/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Customer data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Customer/update", data);
            return await response.ToResultAsync();
        }
    }
}
