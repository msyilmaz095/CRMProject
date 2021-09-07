
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
    public class FactoryService : IFactoryService
    {
        HttpClient _httpClient;
        public FactoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Factory)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Factory[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Factory)}/GetAll");
            return await response.ToResultAsync<Factory[]>();
        }

        public async Task<IResultData<Factory>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Factory)}/GetById?id={id}");
            return await response.ToResultAsync<Factory>();
        }

        public async Task<IResult> Insert(Factory data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Factory)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Factory data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Factory)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

