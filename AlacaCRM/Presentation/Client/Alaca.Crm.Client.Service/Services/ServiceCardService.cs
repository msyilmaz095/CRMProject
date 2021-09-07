
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
    public class ServiceCardService : IServiceCardService
    {
        HttpClient _httpClient;
        public ServiceCardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(ServiceCard)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ServiceCard[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ServiceCard)}/GetAll");
            return await response.ToResultAsync<ServiceCard[]>();
        }

        public async Task<IResultData<ServiceCard>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ServiceCard)}/GetById?id={id}");
            return await response.ToResultAsync<ServiceCard>();
        }

        public async Task<IResult> Insert(ServiceCard data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ServiceCard)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ServiceCard data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ServiceCard)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

