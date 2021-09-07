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
    public class ConfigurationService : IConfigurationService
    {
        HttpClient _httpClient;
        public ConfigurationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Configuration/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Configuration[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Configuration/GetAll");
            return await response.ToResultAsync<Configuration[]>();
        }

        public async Task<IResultData<Configuration>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Configuration/GetById?id={id}");
            return await response.ToResultAsync<Configuration>();
        }
        public async Task<IResultData<Configuration>> GetById(string id)
        {
            var response = await _httpClient.GetAsync($"api/Configuration/GetByIdString?id={id}");
            return await response.ToResultAsync<Configuration>();
        }
        public async Task<IResult> Delete(string id)
        {
            var response = await _httpClient.DeleteAsync($"api/Configuration/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResult> Insert(Configuration data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Configuration/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Configuration data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Configuration/update", data);
            return await response.ToResultAsync();
        }
    }
}
