
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace Alaca.Crm.Client.Service.Services
{
    public class ContactService : IContactService
    {
        HttpClient _httpClient;
        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Contact/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Contact[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Contact/GetAll");
            return await response.ToResultAsync<Contact[]>();
        }

        public async Task<IResultData<Contact>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Contact/GetById?id={id}");
            return await response.ToResultAsync<Contact>();
        }

        public async Task<IResultData<List<Contact>>> GetContactByCustomerIdAll(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Contact/GetContactByCustomerIdAll?id={id}");
            return await response.ToResultAsync<List<Contact>>();
        }

        public async Task<IResult> Insert(Contact data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Contact/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Contact data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Contact/update", data);
            return await response.ToResultAsync();
        }
    }
}
