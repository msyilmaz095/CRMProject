
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using Microsoft.AspNetCore.Components;
using Alaca.Entities.Dto;
using System;

namespace Alaca.Crm.Client.Service.Services
{
    public class CurrencyValueService : ICurrencyValueService
    {
        HttpClient _httpClient;
        public CurrencyValueService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(CurrencyValue)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<CurrencyValue[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(CurrencyValue)}/GetAll");
            return await response.ToResultAsync<CurrencyValue[]>();
        }

        public async Task<IResultData<CurrencyValue>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(CurrencyValue)}/GetById?id={id}");
            return await response.ToResultAsync<CurrencyValue>();
        }

        public async Task<IResultData<viewCurrencyValue[]>> GetviewCurrencyValue()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(CurrencyValue)}/GetAllviewCurrencyValue");
            return await response.ToResultAsync<viewCurrencyValue[]>();
        }
        public async Task<IResult> Insert(CurrencyValue data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(CurrencyValue)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(CurrencyValue data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(CurrencyValue)}/update", data);
            return await response.ToResultAsync();
        }
    }
}
