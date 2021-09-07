
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
    public class DepartmentService : IDepartmentService
    {
        HttpClient _httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Department/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Department[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Department/GetAll");
            return await response.ToResultAsync<Department[]>();
        }

        public async Task<IResultData<Department>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Department/GetById?id={id}");
            return await response.ToResultAsync<Department>();
        }

        public async Task<IResult> Insert(Department data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Department/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Department data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Department/update", data);
            return await response.ToResultAsync();
        }
    }
}
