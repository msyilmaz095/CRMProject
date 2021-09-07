
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
    public class ZoneService : IZoneService
    {
        HttpClient _httpClient;
        public ZoneService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Zone/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Zone[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Zone/GetAll");
            return await response.ToResultAsync<Zone[]>();
        }

        public async Task<IResultData<Zone>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Zone/GetById?id={id}");
            return await response.ToResultAsync<Zone>();
        }

        public async Task<IResult> Insert(Zone data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Zone/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Zone data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Zone/update", data);
            return await response.ToResultAsync();
        }
    }
}
