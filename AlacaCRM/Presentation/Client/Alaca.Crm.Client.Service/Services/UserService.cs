
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using Microsoft.AspNetCore.Components;
using Alaca.Core.Entities;
using Alaca.Entities.Dto;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class UserService: IUserService
    {
        HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Users/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<User[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Users/GetAll");
            return await response.ToResultAsync<User[]>();
        }

        public async Task<IResultData<viewUserLoginInfo[]>> GetAllUserLoginInfo()
        {
            var response = await _httpClient.GetAsync("api/Users/GetAllUserLoginInfo");
            return await response.ToResultAsync<viewUserLoginInfo[]>();
        }

        public async Task<IResultData<viewUser[]>> GetAllviewUser()
        {
            var response = await _httpClient.GetAsync("api/Users/GetAllViewUsers");
            return await response.ToResultAsync<viewUser[]>();
        }

        public async Task<IResultData<User>> GetByEmployeeId(Guid EmployeeId)
        {
            var response = await _httpClient.GetAsync($"api/Users/GetByEmployeeId?EmployeeId={EmployeeId}");
            return await response.ToResultAsync<User>();
        }

        public async Task<IResultData<User>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Users/GetById?id={id}");
            return await response.ToResultAsync<User>();
        }

        public async Task<IResult> Insert(User data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Users/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(User data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Users/update", data);
            return await response.ToResultAsync();
        }
    }
}
