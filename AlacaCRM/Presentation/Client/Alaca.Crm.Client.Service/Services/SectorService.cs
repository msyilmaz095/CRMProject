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
    public class SectorService : ISectorService
    {
        HttpClient _httpClient;
        public SectorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Sector/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Sector[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Sector/GetAll");
            return await response.ToResultAsync<Sector[]>();
        }

        public async Task<IResultData<Sector>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Sector/GetById?id={id}");
            return await response.ToResultAsync<Sector>();
        }

        public async Task<IResult> Insert(Sector data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Sector/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Sector data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Sector/update", data);
            return await response.ToResultAsync();
        }
    }
}
