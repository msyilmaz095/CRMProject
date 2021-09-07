
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
    public class ContactStatuService : IContactStatuService
    {
        HttpClient _httpClient;
        public ContactStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ContactStatu/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ContactStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/ContactStatu/GetAll");
            return await response.ToResultAsync<ContactStatu[]>();
        }

        public async Task<IResultData<ContactStatu>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/ContactStatu/GetById?id={id}");
            return await response.ToResultAsync<ContactStatu>();
        }

        public async Task<IResult> Insert(ContactStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ContactStatu/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ContactStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ContactStatu/update", data);
            return await response.ToResultAsync();
        }
    }
}
