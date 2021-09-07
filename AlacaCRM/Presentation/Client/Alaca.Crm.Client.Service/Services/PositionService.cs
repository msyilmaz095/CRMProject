
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using Microsoft.AspNetCore.Components;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class PositionService : IPositionService
    {
        HttpClient _httpClient;
        public PositionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Position/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Position[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Position/GetAll");
            return await response.ToResultAsync<Position[]>();
        }

        public async Task<IResultData<Position>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Position/GetById?id={id}");
            return await response.ToResultAsync<Position>();
        }

        public async Task<IResult> Insert(Position data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Position/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Position data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Position/update", data);
            return await response.ToResultAsync();
        }
    }
}
