
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
    public class CompanyService : ICompanyService
    {
        HttpClient _httpClient;
        public CompanyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Company/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Company[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Company/GetAll");
            return await response.ToResultAsync<Company[]>();
        }

        public async Task<IResultData<Company>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Company/GetById?id={id}");
            return await response.ToResultAsync<Company>();
        }

        public async Task<IResult> Insert(Company data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Company/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Company data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Company/update", data);
            return await response.ToResultAsync();
        }
    }
}
