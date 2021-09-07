
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
    public class SalesOfferLineService : ISalesOfferLineService
    {
        HttpClient _httpClient;
        public SalesOfferLineService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(SalesOfferLine)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<SalesOfferLine[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOfferLine)}/GetAll");
            return await response.ToResultAsync<SalesOfferLine[]>();
        }

        public async Task<IResultData<SalesOfferLine>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOfferLine)}/GetById?id={id}");
            return await response.ToResultAsync<SalesOfferLine>();
        }

        public async Task<IResultData<SalesOfferLine[]>> GetBySalesOfferIdLines(Guid SalesOfferId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOfferLine)}/GetBySalesOfferIdLines?SalesOfferId="+ SalesOfferId);
            return await response.ToResultAsync<SalesOfferLine[]>();
        }

        public async Task<IResult> Insert(SalesOfferLine data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOfferLine)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(SalesOfferLine data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOfferLine)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

