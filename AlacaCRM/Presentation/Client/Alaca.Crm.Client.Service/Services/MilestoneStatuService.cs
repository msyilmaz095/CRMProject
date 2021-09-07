
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
    public class MilestoneStatuService : IMilestoneStatuService
    {
        HttpClient _httpClient;
        public MilestoneStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/MilestoneStatu/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<MilestoneStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/MilestoneStatu/GetAll");
            return await response.ToResultAsync<MilestoneStatu[]>();
        }

        public async Task<IResultData<MilestoneStatu>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/MilestoneStatu/GetById?id={id}");
            return await response.ToResultAsync<MilestoneStatu>();
        }

        public async Task<IResult> Insert(MilestoneStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/MilestoneStatu/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(MilestoneStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/MilestoneStatu/update", data);
            return await response.ToResultAsync();
        }
    }
}

