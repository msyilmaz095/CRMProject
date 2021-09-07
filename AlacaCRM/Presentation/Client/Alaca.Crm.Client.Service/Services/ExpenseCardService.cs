
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
    public class ExpenseCardService : IExpenseCardService
    {
        HttpClient _httpClient;
        public ExpenseCardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(ExpenseCard)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ExpenseCard[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ExpenseCard)}/GetAll");
            return await response.ToResultAsync<ExpenseCard[]>();
        }

        public async Task<IResultData<ExpenseCard>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ExpenseCard)}/GetById?id={id}");
            return await response.ToResultAsync<ExpenseCard>();
        }

        public async Task<IResult> Insert(ExpenseCard data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ExpenseCard)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ExpenseCard data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ExpenseCard)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

