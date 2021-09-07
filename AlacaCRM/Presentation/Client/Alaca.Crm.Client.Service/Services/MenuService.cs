
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
    public class MenuService : IMenuService
    {
        HttpClient _httpClient;
        public MenuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Menu/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Menu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Menu/GetAll");
            return await response.ToResultAsync<Menu[]>();
        }

        public async Task<IResultData<Menu>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Menu/GetById?id={id}");
            return await response.ToResultAsync<Menu>();
        }

        public async Task<IResult> Insert(Menu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Menu/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Menu data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Menu/update", data);
            return await response.ToResultAsync();
        }
    }
}
