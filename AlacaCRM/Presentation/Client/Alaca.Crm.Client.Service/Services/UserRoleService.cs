
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
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class UserRoleService : IUserRoleService
    {
        HttpClient _httpClient;
        public UserRoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/UserRole/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<UserRole[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/UserRole/GetAll");
            return await response.ToResultAsync<UserRole[]>();
        }

        public async Task<IResultData<UserRole>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/UserRole/GetById?id={id}");
            return await response.ToResultAsync<UserRole>();
        }

        public async Task<IResult> Insert(UserRole dataUserRole, HashSet<Menu> lstMenu)
        {
            var content = JsonConvert.SerializeObject(new { userData = dataUserRole, lstMenu = lstMenu });
            var response = await _httpClient.PostAsync("api/UserRole/insert", new StringContent(content, Encoding.UTF8, "application/json"));
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(UserRole dataUserRole, HashSet<Menu> lstMenu)
        {
            var content = JsonConvert.SerializeObject(new { userData = dataUserRole, lstMenu = lstMenu });
            var response = await _httpClient.PostAsync("api/UserRole/update", new StringContent(content, Encoding.UTF8, "application/json"));
            return await response.ToResultAsync();
        }

        public async Task<IResultData<viewUserRoleMenu[]>> GetAllUserRoleMenu(Guid UserId)
        {
            var response = await _httpClient.GetAsync($"api/UserRole/GetAllUserRoleMenu?UserId={UserId}");
            return await response.ToResultAsync<viewUserRoleMenu[]>();
        }

        public async Task<IResult> Insert(UserRole data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/UserRole/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(UserRole data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/UserRole/update", data);
            return await response.ToResultAsync();
        }

        public async Task<IResultData<HashSet<Menu>>> GetByUserRoleIdMenus(Guid UserRoleId)
        {
            var response = await _httpClient.GetAsync($"api/UserRole/GetByUserRoleIdMenus?UserRoleId={UserRoleId}");
            return await response.ToResultAsync<HashSet<Menu>>();
        }
    }
}
