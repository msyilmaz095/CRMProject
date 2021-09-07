using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using Newtonsoft.Json;

namespace Alaca.Crm.Client.Service.Extensions
{
    public static class ResultExtensions
    {
        public static async Task<IResultData<T>> ToResultAsync<T>(this HttpResponseMessage response)
        {
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<ResultData<T>>(responseAsString);
            return responseObject;
        }

        public static async Task<IResult> ToResultAsync(this HttpResponseMessage response)
        {
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<Result>(responseAsString);
            return responseObject;
        }


    }
}
