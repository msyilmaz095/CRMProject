
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using System.Net.Http.Json;
using Alaca.Entities.Dto;

namespace Alaca.Crm.Client.Service.Services
{
    public class ActivityService : IActivityService
    {
        HttpClient _httpClient;
        public ActivityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Activity/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<Activity[]>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Activity/GetAll");
            return await response.ToResultAsync<Activity[]>();
        }

        public async Task<IResultData<viewActivity[]>> GetByCustomerIdviewActivities(Guid? id)
        {
            var response = await _httpClient.GetAsync($"api/Activity/GetByCustomerIdviewActivities?id={id}");
            return await response.ToResultAsync<viewActivity[]>();
        }

        public async Task<IResultData<viewActivity[]>> GetByDateBetweenviewActivities(DateTime StartDate, DateTime FinishDate, Guid AssignedToEmployee)
        {
            var response = await _httpClient.GetAsync($"api/Activity/GetByDateBetweenviewActivities?StartDate={StartDate.ToString("yyyy-MM-dd")}&FinishDate={FinishDate.ToString("yyyy-MM-dd")}&AssignedToEmployee={AssignedToEmployee}");
            return await response.ToResultAsync<viewActivity[]>();
        }

        public async Task<IResultData<Activity>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Activity/GetById?id={id}");
            return await response.ToResultAsync<Activity>();
        }

        public async Task<IResultData<viewActivity[]>> GetByProjectIdviewActivities(Guid? ProjectId)
        {
            var response = await _httpClient.GetAsync($"api/Activity/GetByProjectIdviewActivities?ProjectId={ProjectId}");
            return await response.ToResultAsync<viewActivity[]>();
        }

        public async Task<IResultData<viewActivity[]>> GetviewActivities()
        {
            var response = await _httpClient.GetAsync("api/Activity/GetviewActivities");
            return await response.ToResultAsync<viewActivity[]>();
        }

        public async Task<IResult> Insert(Activity data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Activity/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(Activity data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Activity/update", data);
            return await response.ToResultAsync();
        }
    }
}
