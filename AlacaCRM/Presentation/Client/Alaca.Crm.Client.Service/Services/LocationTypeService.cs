
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
    public class LocationTypeService : ILocationTypeService
    {
        HttpClient _httpClient;
        public LocationTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/LocationType/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<LocationType[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/LocationType/GetAll");
            return await response.ToResultAsync<LocationType[]>();
        }

        public async Task<IResultData<LocationType>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/LocationType/GetById?id={id}");
            return await response.ToResultAsync<LocationType>();
        }

        public async Task<IResult> Insert(LocationType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/LocationType/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(LocationType data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/LocationType/update", data);
            return await response.ToResultAsync();
        }
    }
}
