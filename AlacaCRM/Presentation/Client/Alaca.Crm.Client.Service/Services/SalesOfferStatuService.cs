
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System.Net.Http.Json;

namespace Alaca.Crm.Client.Service.Services
{
    public class SalesOfferStatuService : ISalesOfferStatuService
    {
        HttpClient _httpClient;
        public SalesOfferStatuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(byte id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(SalesOfferStatu)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<SalesOfferStatu[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOfferStatu)}/GetAll");
            return await response.ToResultAsync<SalesOfferStatu[]>();
        }

        public async Task<IResultData<SalesOfferStatu>> GetById(byte id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOfferStatu)}/GetById?id={id}");
            return await response.ToResultAsync<SalesOfferStatu>();
        }

        public async Task<IResult> Insert(SalesOfferStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOfferStatu)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(SalesOfferStatu data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOfferStatu)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

