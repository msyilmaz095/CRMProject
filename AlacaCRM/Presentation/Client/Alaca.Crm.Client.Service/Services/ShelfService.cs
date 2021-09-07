
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
    public class ShelfService : IShelfService
    {
        HttpClient _httpClient;
        public ShelfService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Shelf)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Shelf[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Shelf)}/GetAll");
            return await response.ToResultAsync<Shelf[]>();
        }

        public async Task<IResultData<Shelf>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Shelf)}/GetById?id={id}");
            return await response.ToResultAsync<Shelf>();
        }

        public async Task<IResult> Insert(Shelf data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Shelf)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Shelf data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Shelf)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

