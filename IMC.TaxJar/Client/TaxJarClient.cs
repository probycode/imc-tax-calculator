using IMC.Common.Interfaces;
using IMC.TaxJar.Client.Requests;
using IMC.TaxJar.Client.Responses;
using IMC.TaxJar.Common.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IMC.TaxJar.Client
{
    public class TaxJarClient
    {
        private const string URL_BASE = "https://api.taxjar.com/v2";

        private readonly ILogger<TaxJarClient> _logger;
        private readonly HttpClient _httpClient;

        public TaxJarClient(ILogger<TaxJarClient> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "5da2f821eee4035db4771edab942a4cc");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// https://developers.taxjar.com/api/reference/?csharp#get-show-tax-rates-for-a-location
        /// </summary>
        /// <param name="parames"></param>
        /// <returns></returns>
        public async Task<RatesForLocationResponse> RatesForLocation(object request)
        {
            try
            {
                StringBuilder url = new StringBuilder()
                    .Append($"{URL_BASE}/rates?")
                    .Append(request.ToQueryString());

                _logger.LogInformation($"Getting rates for location");
                using (var response = await _httpClient.GetAsync(url.ToString()))
                {
                    _logger.LogInformation($"Retrieved rates for location with status code {response.StatusCode}");

                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"Error with status code {response.StatusCode}");

                    string responseString = await response.Content.ReadAsStringAsync();
                    var outpout = JsonConvert.DeserializeObject<RatesForLocationResponse>(responseString);

                    _logger.LogInformation($"successfully retrieved rates for location");
                    return outpout;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// https://developers.taxjar.com/api/reference/#post-calculate-sales-tax-for-an-order
        /// </summary>
        /// <param name="quaryPeram"></param>
        /// <returns></returns>
        public async Task<TaxForOrderResponse> TaxForOrder(object request)
        {
            try
            {
                StringBuilder url = new StringBuilder()
                    .Append($"{URL_BASE}/taxes");

                var json = JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                _logger.LogInformation($"Getting tax for order");
                using (var response = await _httpClient.PostAsync("https://api.taxjar.com/v2/taxes", content))
                {
                    _logger.LogInformation($"Retrieved tax for order with status code {response.StatusCode}");

                    string responseString = await response.Content.ReadAsStringAsync();
                    var outpout = JsonConvert.DeserializeObject<TaxForOrderResponse>(responseString);

                    _logger.LogInformation($"successfully retrieved tax for order");
                    return outpout;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
