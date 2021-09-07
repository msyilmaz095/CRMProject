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
    public class EmployeeService : IEmployeeService
    {
        HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Employee/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Employee[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Employee/GetAll");
            return await response.ToResultAsync<Employee[]>();
        }

        public async Task<IResultData<Employee>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Employee/GetById?id={id}");
            return await response.ToResultAsync<Employee>();
        }

        public async Task<IResult> Insert(Employee data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Employee/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Employee data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Employee/update", data);
            return await response.ToResultAsync();
        }
    }
}
