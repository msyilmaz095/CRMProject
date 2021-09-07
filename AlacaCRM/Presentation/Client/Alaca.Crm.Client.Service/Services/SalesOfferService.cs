
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using Alaca.Entities.Dto;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace Alaca.Crm.Client.Service.Services
{
    public class SalesOfferService : ISalesOfferService
    {
        HttpClient _httpClient;
        public SalesOfferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(SalesOffer)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<SalesOffer[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetAll");
            return await response.ToResultAsync<SalesOffer[]>();
        }

        public async Task<IResultData<viewSalesOffer[]>> GetByDateTimeBetweenviewSalesOffers(DateTime StartDate, DateTime EndDate)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetByDateBetweenviewSalesOffers?StartDate={string.Format("{0:yyyy-MM-dd}", StartDate)}&EndDate={string.Format("{0:yyyy-MM-dd HH:mm}", EndDate)}");
            return await response.ToResultAsync<viewSalesOffer[]>();
        }

        public async Task<IResultData<SalesOffer>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetById?id={id}");
            return await response.ToResultAsync<SalesOffer>();
        }

        public async Task<IResultData<viewSalesOffer[]>> GetByProjectIdSalesOffers(Guid ProjectId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetByProjectIdSalesOffers?ProjectId={ProjectId}");
            return await response.ToResultAsync<viewSalesOffer[]>();
        }

        public async Task<IResultData<viewSalesOffer[]>> GetviewSalesOffers()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetviewSalesOffers");
            return await response.ToResultAsync<viewSalesOffer[]>();
        }

        public async Task<IResult> Insert(SalesOffer data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOffer)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> SalesOfferInsert(SalesOffer data, List<SalesOfferLine> salesOfferLines)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOffer)}/SalesOfferInsert", new { data = data, salesOfferLines = salesOfferLines });
            return await response.ToResultAsync();
        }
        public async Task<IResult> SalesOfferUpdate(SalesOffer data, List<SalesOfferLine> salesOfferLines)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOffer)}/SalesOfferupdate", new { data = data, salesOfferLines = salesOfferLines });
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(SalesOffer data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(SalesOffer)}/update", data);
            return await response.ToResultAsync();
        }

        public async Task<IResultData<viewSalesOffer[]>> GetOrderDescTop10viewSalesOffers()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(SalesOffer)}/GetOrderDescTop10viewSalesOffers");
            return await response.ToResultAsync<viewSalesOffer[]>();
        }
    }
}

