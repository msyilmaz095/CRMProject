
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
    public class SubContratorTeamService : ISubContratorTeamService
    {
        HttpClient _httpClient;
        public SubContratorTeamService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/SubContratorTeam/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<SubContratorTeam[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/SubContratorTeam/GetAll");
            return await response.ToResultAsync<SubContratorTeam[]>();
        }

        public async Task<IResultData<SubContratorTeam[]>> GetByCustomerIdSubContratorTeam(Guid CustomerId)
        {
            var response = await _httpClient.GetAsync("api/SubContratorTeam/GetByCustomerIdSubContratorTeam?CustomerId"+ CustomerId);
            return await response.ToResultAsync<SubContratorTeam[]>();
        }

        public async Task<IResultData<SubContratorTeam>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/SubContratorTeam/GetById?id={id}");
            return await response.ToResultAsync<SubContratorTeam>();
        }

        public async Task<IResult> Insert(SubContratorTeam data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/SubContratorTeam/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(SubContratorTeam data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/SubContratorTeam/update", data);
            return await response.ToResultAsync();
        }
    }
}

