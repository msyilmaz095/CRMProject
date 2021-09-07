
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class CustomerRelationService : ICustomerRelationService
    {
        HttpClient _httpClient;
        public CustomerRelationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/CustomerRelation/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<CustomerRelation[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/CustomerRelation/GetAll");
            return await response.ToResultAsync<CustomerRelation[]>();
        }

        public async Task<IResultData<CustomerRelation>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/CustomerRelation/GetById?id={id}");
            return await response.ToResultAsync<CustomerRelation>();
        }

        public async Task<IResult> Insert(CustomerRelation data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerRelation/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(CustomerRelation data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CustomerRelation/update", data);
            return await response.ToResultAsync();
        }
    }
}
