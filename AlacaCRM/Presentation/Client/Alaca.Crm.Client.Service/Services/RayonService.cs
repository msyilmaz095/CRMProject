
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
    public class RayonService : IRayonService
    {
        HttpClient _httpClient;
        public RayonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(Rayon)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Rayon[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Rayon)}/GetAll");
            return await response.ToResultAsync<Rayon[]>();
        }

        public async Task<IResultData<Rayon>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(Rayon)}/GetById?id={id}");
            return await response.ToResultAsync<Rayon>();
        }

        public async Task<IResult> Insert(Rayon data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Rayon)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Rayon data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(Rayon)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

