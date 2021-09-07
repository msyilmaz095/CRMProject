
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
    public class ContactTypeService : IContactTypeService
    {
        HttpClient _httpClient;
        public ContactTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ContactType/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ContactType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/ContactType/GetAll");
            return await response.ToResultAsync<ContactType[]>();
        }

        public async Task<IResultData<ContactType>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/ContactType/GetById?id={id}");
            return await response.ToResultAsync<ContactType>();
        }

        public async Task<IResult> Insert(ContactType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ContactType/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ContactType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ContactType/update", data);
            return await response.ToResultAsync();
        }
    }
}
