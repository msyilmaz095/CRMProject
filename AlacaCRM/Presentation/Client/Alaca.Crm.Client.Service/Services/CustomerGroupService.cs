using Alaca.Core.Utilities.Result;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Service.Extensions;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Services
{
    public class CustomerGroupService : ICustomerGroupService
    {
        HttpClient _httpClient;
        public CustomerGroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/CustomerGroup/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<CustomerGroup[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/CustomerGroup/GetAll");
            return await response.ToResultAsync<CustomerGroup[]>();
        }

        public async Task<IResultData<CustomerGroup>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/CustomerGroup/GetById?id={id}");
            return await response.ToResultAsync<CustomerGroup>();
        }

        public async Task<IResult> Insert(CustomerGroup data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerGroup/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(CustomerGroup data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerGroup/update", data);
            return await response.ToResultAsync();
        }

    }
}
