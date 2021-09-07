
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
    public class PaymentMethodService : IPaymentMethodService
    {
        HttpClient _httpClient;
        public PaymentMethodService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(PaymentMethod)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<PaymentMethod[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(PaymentMethod)}/GetAll");
            return await response.ToResultAsync<PaymentMethod[]>();
        }

        public async Task<IResultData<PaymentMethod>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(PaymentMethod)}/GetById?id={id}");
            return await response.ToResultAsync<PaymentMethod>();
        }

        public async Task<IResult> Insert(PaymentMethod data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(PaymentMethod)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(PaymentMethod data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(PaymentMethod)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

