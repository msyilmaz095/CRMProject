
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
    public class UnitService : IUnitService
    {
        HttpClient _httpClient;
        public UnitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Unit)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Unit[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Unit)}/GetAll");
            return await response.ToResultAsync<Unit[]>();
        }

        public async Task<IResultData<Unit>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Unit)}/GetById?id={id}");
            return await response.ToResultAsync<Unit>();
        }

        public async Task<IResult> Insert(Unit data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Unit)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Unit data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Unit)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

